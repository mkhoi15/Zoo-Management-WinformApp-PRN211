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
			txtAnimalName = new TextBox();
			txtSpecies = new TextBox();
			txtAge = new TextBox();
			cbCage = new ComboBox();
			label1 = new Label();
			btnCreate = new Button();
			btnUpdate = new Button();
			btnDelete = new Button();
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
			lbName.Location = new Point(6, 158);
			lbName.Margin = new Padding(4, 0, 4, 0);
			lbName.Name = "lbName";
			lbName.Size = new Size(119, 25);
			lbName.TabIndex = 1;
			lbName.Text = "Animal Name";
			// 
			// lbSpecies
			// 
			lbSpecies.AutoSize = true;
			lbSpecies.Location = new Point(6, 250);
			lbSpecies.Margin = new Padding(4, 0, 4, 0);
			lbSpecies.Name = "lbSpecies";
			lbSpecies.Size = new Size(71, 25);
			lbSpecies.TabIndex = 2;
			lbSpecies.Text = "Species";
			// 
			// lbAge
			// 
			lbAge.AutoSize = true;
			lbAge.Location = new Point(6, 342);
			lbAge.Margin = new Padding(4, 0, 4, 0);
			lbAge.Name = "lbAge";
			lbAge.Size = new Size(44, 25);
			lbAge.TabIndex = 3;
			lbAge.Text = "Age";
			// 
			// lbCage
			// 
			lbCage.AutoSize = true;
			lbCage.Location = new Point(6, 429);
			lbCage.Margin = new Padding(4, 0, 4, 0);
			lbCage.Name = "lbCage";
			lbCage.Size = new Size(52, 25);
			lbCage.TabIndex = 4;
			lbCage.Text = "Cage";
			// 
			// txtAnimalName
			// 
			txtAnimalName.Location = new Point(188, 158);
			txtAnimalName.Margin = new Padding(4);
			txtAnimalName.Name = "txtAnimalName";
			txtAnimalName.Size = new Size(340, 31);
			txtAnimalName.TabIndex = 5;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(188, 246);
			txtSpecies.Margin = new Padding(4);
			txtSpecies.Name = "txtSpecies";
			txtSpecies.Size = new Size(340, 31);
			txtSpecies.TabIndex = 6;
			// 
			// txtAge
			// 
			txtAge.Location = new Point(188, 334);
			txtAge.Margin = new Padding(4);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(155, 31);
			txtAge.TabIndex = 7;
			// 
			// cbCage
			// 
			cbCage.FormattingEnabled = true;
			cbCage.Location = new Point(188, 419);
			cbCage.Margin = new Padding(4);
			cbCage.Name = "cbCage";
			cbCage.Size = new Size(188, 33);
			cbCage.TabIndex = 8;
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
			btnCreate.Location = new Point(15, 562);
			btnCreate.Margin = new Padding(4);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(118, 36);
			btnCreate.TabIndex = 10;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(204, 562);
			btnUpdate.Margin = new Padding(4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(118, 36);
			btnUpdate.TabIndex = 11;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(392, 562);
			btnDelete.Margin = new Padding(4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(118, 36);
			btnDelete.TabIndex = 12;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// Animal
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1538, 841);
			Controls.Add(btnDelete);
			Controls.Add(btnUpdate);
			Controls.Add(btnCreate);
			Controls.Add(label1);
			Controls.Add(cbCage);
			Controls.Add(txtAge);
			Controls.Add(txtSpecies);
			Controls.Add(txtAnimalName);
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
		private TextBox txtAnimalName;
		private TextBox txtSpecies;
		private TextBox txtAge;
		private ComboBox cbCage;
		private Label label1;
		private Button btnCreate;
		private Button btnUpdate;
		private Button btnDelete;
	}
}