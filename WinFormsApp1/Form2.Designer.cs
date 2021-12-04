
namespace WinFormsApp1
{
    partial class WorkersEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.positionTB = new System.Windows.Forms.TextBox();
            this.AddWorkerBtn = new System.Windows.Forms.Button();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(522, 460);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 36);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 452);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTb.Location = new System.Drawing.Point(428, 12);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(184, 21);
            this.nameTb.TabIndex = 2;
            // 
            // positionTB
            // 
            this.positionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.positionTB.Location = new System.Drawing.Point(428, 89);
            this.positionTB.Name = "positionTB";
            this.positionTB.Size = new System.Drawing.Size(184, 21);
            this.positionTB.TabIndex = 4;
            // 
            // AddWorkerBtn
            // 
            this.AddWorkerBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddWorkerBtn.Location = new System.Drawing.Point(428, 220);
            this.AddWorkerBtn.Name = "AddWorkerBtn";
            this.AddWorkerBtn.Size = new System.Drawing.Size(163, 35);
            this.AddWorkerBtn.TabIndex = 6;
            this.AddWorkerBtn.Text = "Добавить работника";
            this.AddWorkerBtn.UseVisualStyleBackColor = true;
            this.AddWorkerBtn.Click += new System.EventHandler(this.AddWorkerBtn_Click);
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTB.Location = new System.Drawing.Point(428, 125);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(184, 21);
            this.phoneNumberTB.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(317, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(30, 16);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Имя";
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositionLabel.Location = new System.Drawing.Point(317, 91);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(73, 16);
            this.PositionLabel.TabIndex = 12;
            this.PositionLabel.Text = "Должность";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.Location = new System.Drawing.Point(317, 130);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(106, 16);
            this.PhoneNumberLabel.TabIndex = 13;
            this.PhoneNumberLabel.Text = "Номер телефона";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearBtn.Location = new System.Drawing.Point(428, 323);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(163, 35);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Очистить список";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBtn.Location = new System.Drawing.Point(428, 272);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(163, 35);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Удалить работника";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // surnameTb
            // 
            this.surnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameTb.Location = new System.Drawing.Point(428, 52);
            this.surnameTb.Multiline = true;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(184, 23);
            this.surnameTb.TabIndex = 3;
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLbl.Location = new System.Drawing.Point(317, 54);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(60, 16);
            this.surnameLbl.TabIndex = 11;
            this.surnameLbl.Text = "Фамилия";
            // 
            // WorkersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(629, 508);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PositionLabel);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.phoneNumberTB);
            this.Controls.Add(this.AddWorkerBtn);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CloseBtn);
            this.Name = "WorkersEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список работников";
            this.Load += new System.EventHandler(this.WorkersEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox positionTB;
        private System.Windows.Forms.Button AddWorkerBtn;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label surnameLbl;
    }
}