namespace Zoo.Management.WinformApp
{
	partial class AnimalForm
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			cbCage = new ComboBox();
			dgvAnimal = new DataGridView();
			txtID = new TextBox();
			txtAnimalName = new TextBox();
			txtSpecies = new TextBox();
			txtAge = new TextBox();
			btnCreate = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
			((System.ComponentModel.ISupportInitialize)dgvAnimal).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(545, 46);
			label1.Name = "label1";
			label1.Size = new Size(127, 20);
			label1.TabIndex = 0;
			label1.Text = "Welcome To ZMA";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(36, 129);
			label2.Name = "label2";
			label2.Size = new Size(24, 20);
			label2.TabIndex = 1;
			label2.Text = "ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(36, 187);
			label3.Name = "label3";
			label3.Size = new Size(100, 20);
			label3.TabIndex = 2;
			label3.Text = "Animal Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(36, 251);
			label4.Name = "label4";
			label4.Size = new Size(59, 20);
			label4.TabIndex = 3;
			label4.Text = "Species";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(36, 333);
			label5.Name = "label5";
			label5.Size = new Size(36, 20);
			label5.TabIndex = 4;
			label5.Text = "Age";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(36, 417);
			label6.Name = "label6";
			label6.Size = new Size(43, 20);
			label6.TabIndex = 5;
			label6.Text = "Cage";
			// 
			// cbCage
			// 
			cbCage.FormattingEnabled = true;
			cbCage.Location = new Point(156, 417);
			cbCage.Name = "cbCage";
			cbCage.Size = new Size(236, 28);
			cbCage.TabIndex = 6;
			// 
			// dgvAnimal
			// 
			dgvAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAnimal.Location = new Point(427, 106);
			dgvAnimal.Name = "dgvAnimal";
			dgvAnimal.RowHeadersWidth = 51;
			dgvAnimal.RowTemplate.Height = 29;
			dgvAnimal.Size = new Size(868, 521);
			dgvAnimal.TabIndex = 7;
			// 
			// txtID
			// 
			txtID.Location = new Point(156, 124);
			txtID.Name = "txtID";
			txtID.ReadOnly = true;
			txtID.Size = new Size(236, 27);
			txtID.TabIndex = 8;
			// 
			// txtAnimalName
			// 
			txtAnimalName.Location = new Point(156, 187);
			txtAnimalName.Name = "txtAnimalName";
			txtAnimalName.Size = new Size(231, 27);
			txtAnimalName.TabIndex = 9;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(156, 251);
			txtSpecies.Name = "txtSpecies";
			txtSpecies.Size = new Size(236, 27);
			txtSpecies.TabIndex = 10;
			// 
			// txtAge
			// 
			txtAge.Location = new Point(156, 333);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(236, 27);
			txtAge.TabIndex = 11;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(36, 515);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(94, 29);
			btnCreate.TabIndex = 12;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(184, 515);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(94, 29);
			btnUpdate.TabIndex = 13;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(327, 515);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(94, 29);
			btnDelete.TabIndex = 14;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// AnimalForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1525, 697);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnCreate);
			Controls.Add(txtAge);
			Controls.Add(txtSpecies);
			Controls.Add(txtAnimalName);
			Controls.Add(txtID);
			Controls.Add(dgvAnimal);
			Controls.Add(cbCage);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AnimalForm";
			Text = "AnimalForm";
			((System.ComponentModel.ISupportInitialize)dgvAnimal).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private ComboBox cbCage;
		private DataGridView dgvAnimal;
		private TextBox txtID;
		private TextBox txtAnimalName;
		private TextBox txtSpecies;
		private TextBox txtAge;
		private Button btnCreate;
		private Button btnUpdate;
		private Button btnDelete;
	}
}