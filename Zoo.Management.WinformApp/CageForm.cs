using Entities.Helper;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoo.Management.WinformApp
{
    public partial class CageForm : Form
    {
        private CageRepository cageRepository;
        private AreaRepository areaRepository;

        public CageForm()
        {
            InitializeComponent();
            cageRepository = new CageRepository();
            areaRepository = new AreaRepository();

            GetDataForDataGridView();

            var areaList = areaRepository.GetAll().ToList();
            if (areaList is not null && areaList.Count > 0)
            {
                cbArea.DataSource = areaList;
                cbArea.DisplayMember = "Name";
                cbArea.ValueMember = "Id";
            }
        }

        private void dgvListCage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            try
            {
                var cageName = txtName.Text;
                var area = cbArea.SelectedItem as Area;

                if (area is null)
                {
                    MessageBox.Show("Please choose area!", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                };

                var newCage = new Cage()
                {
                    CageName = cageName,
                    AreaId = area.Id,
                };

                if (!CheckValidation(newCage)) return;

                await cageRepository.AddAsync(newCage);
                GetDataForDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearText();
                btnCreate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ClearText()
        {
            txtId.Text = "";
            txtName.Text = "";
        }

        private void GetDataForDataGridView()
        {
            var cageList = cageRepository.GetAll().Include(c => c.Area).ToList();
            if (cageList.Count > 0 && cageList is not null)
            {
                dgvListCage.DataSource = cageList.Select(c => new
                {
                    id = c.Id,
                    Name = c.CageName,
                    Area = c.Area?.Name,
                }).ToList();
            }
        }

        private int CheckValidId()
        {
            // Check if the price is decimal
            int id = -1;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Price must be integer");
                return id;
            }
            return id;
        }

        private bool CheckValidation(Cage cage)
        {
            CageValidationHelper validator = new();
            var result = validator.Validate(cage);

            if (!result.IsValid)
            {
                var errorsMessage = result.ToString("\n");
                MessageBox.Show(errorsMessage);
                return false;
            }
            return true;
        }
    }
}
