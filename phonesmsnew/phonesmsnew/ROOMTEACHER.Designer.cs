namespace phonesmsnew
{
    partial class ROOMTEACHER
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradselectroomcomboBox1 = new System.Windows.Forms.ComboBox();
            this.secselectroomcomboBox2 = new System.Windows.Forms.ComboBox();
            this.selectroomgobtn = new System.Windows.Forms.Button();
            this.dgvselectedstudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGEACCOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chanceAccountSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectedstudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "GRADE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "SECTION";
            // 
            // gradselectroomcomboBox1
            // 
            this.gradselectroomcomboBox1.FormattingEnabled = true;
            this.gradselectroomcomboBox1.Items.AddRange(new object[] {
            "GRADE 9",
            "GRADE 10",
            "GRADE 11",
            "GRADE 12"});
            this.gradselectroomcomboBox1.Location = new System.Drawing.Point(81, 33);
            this.gradselectroomcomboBox1.Name = "gradselectroomcomboBox1";
            this.gradselectroomcomboBox1.Size = new System.Drawing.Size(152, 21);
            this.gradselectroomcomboBox1.TabIndex = 3;
            // 
            // secselectroomcomboBox2
            // 
            this.secselectroomcomboBox2.FormattingEnabled = true;
            this.secselectroomcomboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.secselectroomcomboBox2.Location = new System.Drawing.Point(324, 34);
            this.secselectroomcomboBox2.Name = "secselectroomcomboBox2";
            this.secselectroomcomboBox2.Size = new System.Drawing.Size(106, 21);
            this.secselectroomcomboBox2.TabIndex = 4;
            // 
            // selectroomgobtn
            // 
            this.selectroomgobtn.BackColor = System.Drawing.Color.Maroon;
            this.selectroomgobtn.Location = new System.Drawing.Point(460, 32);
            this.selectroomgobtn.Name = "selectroomgobtn";
            this.selectroomgobtn.Size = new System.Drawing.Size(83, 23);
            this.selectroomgobtn.TabIndex = 5;
            this.selectroomgobtn.Text = "GO";
            this.selectroomgobtn.UseVisualStyleBackColor = false;
            this.selectroomgobtn.Click += new System.EventHandler(this.selectroomgobtn_Click);
            // 
            // dgvselectedstudent
            // 
            this.dgvselectedstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselectedstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvselectedstudent.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvselectedstudent.Location = new System.Drawing.Point(15, 19);
            this.dgvselectedstudent.Name = "dgvselectedstudent";
            this.dgvselectedstudent.Size = new System.Drawing.Size(722, 260);
            this.dgvselectedstudent.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ATTENDANCE";
            this.Column1.Name = "Column1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(15, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "TAKE ATTENDANCE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.cHANGEACCOUNTToolStripMenuItem,
            this.rEPORTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fILEToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // cHANGEACCOUNTToolStripMenuItem
            // 
            this.cHANGEACCOUNTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chanceAccountSettingToolStripMenuItem});
            this.cHANGEACCOUNTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cHANGEACCOUNTToolStripMenuItem.Name = "cHANGEACCOUNTToolStripMenuItem";
            this.cHANGEACCOUNTToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.cHANGEACCOUNTToolStripMenuItem.Text = "CHANGE ACCOUNT";
            // 
            // chanceAccountSettingToolStripMenuItem
            // 
            this.chanceAccountSettingToolStripMenuItem.Name = "chanceAccountSettingToolStripMenuItem";
            this.chanceAccountSettingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.chanceAccountSettingToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.chanceAccountSettingToolStripMenuItem.Text = "Chance Account Setting ";
            this.chanceAccountSettingToolStripMenuItem.Click += new System.EventHandler(this.chanceAccountSettingToolStripMenuItem_Click);
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem});
            this.rEPORTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // attdateTimePicker1
            // 
            this.attdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.attdateTimePicker1.Location = new System.Drawing.Point(563, 34);
            this.attdateTimePicker1.Name = "attdateTimePicker1";
            this.attdateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.attdateTimePicker1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(206, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "SAVE ATTENDANCE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvselectedstudent);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 295);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // ROOMTEACHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 420);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.attdateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectroomgobtn);
            this.Controls.Add(this.secselectroomcomboBox2);
            this.Controls.Add(this.gradselectroomcomboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ROOMTEACHER";
            this.Text = "ROOMTEACHER";
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectedstudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gradselectroomcomboBox1;
        private System.Windows.Forms.ComboBox secselectroomcomboBox2;
        private System.Windows.Forms.Button selectroomgobtn;
        private System.Windows.Forms.DataGridView dgvselectedstudent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cHANGEACCOUNTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chanceAccountSettingToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker attdateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}