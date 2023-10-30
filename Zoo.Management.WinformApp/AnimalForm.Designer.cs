﻿namespace Zoo.Management.WinformApp
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
			txtSearch = new TextBox();
			btnSearch = new Button();
			((System.ComponentModel.ISupportInitialize)dgvAnimal).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(681, 58);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(151, 25);
			label1.TabIndex = 0;
			label1.Text = "Welcome To ZMA";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(45, 161);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(30, 25);
			label2.TabIndex = 1;
			label2.Text = "ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(45, 234);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(119, 25);
			label3.TabIndex = 2;
			label3.Text = "Animal Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(45, 314);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(71, 25);
			label4.TabIndex = 3;
			label4.Text = "Species";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(45, 416);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(44, 25);
			label5.TabIndex = 4;
			label5.Text = "Age";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(45, 521);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(52, 25);
			label6.TabIndex = 5;
			label6.Text = "Cage";
			// 
			// cbCage
			// 
			cbCage.FormattingEnabled = true;
			cbCage.Location = new Point(195, 521);
			cbCage.Margin = new Padding(4);
			cbCage.Name = "cbCage";
			cbCage.Size = new Size(294, 33);
			cbCage.TabIndex = 6;
			// 
			// dgvAnimal
			// 
			dgvAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvAnimal.Location = new Point(534, 132);
			dgvAnimal.Margin = new Padding(4);
			dgvAnimal.Name = "dgvAnimal";
			dgvAnimal.RowHeadersWidth = 51;
			dgvAnimal.RowTemplate.Height = 29;
			dgvAnimal.Size = new Size(1085, 651);
			dgvAnimal.TabIndex = 7;
			dgvAnimal.CellDoubleClick += dgvAnimal_CellDoubleClick;
			// 
			// txtID
			// 
			txtID.Location = new Point(195, 155);
			txtID.Margin = new Padding(4);
			txtID.Name = "txtID";
			txtID.ReadOnly = true;
			txtID.Size = new Size(294, 31);
			txtID.TabIndex = 8;
			// 
			// txtAnimalName
			// 
			txtAnimalName.Location = new Point(195, 234);
			txtAnimalName.Margin = new Padding(4);
			txtAnimalName.Name = "txtAnimalName";
			txtAnimalName.Size = new Size(294, 31);
			txtAnimalName.TabIndex = 9;
			// 
			// txtSpecies
			// 
			txtSpecies.Location = new Point(195, 314);
			txtSpecies.Margin = new Padding(4);
			txtSpecies.Name = "txtSpecies";
			txtSpecies.Size = new Size(294, 31);
			txtSpecies.TabIndex = 10;
			// 
			// txtAge
			// 
			txtAge.Location = new Point(195, 416);
			txtAge.Margin = new Padding(4);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(294, 31);
			txtAge.TabIndex = 11;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(45, 644);
			btnCreate.Margin = new Padding(4);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(118, 36);
			btnCreate.TabIndex = 12;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(230, 644);
			btnUpdate.Margin = new Padding(4);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(118, 36);
			btnUpdate.TabIndex = 13;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(409, 644);
			btnDelete.Margin = new Padding(4);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(118, 36);
			btnDelete.TabIndex = 14;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(1036, 58);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(294, 31);
			txtSearch.TabIndex = 15;
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(1408, 55);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(112, 34);
			btnSearch.TabIndex = 16;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// AnimalForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1906, 871);
			Controls.Add(btnSearch);
			Controls.Add(txtSearch);
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
			Margin = new Padding(4);
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
		private TextBox txtSearch;
		private Button btnSearch;
	}
}