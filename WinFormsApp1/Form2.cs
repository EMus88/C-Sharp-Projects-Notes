using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Notes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class WorkersEditor : Form
    {
        private List<Workers> workersList = new();
        

        public WorkersEditor()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();

        }

        //загрузка формы
        private void WorkersEditor_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string sql = "Select * from worker";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            using DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    string surname = reader.GetString(2);
                    Workers worker = new (name, surname);
                    listBox1.Items.Add(worker);
                    workersList.Add(worker);
                    listBox1.Sorted = true;
                    workersList.Sort((left, right) => left.surname.CompareTo(right.surname));
                }

        }
        //Кнопка добавления нового работника
        private void AddWorkerBtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text != "" && surnameTb.Text != "")
            {
                Workers worker = new (nameTb.Text, surnameTb.Text);
                listBox1.Items.Add(worker);
                workersList.Add(worker);
                listBox1.Sorted = true;
                workersList.Sort((left, right) => left.surname.CompareTo(right.surname));

                //добавление в базу данных
                MySqlConnection connection = DBUtils.GetDBConnection();

                try
                {
                    connection.Open();
                    string sql = "Insert into worker (name, surname) values (@name, @surname)";
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.Parameters.AddWithValue("@name", worker.name);
                    cmd.Parameters.AddWithValue("@surname", worker.surname);
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
                    connection = null;
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }

        }
        //Кнопка очистить список работников
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            workersList.Clear();

            MySqlConnection connection = DBUtils.GetDBConnection();

            try
            {
                connection.Open();
                string sql = "Delete from worker";
                MySqlCommand cmd = connection.CreateCommand();
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

        //кнопка удалить работника
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                
                //удаление из базы данных
                MySqlConnection connection = DBUtils.GetDBConnection();

                try
                {
                    connection.Open();
                    //удаление всех объектов филиала
                    string sql = "Delete from worker where name=@name and surname=@surname";
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.Parameters.AddWithValue("@name", workersList[listBox1.SelectedIndex].name);
                    cmd.Parameters.AddWithValue("@surname", workersList[listBox1.SelectedIndex].surname);
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

                workersList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }
        }

        //выбор элемента в списке
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                nameTb.Text = workersList[listBox1.SelectedIndex].name;
                surnameTb.Text = workersList[listBox1.SelectedIndex].surname;

            }

        }
    }
}
