
namespace WinFormsApp1
{
    partial class Docladnie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docladnie));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedactorsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Repots = new System.Windows.Forms.TabPage();
            this.Obj = new System.Windows.Forms.TabPage();
            this.connectionDBbtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BranchCmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FirstWorkerCmb = new System.Windows.Forms.ComboBox();
            this.SecondWorkerCmb = new System.Windows.Forms.ComboBox();
            this.VahtaPanel = new System.Windows.Forms.Panel();
            this.KomandRbtn = new System.Windows.Forms.RadioButton();
            this.VahtRBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WorkersLabel = new System.Windows.Forms.Label();
            this.Objects = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.Obj.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.VahtaPanel.SuspendLayout();
            this.Objects.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(1153, 604);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(147, 24);
            this.CloseBtn.TabIndex = 7;
            this.CloseBtn.Text = "Закрыть";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.RedactorsMenu,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1306, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newToolStripMenuItem.Text = "&Новый";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.printToolStripMenuItem.Text = "&Печать";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editToolStripMenuItem.Text = "&Правка";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.undoToolStripMenuItem.Text = "Отменить";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.redoToolStripMenuItem.Text = "Вернуть";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cutToolStripMenuItem.Text = "Вырезать";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pasteToolStripMenuItem.Text = "Вставить";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(171, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.selectAllToolStripMenuItem.Text = "Выделить все";
            // 
            // RedactorsMenu
            // 
            this.RedactorsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WorkersMenu,
            this.ObjectsMenu});
            this.RedactorsMenu.Name = "RedactorsMenu";
            this.RedactorsMenu.Size = new System.Drawing.Size(55, 20);
            this.RedactorsMenu.Text = "Списки";
            // 
            // WorkersMenu
            // 
            this.WorkersMenu.Name = "WorkersMenu";
            this.WorkersMenu.Size = new System.Drawing.Size(173, 22);
            this.WorkersMenu.Text = "Список работников";
            this.WorkersMenu.Click += new System.EventHandler(this.WorkersMenu_Click);
            // 
            // ObjectsMenu
            // 
            this.ObjectsMenu.Name = "ObjectsMenu";
            this.ObjectsMenu.Size = new System.Drawing.Size(173, 22);
            this.ObjectsMenu.Text = "Список объектов";
            this.ObjectsMenu.Click += new System.EventHandler(this.ObjectsMenu_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.helpToolStripMenuItem.Text = "&Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // Repots
            // 
            this.Repots.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Repots.Location = new System.Drawing.Point(4, 22);
            this.Repots.Name = "Repots";
            this.Repots.Size = new System.Drawing.Size(1292, 545);
            this.Repots.TabIndex = 2;
            this.Repots.Text = "Отчет";
            // 
            // Obj
            // 
            this.Obj.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Obj.Controls.Add(this.connectionDBbtn);
            this.Obj.Controls.Add(this.CreateBtn);
            this.Obj.Controls.Add(this.comboBox2);
            this.Obj.Controls.Add(this.dateTimePicker);
            this.Obj.Controls.Add(this.panel2);
            this.Obj.Controls.Add(this.panel1);
            this.Obj.Controls.Add(this.VahtaPanel);
            this.Obj.Controls.Add(this.label3);
            this.Obj.Controls.Add(this.label2);
            this.Obj.Controls.Add(this.label6);
            this.Obj.Controls.Add(this.label1);
            this.Obj.Controls.Add(this.WorkersLabel);
            this.Obj.Location = new System.Drawing.Point(4, 22);
            this.Obj.Name = "Obj";
            this.Obj.Padding = new System.Windows.Forms.Padding(3);
            this.Obj.Size = new System.Drawing.Size(1292, 545);
            this.Obj.TabIndex = 0;
            this.Obj.Text = "Докладная на вахту/командировку";
            // 
            // connectionDBbtn
            // 
            this.connectionDBbtn.Location = new System.Drawing.Point(405, 9);
            this.connectionDBbtn.Name = "connectionDBbtn";
            this.connectionDBbtn.Size = new System.Drawing.Size(221, 34);
            this.connectionDBbtn.TabIndex = 14;
            this.connectionDBbtn.Text = "Проверка соединения с БД";
            this.connectionDBbtn.UseVisualStyleBackColor = true;
            this.connectionDBbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Location = new System.Drawing.Point(229, 367);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(142, 40);
            this.CreateBtn.TabIndex = 13;
            this.CreateBtn.Text = "Сформировать";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 117);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(220, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(143, 71);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(220, 21);
            this.dateTimePicker.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.BranchCmb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(128, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 113);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.VahtaPanel_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // BranchCmb
            // 
            this.BranchCmb.FormattingEnabled = true;
            this.BranchCmb.Location = new System.Drawing.Point(15, 28);
            this.BranchCmb.Name = "BranchCmb";
            this.BranchCmb.Size = new System.Drawing.Size(220, 24);
            this.BranchCmb.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(90, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Объект";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(66, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "Место работы";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FirstWorkerCmb);
            this.panel1.Controls.Add(this.SecondWorkerCmb);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(128, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.VahtaPanel_Paint);
            // 
            // FirstWorkerCmb
            // 
            this.FirstWorkerCmb.FormattingEnabled = true;
            this.FirstWorkerCmb.Location = new System.Drawing.Point(15, 6);
            this.FirstWorkerCmb.Name = "FirstWorkerCmb";
            this.FirstWorkerCmb.Size = new System.Drawing.Size(220, 24);
            this.FirstWorkerCmb.TabIndex = 1;
            // 
            // SecondWorkerCmb
            // 
            this.SecondWorkerCmb.FormattingEnabled = true;
            this.SecondWorkerCmb.Location = new System.Drawing.Point(15, 33);
            this.SecondWorkerCmb.Name = "SecondWorkerCmb";
            this.SecondWorkerCmb.Size = new System.Drawing.Size(220, 24);
            this.SecondWorkerCmb.TabIndex = 3;
            // 
            // VahtaPanel
            // 
            this.VahtaPanel.Controls.Add(this.KomandRbtn);
            this.VahtaPanel.Controls.Add(this.VahtRBtn);
            this.VahtaPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VahtaPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VahtaPanel.Location = new System.Drawing.Point(128, 9);
            this.VahtaPanel.Name = "VahtaPanel";
            this.VahtaPanel.Size = new System.Drawing.Size(243, 34);
            this.VahtaPanel.TabIndex = 0;
            this.VahtaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.VahtaPanel_Paint);
            // 
            // KomandRbtn
            // 
            this.KomandRbtn.AutoSize = true;
            this.KomandRbtn.Location = new System.Drawing.Point(127, 6);
            this.KomandRbtn.Name = "KomandRbtn";
            this.KomandRbtn.Size = new System.Drawing.Size(109, 20);
            this.KomandRbtn.TabIndex = 1;
            this.KomandRbtn.TabStop = true;
            this.KomandRbtn.Text = "Командировка";
            this.KomandRbtn.UseVisualStyleBackColor = true;
            // 
            // VahtRBtn
            // 
            this.VahtRBtn.AutoSize = true;
            this.VahtRBtn.Location = new System.Drawing.Point(23, 6);
            this.VahtRBtn.Name = "VahtRBtn";
            this.VahtRBtn.Size = new System.Drawing.Size(58, 20);
            this.VahtRBtn.TabIndex = 0;
            this.VahtRBtn.TabStop = true;
            this.VahtRBtn.Text = "Вахта";
            this.VahtRBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(8, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Место работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Состав бригады";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(8, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Количество дней";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата начала работ";
            // 
            // WorkersLabel
            // 
            this.WorkersLabel.AutoSize = true;
            this.WorkersLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WorkersLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WorkersLabel.Location = new System.Drawing.Point(6, 18);
            this.WorkersLabel.Name = "WorkersLabel";
            this.WorkersLabel.Size = new System.Drawing.Size(91, 14);
            this.WorkersLabel.TabIndex = 2;
            this.WorkersLabel.Text = "Режим работ";
            // 
            // Objects
            // 
            this.Objects.Controls.Add(this.Obj);
            this.Objects.Controls.Add(this.Repots);
            this.Objects.Location = new System.Drawing.Point(0, 27);
            this.Objects.Name = "Objects";
            this.Objects.SelectedIndex = 0;
            this.Objects.Size = new System.Drawing.Size(1300, 571);
            this.Objects.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Objects.TabIndex = 5;
            // 
            // Docladnie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.CloseBtn;
            this.ClientSize = new System.Drawing.Size(1306, 633);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.Objects);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Docladnie";
            this.Text = "Докладные";
            this.Load += new System.EventHandler(this.Docladnie_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Obj.ResumeLayout(false);
            this.Obj.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.VahtaPanel.ResumeLayout(false);
            this.VahtaPanel.PerformLayout();
            this.Objects.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RedactorsMenu;
        private System.Windows.Forms.ToolStripMenuItem WorkersMenu;
        private System.Windows.Forms.ToolStripMenuItem ObjectsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TabPage Repots;
        private System.Windows.Forms.TabPage Obj;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FirstWorkerCmb;
        private System.Windows.Forms.ComboBox SecondWorkerCmb;
        private System.Windows.Forms.Panel VahtaPanel;
        private System.Windows.Forms.RadioButton KomandRbtn;
        private System.Windows.Forms.RadioButton VahtRBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WorkersLabel;
        private System.Windows.Forms.TabControl Objects;
        private System.Windows.Forms.ComboBox BranchCmb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button connectionDBbtn;
    }
}

