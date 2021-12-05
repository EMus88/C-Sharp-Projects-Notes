using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.IO;
using MySql.Data.MySqlClient;
using Notes;
using System.Data.Common;

namespace WinFormsApp1
{
    public partial class Docladnie : Form
    {
        private List<Branches> branchesList = new();
        private List<Workers> workersList = new();


        public Docladnie()

        {
            InitializeComponent();
        }

        //кнопки меню=================================================================================

        private void EditorFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Docladnie_Load(sender, e);
        }

        private void WorkersMenu_Click(object sender, EventArgs e)
        {
            WorkersEditor workersEditor = new();
            workersEditor.Show();

            //при закрытии формы обновляется предыдущая форма
            workersEditor.FormClosed += new FormClosedEventHandler(EditorFormClosed);
        }

        private void ObjectsMenu_Click(object sender, EventArgs e)
        {
            ObjectsForm objectsForm = new();
            objectsForm.Show();

            //при закрытии формы обновляется предыдущая форма
            objectsForm.FormClosed += new FormClosedEventHandler(EditorFormClosed);
        }
        //нажатие кнопки закрытия формы====================================================================
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }


        //загрузка формы=====================================================================================
        private void Docladnie_Load(object sender, EventArgs e)
        {
            FirstWorkerCmb.Items.Clear();
            SecondWorkerCmb.Items.Clear();
            BranchCmb.Items.Clear();
            ObjCmb.Items.Clear();
            branchesList.Clear();
            workersList.Clear();

            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();


            using (MySqlCommand cmd = new("Select * from worker; Select * from branch;", connection))
            using (var sqlReader = cmd.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    string name = sqlReader.GetString(1);
                    string surname = sqlReader.GetString(2);
                    Workers worker = new(name, surname);
                    FirstWorkerCmb.Items.Add(worker);
                    SecondWorkerCmb.Items.Add(worker);
                    workersList.Add(worker);
                    FirstWorkerCmb.Sorted = true;
                    SecondWorkerCmb.Sorted = true;
                    workersList.Sort((left, right) => left.surname.CompareTo(right.surname));
                    worker.id = sqlReader.GetInt32(0);

                }
                if (sqlReader.NextResult())
                {
                    while (sqlReader.Read())
                    {
                        string name = sqlReader.GetString(1);
                        Branches branch = new(name);
                        branch.id = sqlReader.GetInt32(0);
                        BranchCmb.Items.Add(branch);
                        branchesList.Add(branch);
                    }
                }
            }
            branchesList.Sort((left, right) => left.name.CompareTo(right.name));
            BranchCmb.Sorted = true;

            for (int i = 1; i < 31; i++)
            {
                DaysCountCmb.Items.Add(i);
            }
        }

        //отрисовка бордеров панелей==========================================================================
        private void WorkersPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }
        private void VahtaPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Gray, ButtonBorderStyle.Dashed);
        }

        //проверка соединения с базой данных
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();

            try
            {
                connection.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        //выбор филиала из списка
        private void BranchCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BranchCmb.SelectedIndex > -1)
            {
                ObjCmb.Items.Clear();
                ObjCmb.Text = "";

                MySqlConnection connection = DBUtils.GetDBConnection();
                connection.Open();

                string sql = "Select * from object where fil_id=@fil_id";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.Parameters.AddWithValue("@fil_id", branchesList[BranchCmb.SelectedIndex].id);
                cmd.CommandText = sql;
                using DbDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString(1);
                        WorkPlaces workPlace = new(name);
                        workPlace.id = reader.GetInt32(0);
                        ObjCmb.Items.Add(workPlace);
                        branchesList[BranchCmb.SelectedIndex].listPlaces.Add(workPlace);
                    }
                }
            }
        }

        //кнопка сформировать докладную
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (FirstWorkerCmb.Text != "" && BranchCmb.Text != "" && ObjCmb.Text != "" && DaysCountCmb.Text != "")
            {
                //добавление в базу данных
                MySqlConnection connection = DBUtils.GetDBConnection();

                try
                {
                    connection.Open();
                    string sql = "Insert into note (start_date, days_number, fil_id, obj_id, worker_id) values (@start_date, @days_number, @fil_id, @obj_id, @worker_id)";
                    MySqlCommand cmd = connection.CreateCommand();

                    cmd.Parameters.AddWithValue("@start_date", dateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@days_number", Convert.ToInt32(DaysCountCmb.Text));
                    cmd.Parameters.AddWithValue("@fil_id", branchesList[BranchCmb.SelectedIndex].id);
                    cmd.Parameters.AddWithValue("@obj_id", branchesList[BranchCmb.SelectedIndex].listPlaces[ObjCmb.SelectedIndex].id);
                    cmd.Parameters.AddWithValue("@worker_id", workersList[FirstWorkerCmb.SelectedIndex].id);

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
