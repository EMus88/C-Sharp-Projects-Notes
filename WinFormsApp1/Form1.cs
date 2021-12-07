using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Notes;
using System.Data.Common;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;

namespace WinFormsApp1
{
    public partial class Docladnie : Form
    {
        private List<Branch> branchesList = new();
        private List<Worker> workersList = new();


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
            BranchCmbxReport.Items.Clear();
            WorkerCmbxReport.Items.Clear();
            WorkerCmbxReport.Text = "";
            ObjCmb.Items.Clear();
            branchesList.Clear();
            workersList.Clear();


            MySqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();

            //чтение данных о работниках и объектах из базы данных
            using (MySqlCommand cmd = new("Select * from worker; Select * from branch;", connection))
            using (var sqlReader = cmd.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    string name = sqlReader.GetString(1);
                    string surname = sqlReader.GetString(2);
                    Worker worker = new(name, surname);
                    workersList.Add(worker);
                    worker.id = sqlReader.GetInt32(0);
                }

                if (sqlReader.NextResult())
                {
                    while (sqlReader.Read())
                    {
                        string name = sqlReader.GetString(1);
                        Branch branch = new(name);
                        branch.id = sqlReader.GetInt32(0);
                        branchesList.Add(branch);
                    }
                }
            }
            //заполнение комбобоксов
            workersList.Sort((left, right) => left.surname.CompareTo(right.surname));
            foreach (Worker worker in workersList)
            {
                FirstWorkerCmb.Items.Add(worker);
                SecondWorkerCmb.Items.Add(worker);
                WorkerCmbxReport.Items.Add(worker);
            }

            branchesList.Sort((left, right) => left.name.CompareTo(right.name));
            foreach (Branch branch in branchesList)
            {
                BranchCmb.Items.Add(branch);
                BranchCmbxReport.Items.Add(branch);
            }
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
                        WorkPlace workPlace = new(name);
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

                    this.dataGridView.Rows.Add(dateTimePicker.Value.ToString("dd.MM.yyyy"), DaysCountCmb.Text, branchesList[BranchCmb.SelectedIndex],
                 branchesList[BranchCmb.SelectedIndex].listPlaces[ObjCmb.SelectedIndex], workersList[FirstWorkerCmb.SelectedIndex]);
                    this.dataGridView.Sort(StartDate, System.ComponentModel.ListSortDirection.Descending);

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

        //кнопка формирования отчета
        private void CrtReportBtn_Click(object sender, EventArgs e)
        {
            this.dataGridViewReport.Rows.Clear();
            MySqlConnection connection = DBUtils.GetDBConnection();
            String startDate;
            int daysCountReport;
            String branchReport;
            String objectReport;
            String workerReport;

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                string sql = "select note.*,object.name,branch.name,worker.name,worker.surname from note " +
                                        "left join object on object.id=note.obj_id " +
                                        "left join branch on branch.id=note.fil_id " +
                                        "left join worker on worker.id=note.worker_id " +
                                        "where note.start_date between @start and @stop";

                if (WorkerChkbx.Checked)
                {
                    if (WorkerCmbxReport.SelectedIndex > -1)
                    {
                        sql = sql + " and worker.name=@workerName and worker.surname=@workerSurname";
                        cmd.Parameters.AddWithValue("@workerName", workersList[WorkerCmbxReport.SelectedIndex].name);
                        cmd.Parameters.AddWithValue("@workerSurname", workersList[WorkerCmbxReport.SelectedIndex].surname);
                    }
                    else
                    {
                        MessageBox.Show("Не выбран работник");
                        sql = "";
                    }
                }

                if (BranchChbx.Checked)
                {
                    if (BranchCmbxReport.SelectedIndex > -1)
                    {
                        sql = sql + " and branch.name=@name";
                        cmd.Parameters.AddWithValue("@name", branchesList[BranchCmbxReport.SelectedIndex].name);
                    }
                    else
                    {
                        MessageBox.Show("Не выбран филиал");
                        sql = "";
                    }
                }

                cmd.Parameters.AddWithValue("@start", dateTimePickerReportStart.Value.Date);
                cmd.Parameters.AddWithValue("@stop", dateTimePickerReportStop.Value.Date);

                if (sql != "")
                {
                    cmd.CommandText = sql;
                    using DbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            startDate = reader.GetDateTime(1).ToString("dd.MM.yyyy");
                            daysCountReport = reader.GetInt32(2);
                            branchReport = reader.GetString(7);
                            objectReport = reader.GetString(6);
                            workerReport = reader.GetString(9) + " " + reader.GetString(8);

                            this.dataGridViewReport.Rows.Add(startDate, daysCountReport, branchReport, objectReport, workerReport);

                        }
                    }
                }
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

        //сохранение отчета в excel
        private void SaveBtnReport_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ())
            {
                //запись данных из датагрид в ячейки
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Report");

                worksheet.Row(1).Style.Font.Bold = true;

                for (int j = 0; j < dataGridViewReport.Columns.Count; ++j)
                {
                    worksheet.Cells[1, j + 1].Value = dataGridView.Columns[j].HeaderText;
                    worksheet.Cells[1, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Column(j + 1).Width = 30;
                    worksheet.Column(j + 1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Column(j + 1).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }

                for (int i = 0; i < dataGridViewReport.Rows.Count; ++i)
                {
                    for (int j = 0; j < dataGridViewReport.Columns.Count; ++j)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridViewReport[j, i].Value;
                        worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    }
                }

                byte[] bin = excelPackage.GetAsByteArray();

                //создание диалогового окна
                SaveFileDialog saveFileDialog1 = new();
                saveFileDialog1.Title = "Save Excel sheet";
                saveFileDialog1.Filter = "Excel files|*.xlsx|All files|*.*";
                saveFileDialog1.FileName = "Report.xlsx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //сохранение файла
                    File.WriteAllBytes(saveFileDialog1.FileName, bin);
                }

            }
        }
    }
}
