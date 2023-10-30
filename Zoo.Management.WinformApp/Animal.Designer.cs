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
			dgvAnimal.Location = new Point(556, 158);
			dgvAnimal.Margin = new Padding(4);
			dgvAnimal.Name = "dgvAnimal";
			dgvAnimal.RowHeadersWidth = 51;
			dgvAnimal.RowTemplate.Height = 29;
			dgvAnimal.Size = new Size(966, 572);
			dgvAnimal.TabIndex = 0;
			// 
			// lbName
			// 
			lbName.AutoSize = true;
			lbName.Location = new Point(5, 126);
			lbName.Name = "lbName";
			lbName.Size = new Size(119, 25);
			lbName.TabIndex = 1;
			lbName.Text = "Animal Name";
			// 
			// lbSpecies
			// 
			lbSpecies.AutoSize = true;
			lbSpecies.Location = new Point(5, 200);
			lbSpecies.Name = "lbSpecies";
			lbSpecies.Size = new Size(71, 25);
			lbSpecies.TabIndex = 2;
			lbSpecies.Text = "Species";
			// 
			// lbAge
			// 
			lbAge.AutoSize = true;
			lbAge.Location = new Point(5, 274);
			lbAge.Name = "lbAge";
			lbAge.Size = new Size(44, 25);
			lbAge.TabIndex = 3;
			lbAge.Text = "Age";
			// 
			// lbCage
			// 
			lbCage.AutoSize = true;
			lbCage.Location = new Point(5, 343);
			lbCage.Name = "lbCage";
			lbCage.Size = new Size(52, 25);
			lbCage.TabIndex = 4;
			lbCage.Text = "Cage";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(150, 126);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(273, 27);
			textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(150, 197);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(273, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(150, 267);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 27);
			textBox3.TabIndex = 7;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(150, 335);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 28);
			comboBox1.TabIndex = 8;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = SystemColors.InactiveCaption;
			label1.Location = new Point(620, 28);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(150, 25);
			label1.TabIndex = 9;
			label1.Text = "Welcome to ZMA";
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(12, 450);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(118, 36);
			btnCreate.TabIndex = 10;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(163, 450);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(118, 36);
			btnUpdate.TabIndex = 11;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(314, 450);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(118, 36);
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
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1230, 673);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnCreate);
			Controls.Add(label1);
			Controls.Add(comboBox1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(lbCage);
			Controls.Add(lbAge);
			Controls.Add(lbSpecies);
			Controls.Add(lbName);
			Controls.Add(dgvAnimal);
			Margin = new Padding(4);
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
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private ComboBox comboBox1;
		private Label label1;
		private Button btnCreate;
		private Button btnUpdate;
		private Button btnDelete;
		private Label lbId;
		private TextBox txtId;
		private ComboBox cbCage;
	}
}