namespace Zoo.Management.WinformApp
{
    partial class UserForm
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
            dgvUser = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnCreate = new Button();
            dtpDateOfBirth = new DateTimePicker();
            cbRole = new ComboBox();
            cbGender = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            lbName = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            staffToolStripMenuItem = new ToolStripMenuItem();
            areasCagesToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem1 = new ToolStripMenuItem();
            zooTrainerToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            animalStatusToolStripMenuItem = new ToolStripMenuItem();
            btnRecovery = new Button();
            label9 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(574, 42);
            dgvUser.Name = "dgvUser";
            dgvUser.RowTemplate.Height = 33;
            dgvUser.Size = new Size(953, 400);
            dgvUser.TabIndex = 27;
            dgvUser.CellDoubleClick += dgvUser_CellDoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(247, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 41);
            btnUpdate.TabIndex = 26;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(417, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 41);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(79, 401);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(108, 41);
            btnCreate.TabIndex = 24;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(218, 301);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(307, 31);
            dtpDateOfBirth.TabIndex = 23;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Staff", "ZooTrainer" });
            cbRole.Location = new Point(218, 338);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 33);
            cbRole.TabIndex = 22;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cbGender.Location = new Point(218, 227);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 33);
            cbGender.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 338);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 14;
            label8.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 301);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 12;
            label7.Text = "Date of Birth";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(218, 264);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(307, 31);
            txtPhoneNumber.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 264);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 6;
            label6.Text = "phoneNumber";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 227);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 11;
            label5.Text = "Gender";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(307, 31);
            txtEmail.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 190);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(218, 153);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(307, 31);
            txtFullName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 153);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 9;
            label2.Text = "fullName";
            // 
            // txtId
            // 
            txtId.Location = new Point(218, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(307, 31);
            txtId.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 42);
            label3.Name = "label3";
            label3.Size = new Size(30, 25);
            label3.TabIndex = 8;
            label3.Text = "ID";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(218, 79);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(307, 31);
            txtUserName.TabIndex = 20;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(79, 79);
            lbName.Name = "lbName";
            lbName.Size = new Size(92, 25);
            lbName.TabIndex = 7;
            lbName.Text = "userName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 116);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 31);
            txtPassword.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 116);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 13;
            label1.Text = "password";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { staffToolStripMenuItem, zooTrainerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1607, 33);
            menuStrip1.TabIndex = 28;
            menuStrip1.Text = "menuStrip1";
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { areasCagesToolStripMenuItem, animalToolStripMenuItem1 });
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(60, 29);
            staffToolStripMenuItem.Text = "Staff";
            // 
            // areasCagesToolStripMenuItem
            // 
            areasCagesToolStripMenuItem.Name = "areasCagesToolStripMenuItem";
            areasCagesToolStripMenuItem.Size = new Size(183, 30);
            areasCagesToolStripMenuItem.Text = "Areas/Cages";
            // 
            // animalToolStripMenuItem1
            // 
            animalToolStripMenuItem1.Name = "animalToolStripMenuItem1";
            animalToolStripMenuItem1.Size = new Size(183, 30);
            animalToolStripMenuItem1.Text = "Animal";
            // 
            // zooTrainerToolStripMenuItem
            // 
            zooTrainerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { animalToolStripMenuItem, animalStatusToolStripMenuItem });
            zooTrainerToolStripMenuItem.Name = "zooTrainerToolStripMenuItem";
            zooTrainerToolStripMenuItem.Size = new Size(112, 29);
            zooTrainerToolStripMenuItem.Text = "Zoo Trainer";
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(192, 30);
            animalToolStripMenuItem.Text = "Animal";
            // 
            // animalStatusToolStripMenuItem
            // 
            animalStatusToolStripMenuItem.Name = "animalStatusToolStripMenuItem";
            animalStatusToolStripMenuItem.Size = new Size(192, 30);
            animalStatusToolStripMenuItem.Text = "Animal Status";
            // 
            // btnRecovery
            // 
            btnRecovery.Enabled = false;
            btnRecovery.Location = new Point(417, 495);
            btnRecovery.Name = "btnRecovery";
            btnRecovery.Size = new Size(108, 41);
            btnRecovery.TabIndex = 25;
            btnRecovery.Text = "Recovery";
            btnRecovery.UseVisualStyleBackColor = true;
            btnRecovery.Visible = false;
            btnRecovery.Click += btnDelete_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(797, 465);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 29;
            label9.Text = "Search: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(896, 462);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(386, 31);
            txtSearch.TabIndex = 30;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1297, 457);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 41);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 643);
            Controls.Add(txtSearch);
            Controls.Add(label9);
            Controls.Add(dgvUser);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnRecovery);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cbRole);
            Controls.Add(cbGender);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(lbName);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnCreate;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbRole;
        private ComboBox cbGender;
        private Label label8;
        private Label label7;
        private TextBox txtPhoneNumber;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtId;
        private Label label3;
        private TextBox txtUserName;
        private Label lbName;
        private TextBox txtPassword;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem areasCagesToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem1;
        private ToolStripMenuItem zooTrainerToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem animalStatusToolStripMenuItem;
        private Button btnRecovery;
        private Label label9;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}