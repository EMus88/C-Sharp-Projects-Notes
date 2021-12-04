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
    public partial class ObjectsForm : Form
    {
        private List<Branches> branchesList = new();
        

        public ObjectsForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addFilBtn_Click(object sender, EventArgs e)
        {
            if (branchTB.Text != "")
            {
                Branches branch = new(branchTB.Text);

                branchesLB.Items.Add(branch);
                branchesLB.Sorted = true;

                branchesList.Add(branch);
                branchesList.Sort((left, right) => left.name.CompareTo(right.name));

                //добавление в базу данных
                MySqlConnection connection = DBUtils.GetDBConnection();

                try
                {
                    connection.Open();
                    string sql = "Insert into branch (name) values (@name)";
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.Parameters.AddWithValue("@name", branch.name);
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

        }

        private void AddObjBtn_Click(object sender, EventArgs e)
        {
            if (branchesLB.SelectedIndex > -1)
            {
                if (workPlaceTB.Text != "")
                {
                    WorkPlaces workPlace = new(workPlaceTB.Text, livingPlaceTB.Text, singleLimitTB.Text, doubleLimitTB.Text, travelMoneyTB.Text);
                    branchesList[branchesLB.SelectedIndex].listPlaces.Add(workPlace);
                    branchesList[branchesLB.SelectedIndex].listPlaces.Sort((left, right) => left.name.CompareTo(right.name));
                    workPlacesLB.Items.Add(workPlace);
                    workPlacesLB.Sorted = true;
                }
                else
                {
                    MessageBox.Show("Не заполнено название объекта");
                }
            }
        }
        // выбор филиала из списка
        private void branchesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (branchesLB.SelectedIndex > -1)
            {
                workPlacesLB.Items.Clear();

                foreach (var item in branchesList[branchesLB.SelectedIndex].listPlaces)
                {
                    workPlacesLB.Items.Add(item);
                }
            }

        }

        //кнопка удалить филиал
        private void DeleteBranchBtn_Click(object sender, EventArgs e)
        {
            if (branchesLB.SelectedIndex > -1)
            {
                branchesList.RemoveAt(branchesLB.SelectedIndex);
                branchesLB.Items.RemoveAt(branchesLB.SelectedIndex);
            }
        }

        //загрузка формы
        private void ObjectsForm_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            string sql = "Select * from branch";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            using DbDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    string name = reader.GetString(1);
                    string surname = reader.GetString(2);
                    Branches branch = new Branches(name);
                    branchesLB.Items.Add(branch);
                    branchesList.Add(branch);
                    branchesLB.Sorted = true;
                    branchesList.Sort((left, right) => left.name.CompareTo(right.name));
                }

        }
    }
}


