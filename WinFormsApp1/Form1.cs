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

namespace WinFormsApp1
{
    public partial class Docladnie : Form
    {
        public Docladnie()

        {
            InitializeComponent();
        }

        //кнопки меню=================================================================================
        private void WorkersMenu_Click(object sender, EventArgs e)
        {
            WorkersEditor workersEditor = new();
            workersEditor.Show();

            {
                workersEditor.FormClosed += new FormClosedEventHandler(workersEditor_FormClosed);
            }

            void workersEditor_FormClosed(object sender, FormClosedEventArgs e)
            {
                this.Docladnie_Load(sender, e);
            }

        }

        private void ObjectsMenu_Click(object sender, EventArgs e)
        {
            ObjectsForm objectsForm = new();
            objectsForm.Show();
        }
        //нажатие кнопки закрытия формы====================================================================
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        //функция заполнения комбобоксов с работниками========================================================
        private void AddWorkers(string jsonString, ComboBox combobox)
        {
            List<Workers> listFromFile = new();
            listFromFile = JsonConvert.DeserializeObject<List<Workers>>(jsonString);
            if (listFromFile != null)
            {
                combobox.Items.Clear();
                foreach (var item in listFromFile)
                {
                    combobox.Items.Add(item);

                }
            }
        }

        //загрузка формы=====================================================================================
        private void Docladnie_Load(object sender, EventArgs e)
        {
            String jsonString = "";
            try
            {
                jsonString = File.ReadAllText(Application.StartupPath + @"\Workers.txt");
            }
            catch
            {
                jsonString = "";
            }
            finally
            {
                AddWorkers(jsonString, FirstWorkerCmb);
                AddWorkers(jsonString, SecondWorkerCmb);
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
            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                conn.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: "+ err.Message,"Attention",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
    }
}
