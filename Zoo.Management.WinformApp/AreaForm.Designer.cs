namespace Zoo.Management.WinformApp
{
    partial class AreaForm
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
            dgvArea = new DataGridView();
            lbArea = new Label();
            lbId = new Label();
            lbName = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArea).BeginInit();
            SuspendLayout();
            // 
            // dgvArea
            // 
            dgvArea.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArea.Location = new Point(358, 50);
            dgvArea.Name = "dgvArea";
            dgvArea.RowTemplate.Height = 25;
            dgvArea.Size = new Size(417, 285);
            dgvArea.TabIndex = 0;
            dgvArea.CellDoubleClick += dgvArea_CellDoubleClick;
            // 
            // lbArea
            // 
            lbArea.AutoSize = true;
            lbArea.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbArea.Location = new Point(105, 9);
            lbArea.Name = "lbArea";
            lbArea.Size = new Size(112, 47);
            lbArea.TabIndex = 1;
            lbArea.Text = "AREA";
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(72, 105);
            lbId.Name = "lbId";
            lbId.Size = new Size(17, 15);
            lbId.TabIndex = 2;
            lbId.Text = "Id";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(50, 149);
            lbName.Name = "lbName";
            lbName.Size = new Size(39, 15);
            lbName.TabIndex = 3;
            lbName.Text = "Name";
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 97);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(117, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 204);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(117, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(225, 206);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // AreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(lbName);
            Controls.Add(lbId);
            Controls.Add(lbArea);
            Controls.Add(dgvArea);
            Name = "AreaForm";
            Text = "AreaForm";
            ((System.ComponentModel.ISupportInitialize)dgvArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvArea;
        private Label lbArea;
        private Label lbId;
        private Label lbName;
        private TextBox txtId;
        private TextBox txtName;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
    }
}