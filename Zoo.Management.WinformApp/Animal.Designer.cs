namespace Zoo.Management.WinformApp
{
	partial class Animal
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
			dgvAnimal = new DataGridView();
			lbName = new Label();
			lbSpecies = new Label();
			lbAge = new Label();
			lbCage = new Label();
			txtName = new TextBox();
			txtSpecies = new TextBox();
			txtAge = new TextBox();
			label1 = new Label();
			btnCreate = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			lbId = new Label();
			txtId = new TextBox();
			cbCage = new ComboBox();
			((System.ComponentModel.ISupportInitialize)dgvAnimal).BeginInit();
			SuspendLayout();
			// 
			// dgvAnimal
			// 
			dgvAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAnimal.Location = new Point(445, 126);
			dgvAnimal.Name = "dgvAnimal";
			dgvAnimal.RowHeadersWidth = 51;
			dgvAnimal.RowTemplate.Height = 29;
			dgvAnimal.Size = new Size(773, 458);
			dgvAnimal.TabIndex = 0;
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(6, 187);
			lbName.Name = "lbName";
			lbName.Size = new Size(100, 20);
			lbName.TabIndex = 1;
			lbName.Text = "Animal Name";
			// 
			// lbSpecies
			// 
			lbSpecies.AutoSize = true;
			lbSpecies.Location = new Point(6, 261);
			lbSpecies.Name = "lbSpecies";
			lbSpecies.Size = new Size(59, 20);
			lbSpecies.TabIndex = 2;
			lbSpecies.Text = "Species";
			// 
			// lbAge
			// 
			lbAge.AutoSize = true;
			lbAge.Location = new Point(6, 335);
			lbAge.Name = "lbAge";
			lbAge.Size = new Size(36, 20);
			lbAge.TabIndex = 3;
			lbAge.Text = "Age";
			// 
			// lbCage
			// 
			lbCage.AutoSize = true;
			lbCage.Location = new Point(6, 404);
			lbCage.Name = "lbCage";
			lbCage.Size = new Size(43, 20);
			lbCage.TabIndex = 4;
			lbCage.Text = "Cage";
			// 
			// txtName
			// 
			txtName.Location = new Point(151, 187);
			txtName.Name = "txtName";
			txtName.Size = new Size(273, 27);
			txtName.TabIndex = 5;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(151, 258);
			txtSpecies.Name = "txtSpecies";
			txtSpecies.Size = new Size(273, 27);
			txtSpecies.TabIndex = 6;
			// 
			// txtAge
			// 
			txtAge.Location = new Point(151, 328);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(273, 27);
			txtAge.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.InactiveCaption;
			label1.Location = new Point(496, 22);
			label1.Name = "label1";
			label1.Size = new Size(125, 20);
			label1.TabIndex = 9;
			label1.Text = "Welcome to ZMA";
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(13, 511);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(94, 29);
			btnCreate.TabIndex = 10;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(164, 511);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(94, 29);
			btnUpdate.TabIndex = 11;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(315, 511);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(94, 29);
			btnDelete.TabIndex = 12;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// lbId
			// 
			lbId.AutoSize = true;
			lbId.Location = new Point(6, 117);
			lbId.Name = "lbId";
			lbId.Size = new Size(24, 20);
			lbId.TabIndex = 13;
			lbId.Text = "ID";
			// 
			// txtId
			// 
			txtId.Location = new Point(151, 110);
			txtId.Name = "txtId";
			txtId.Size = new Size(273, 27);
			txtId.TabIndex = 14;
			// 
			// cbCage
			// 
			cbCage.FormattingEnabled = true;
			cbCage.Location = new Point(151, 396);
			cbCage.Name = "cbCage";
			cbCage.Size = new Size(273, 28);
			cbCage.TabIndex = 8;
			// 
			// Animal
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1230, 673);
			Controls.Add(txtId);
			Controls.Add(lbId);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnCreate);
			Controls.Add(label1);
			Controls.Add(cbCage);
			Controls.Add(txtAge);
			Controls.Add(txtSpecies);
			Controls.Add(txtName);
			Controls.Add(lbCage);
			Controls.Add(lbAge);
			Controls.Add(lbSpecies);
			Controls.Add(lbName);
			Controls.Add(dgvAnimal);
			Name = "Animal";
			Text = "Animal";
			((System.ComponentModel.ISupportInitialize)dgvAnimal).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvAnimal;
		private Label lbName;
		private Label lbSpecies;
		private Label lbAge;
		private Label lbCage;
		private TextBox txtName;
		private TextBox txtSpecies;
		private TextBox txtAge;
		private Label label1;
		private Button btnCreate;
		private Button btnUpdate;
		private Button btnDelete;
		private Label lbId;
		private TextBox txtId;
		private ComboBox cbCage;
	}
}