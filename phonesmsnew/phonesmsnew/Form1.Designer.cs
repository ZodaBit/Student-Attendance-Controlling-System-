namespace phonesmsnew
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errrol = new System.Windows.Forms.Label();
            this.errpas = new System.Windows.Forms.Label();
            this.errun2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butnexit = new System.Windows.Forms.Button();
            this.usercombobox = new System.Windows.Forms.ComboBox();
            this.textPassWord = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.errrol);
            this.groupBox1.Controls.Add(this.errpas);
            this.groupBox1.Controls.Add(this.errun2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textusername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.butnexit);
            this.groupBox1.Controls.Add(this.usercombobox);
            this.groupBox1.Controls.Add(this.textPassWord);
            this.groupBox1.Controls.Add(this.btnLogIn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(37, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 159);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENTER USER NAME AND PASSWORD";
            // 
            // errrol
            // 
            this.errrol.AutoSize = true;
            this.errrol.Location = new System.Drawing.Point(302, 32);
            this.errrol.Name = "errrol";
            this.errrol.Size = new System.Drawing.Size(0, 13);
            this.errrol.TabIndex = 11;
            // 
            // errpas
            // 
            this.errpas.AutoSize = true;
            this.errpas.Location = new System.Drawing.Point(305, 95);
            this.errpas.Name = "errpas";
            this.errpas.Size = new System.Drawing.Size(0, 13);
            this.errpas.TabIndex = 10;
            // 
            // errun2
            // 
            this.errun2.AutoSize = true;
            this.errun2.Location = new System.Drawing.Point(302, 65);
            this.errun2.Name = "errun2";
            this.errun2.Size = new System.Drawing.Size(0, 13);
            this.errun2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "role";
            // 
            // textusername
            // 
            this.textusername.Location = new System.Drawing.Point(101, 62);
            this.textusername.Name = "textusername";
            this.textusername.Size = new System.Drawing.Size(185, 20);
            this.textusername.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // butnexit
            // 
            this.butnexit.BackColor = System.Drawing.Color.Lime;
            this.butnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butnexit.Location = new System.Drawing.Point(199, 114);
            this.butnexit.Name = "butnexit";
            this.butnexit.Size = new System.Drawing.Size(75, 23);
            this.butnexit.TabIndex = 4;
            this.butnexit.Text = "Exit";
            this.butnexit.UseVisualStyleBackColor = false;
            this.butnexit.Click += new System.EventHandler(this.butnexit_Click);
            // 
            // usercombobox
            // 
            this.usercombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usercombobox.FormattingEnabled = true;
            this.usercombobox.Items.AddRange(new object[] {
            "ADMINISTRATOR",
            "ROOMTEACHER"});
            this.usercombobox.Location = new System.Drawing.Point(101, 32);
            this.usercombobox.Name = "usercombobox";
            this.usercombobox.Size = new System.Drawing.Size(185, 21);
            this.usercombobox.TabIndex = 3;
            // 
            // textPassWord
            // 
            this.textPassWord.Location = new System.Drawing.Point(101, 88);
            this.textPassWord.Name = "textPassWord";
            this.textPassWord.PasswordChar = '*';
            this.textPassWord.Size = new System.Drawing.Size(185, 20);
            this.textPassWord.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Lime;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(101, 114);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 46);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(455, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LOG-IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errrol;
        private System.Windows.Forms.Label errpas;
        private System.Windows.Forms.Label errun2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butnexit;
        private System.Windows.Forms.ComboBox usercombobox;
        private System.Windows.Forms.TextBox textPassWord;
        private System.Windows.Forms.Button btnLogIn;
    }
}

