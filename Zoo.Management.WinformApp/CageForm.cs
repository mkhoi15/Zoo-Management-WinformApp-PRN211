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

            var areaList = areaRepository.GetAll().Where(a => !a.IsDeleted).ToList();
            if (areaList is not null && areaList.Count > 0)
            {
                cbArea.DataSource = areaList;
                cbArea.DisplayMember = "Name";
                cbArea.ValueMember = "Id";
            }
        }

        private void dgvListCage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;

            var row = dgvListCage.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            cbArea.Text = row.Cells[2].Value.ToString();
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                btnUpdate.Enabled = false;

                var id = CheckValidId();
                if (id <= 0) return;

                var cage = cageRepository.GetAll().Where(c => c.Id == id && !c.IsDeleted).FirstOrDefault();
                if (cage is null)
                {
                    MessageBox.Show("Cage is not found. Can not update!");
                    btnUpdate.Enabled = true;
                    return;
                }

                var area = cbArea.SelectedItem as Area;
                if (area is null)
                {
                    MessageBox.Show("Please choose area!", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnUpdate.Enabled = true;
                    return;
                };

                cage.CageName = txtName.Text;
                cage.AreaId = area.Id;

                if (!CheckValidation(cage))
                {
                    btnUpdate.Enabled = true;
                    return;
                }
                await cageRepository.UpdateAsync(cage);

                GetDataForDataGridView();

                ClearText();
                btnCreate.Enabled = true;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnUpdate.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                btnDelete.Enabled = false;

                var id = CheckValidId();
                if (id <= 0) return;

                var deleteCage = new Cage();

                var cageName = txtName.Text;
                var area = cbArea.SelectedItem as Area;

                if (cageName == "" && area is null)
                {
                    deleteCage = cageRepository.GetAll().Where(c => c.Id == id).FirstOrDefault();
                }
                else
                {
                    if (area is null)
                    {
                        MessageBox.Show("Please choose area");
                        btnDelete.Enabled = true;
                        return;
                    }
                    deleteCage = cageRepository.GetAll().Where(c => c.Id == id
                                                                && c.CageName == cageName
                                                                && c.AreaId == area.Id).FirstOrDefault();
                }

                if (deleteCage is null)
                {
                    MessageBox.Show("Cage is not found. Can not delete!");
                    btnDelete.Enabled = true;
                    return;
                }
                if (deleteCage.IsDeleted)
                {
                    MessageBox.Show("Cage is deleted. Can not delete again!");
                    btnDelete.Enabled = true;
                    return;
                }

                deleteCage.IsDeleted = true;

                await cageRepository.UpdateAsync(deleteCage);

                GetDataForDataGridView();

                ClearText();
                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                btnDelete.Enabled = true; 
            }
        }

        private void ClearText()
        {
            txtId.Text = "";
            txtName.Text = "";
        }

        private void GetDataForDataGridView()
        {
            var cageList = cageRepository.GetAll().Where(c => !c.IsDeleted).Include(c => c.Area).ToList();
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
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Id must be integer");
                return -1;
            }
            if (txtId.Text == "0")
            {
                MessageBox.Show("Id must be positive");
                return 0;
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
