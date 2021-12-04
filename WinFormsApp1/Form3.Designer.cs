
namespace WinFormsApp1
{
    partial class ObjectsForm
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
            this.branchesLB = new System.Windows.Forms.ListBox();
            this.workPlacesLB = new System.Windows.Forms.ListBox();
            this.branchTB = new System.Windows.Forms.TextBox();
            this.workPlaceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.livingPlaceTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.singleLimitTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doubleLimitTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.travelMoneyTB = new System.Windows.Forms.TextBox();
            this.addFilBtn = new System.Windows.Forms.Button();
            this.AddObjBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeleteBranchBtn = new System.Windows.Forms.Button();
            this.deleteObjBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // branchesLB
            // 
            this.branchesLB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branchesLB.FormattingEnabled = true;
            this.branchesLB.ItemHeight = 16;
            this.branchesLB.Location = new System.Drawing.Point(12, 35);
            this.branchesLB.Name = "branchesLB";
            this.branchesLB.Size = new System.Drawing.Size(212, 388);
            this.branchesLB.TabIndex = 0;
            this.branchesLB.SelectedIndexChanged += new System.EventHandler(this.branchesLB_SelectedIndexChanged);
            // 
            // workPlacesLB
            // 
            this.workPlacesLB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workPlacesLB.FormattingEnabled = true;
            this.workPlacesLB.ItemHeight = 16;
            this.workPlacesLB.Location = new System.Drawing.Point(254, 35);
            this.workPlacesLB.Name = "workPlacesLB";
            this.workPlacesLB.Size = new System.Drawing.Size(213, 388);
            this.workPlacesLB.TabIndex = 1;
            // 
            // branchTB
            // 
            this.branchTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.branchTB.Location = new System.Drawing.Point(12, 429);
            this.branchTB.Name = "branchTB";
            this.branchTB.Size = new System.Drawing.Size(212, 23);
            this.branchTB.TabIndex = 2;
            // 
            // workPlaceTB
            // 
            this.workPlaceTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.workPlaceTB.Location = new System.Drawing.Point(255, 429);
            this.workPlaceTB.Name = "workPlaceTB";
            this.workPlaceTB.Size = new System.Drawing.Size(212, 23);
            this.workPlaceTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список филиалов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список объектов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(547, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Место проживания";
            // 
            // livingPlaceTB
            // 
            this.livingPlaceTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.livingPlaceTB.Location = new System.Drawing.Point(489, 38);
            this.livingPlaceTB.Name = "livingPlaceTB";
            this.livingPlaceTB.Size = new System.Drawing.Size(222, 23);
            this.livingPlaceTB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(518, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Лимит поживания на одного";
            // 
            // singleLimitTB
            // 
            this.singleLimitTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.singleLimitTB.Location = new System.Drawing.Point(491, 83);
            this.singleLimitTB.Name = "singleLimitTB";
            this.singleLimitTB.Size = new System.Drawing.Size(222, 23);
            this.singleLimitTB.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(518, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Лимит поживания на двоих";
            // 
            // doubleLimitTB
            // 
            this.doubleLimitTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doubleLimitTB.Location = new System.Drawing.Point(491, 128);
            this.doubleLimitTB.Name = "doubleLimitTB";
            this.doubleLimitTB.Size = new System.Drawing.Size(224, 23);
            this.doubleLimitTB.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(547, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Командировочные";
            // 
            // travelMoneyTB
            // 
            this.travelMoneyTB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.travelMoneyTB.Location = new System.Drawing.Point(491, 173);
            this.travelMoneyTB.Name = "travelMoneyTB";
            this.travelMoneyTB.Size = new System.Drawing.Size(222, 23);
            this.travelMoneyTB.TabIndex = 8;
            // 
            // addFilBtn
            // 
            this.addFilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addFilBtn.Location = new System.Drawing.Point(12, 472);
            this.addFilBtn.Name = "addFilBtn";
            this.addFilBtn.Size = new System.Drawing.Size(212, 29);
            this.addFilBtn.TabIndex = 9;
            this.addFilBtn.Text = "Добавить филиал";
            this.addFilBtn.UseVisualStyleBackColor = true;
            this.addFilBtn.Click += new System.EventHandler(this.addFilBtn_Click);
            // 
            // AddObjBtn
            // 
            this.AddObjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddObjBtn.Location = new System.Drawing.Point(255, 472);
            this.AddObjBtn.Name = "AddObjBtn";
            this.AddObjBtn.Size = new System.Drawing.Size(212, 29);
            this.AddObjBtn.TabIndex = 10;
            this.AddObjBtn.Text = "Добавить объект";
            this.AddObjBtn.UseVisualStyleBackColor = true;
            this.AddObjBtn.Click += new System.EventHandler(this.AddObjBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(594, 544);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(117, 34);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeleteBranchBtn
            // 
            this.DeleteBranchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteBranchBtn.Location = new System.Drawing.Point(12, 507);
            this.DeleteBranchBtn.Name = "DeleteBranchBtn";
            this.DeleteBranchBtn.Size = new System.Drawing.Size(212, 29);
            this.DeleteBranchBtn.TabIndex = 13;
            this.DeleteBranchBtn.Text = "Удалить филиал";
            this.DeleteBranchBtn.UseVisualStyleBackColor = true;
            this.DeleteBranchBtn.Click += new System.EventHandler(this.DeleteBranchBtn_Click);
            // 
            // deleteObjBtn
            // 
            this.deleteObjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteObjBtn.Location = new System.Drawing.Point(254, 507);
            this.deleteObjBtn.Name = "deleteObjBtn";
            this.deleteObjBtn.Size = new System.Drawing.Size(213, 29);
            this.deleteObjBtn.TabIndex = 14;
            this.deleteObjBtn.Text = "Удалить объект";
            this.deleteObjBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(725, 590);
            this.Controls.Add(this.deleteObjBtn);
            this.Controls.Add(this.DeleteBranchBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AddObjBtn);
            this.Controls.Add(this.addFilBtn);
            this.Controls.Add(this.travelMoneyTB);
            this.Controls.Add(this.doubleLimitTB);
            this.Controls.Add(this.singleLimitTB);
            this.Controls.Add(this.livingPlaceTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workPlaceTB);
            this.Controls.Add(this.branchTB);
            this.Controls.Add(this.workPlacesLB);
            this.Controls.Add(this.branchesLB);
            this.Name = "ObjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактор объектов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox branchesLB;
        private System.Windows.Forms.ListBox workPlacesLB;
        private System.Windows.Forms.TextBox branchTB;
        private System.Windows.Forms.TextBox workPlaceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox livingPlaceTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox singleLimitTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doubleLimitTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox travelMoneyTB;
        private System.Windows.Forms.Button addFilBtn;
        private System.Windows.Forms.Button AddObjBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button DeleteBranchBtn;
        private System.Windows.Forms.Button deleteObjBtn;
    }
}