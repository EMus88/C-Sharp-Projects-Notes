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

            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();


            using (MySqlCommand cmd = new ("Select * from worker; Select * from branch;", connection))
            using (var sqlReader = cmd.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    string name = sqlReader.GetString(1);
                    string surname = sqlReader.GetString(2);
                    Workers worker = new(name, surname);
                    FirstWorkerCmb.Items.Add(worker);
                    SecondWorkerCmb.Items.Add(worker);
                }
                if (sqlReader.NextResult())
                {
                    while (sqlReader.Read())
                    {
                        string name = sqlReader.GetString(1);
                        Branches branch = new(name);
                        BranchCmb.Items.Add(branch);
                    }
                }
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


    }
}
