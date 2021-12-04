using Newtonsoft.Json;
using Notes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private String jsonString;

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
                WorkPlaces workPlace = new(workPlaceTB.Text, livingPlaceTB.Text, singleLimitTB.Text, doubleLimitTB.Text, travelMoneyTB.Text);
                Branches branch = new(branchTB.Text);

                branchesLB.Items.Add(branch);
                branchesLB.Sorted = true;

                branchesList.Add(branch);
                branchesList.Sort((left, right) => left.name.CompareTo(right.name));
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

        
        private void DeleteBranchBtn_Click(object sender, EventArgs e)
        {
            if (branchesLB.SelectedIndex > -1)
            {
                branchesList.RemoveAt(branchesLB.SelectedIndex);
                branchesLB.Items.RemoveAt(branchesLB.SelectedIndex);
            }
        }
    }
}


