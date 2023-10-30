using Microsoft.VisualBasic.ApplicationServices;
using Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Entities.Helper;

namespace Zoo.Management.WinformApp
{
    public partial class UserForm : Form
    {
        private readonly UserRepository _resipotory;
        private readonly ApplicationUser _user;
        private List<ApplicationUser> _applicationUsers = new List<ApplicationUser>();
        public UserForm(ApplicationUser applicationUser)
        {
            _resipotory = new UserRepository();
            _user = applicationUser;

            InitializeComponent();
            this.ShowListUser();
        }

        private ApplicationUser GetCurrentUser()
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var fullName = txtFullName.Text;
            var email = txtEmail.Text;
            var phoneNumber = txtPhoneNumber.Text;
            var id = txtId.Text;

            var gender = cbGender.Text;
            var role = cbRole.Text;
            var dob = dtpDateOfBirth.Value;

            var currentUser = new ApplicationUser()
            {
                Id = int.Parse(id),
                UserName = userName,
                Password = password,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                Gender = gender,
                Role = role,
                Dob = dob,
                IsDeleted = false
            };
            return currentUser;
        }
        private void ShowListUser()
        {
            _applicationUsers = _resipotory.GetAll()
                .Where(u => u.IsDeleted == false)
                .AsNoTracking().ToList();
            dgvUser.DataSource = _applicationUsers.Select(u => new
            {
                Id = u.Id.ToString(),
                userName = u.UserName,
                fullName = u.FullName,
                email = u.Email,
                phoneNumber = u.PhoneNumber,
                gender = u.Gender,
                role = u.Role,
                DateOfBirth = u.Dob,
            }).ToList();
        }
        private void ShowDeletedUser()
        {
            _applicationUsers = _resipotory.GetAll()
                .Where(u => u.IsDeleted == true)
                .AsNoTracking().ToList();
            dgvUser.DataSource = _applicationUsers.Select(u => new
            {
                Id = u.Id.ToString(),
                userName = u.UserName,
                fullName = u.FullName,
                email = u.Email,
                phoneNumber = u.PhoneNumber,
                gender = u.Gender,
                role = u.Role,
                DateOfBirth = u.Dob,
            }).ToList();
        }
        private void Search(string searchString)
        {
            _applicationUsers = _resipotory.GetAll()
                .Where(u => u.IsDeleted == false && u.FullName.Contains(searchString))
                .AsNoTracking().ToList();
            dgvUser.DataSource = _applicationUsers.Select(u => new
            {
                Id = u.Id.ToString(),
                userName = u.UserName,
                fullName = u.FullName,
                email = u.Email,
                phoneNumber = u.PhoneNumber,
                gender = u.Gender,
                role = u.Role,
                DateOfBirth = u.Dob,
            }).ToList();
        }
        private void EmptyBoxes()
        {
            txtId.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPhoneNumber.Text = String.Empty;
            cbGender.Text = String.Empty;
            cbRole.Text = String.Empty;
            dtpDateOfBirth.Value = DateTime.UtcNow;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;
            var fullName = txtFullName.Text;
            var email = txtEmail.Text;
			var isValidPhoneNumber = int.TryParse(txtPhoneNumber.Text, out int phone);
            if (!isValidPhoneNumber)
            {
                MessageBox.Show("Phone number is not valid!!");
                return;
            }
            var phoneNumber = phone.ToString();

            var gender = cbGender.Text;
            var role = cbRole.Text;
            var dob = dtpDateOfBirth.Value;

            var newUser = new ApplicationUser()
            {
                UserName = userName,
                Password = password,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                Gender = gender,
                Role = role,
                Dob = dob,
            };

            ApplicationUserValidationHelper validator = new();
            var result = validator.Validate(newUser);

            if (!result.IsValid)
            {
                var errorsMessage = result.ToString("\n");
                MessageBox.Show(errorsMessage);
                return;
            }

            await _resipotory.AddAsync(newUser);
            ShowListUser();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var user = GetCurrentUser();
            await _resipotory.UpdateAsync(user);
            EmptyBoxes();
            MessageBox.Show("Updated");
            btnCreate.Enabled = true;
            ShowListUser();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var user = GetCurrentUser();
            await _resipotory.DeleteUserAsync(user);
            EmptyBoxes();
            MessageBox.Show("Deleted");
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            ShowListUser();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchString = txtSearch.Text;
            Search(searchString);
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCreate.Enabled = false;

            var data = _applicationUsers[e.RowIndex];

            txtId.Text = data.Id.ToString();
            txtUserName.Text = data.UserName;
            txtPassword.Text = data.Password;
            txtFullName.Text = data.FullName;
            txtEmail.Text = data.Email;
            txtPhoneNumber.Text = data.PhoneNumber;
            cbGender.Text = data.Gender.ToString();
            cbRole.Text = data.Role.ToString();
            dtpDateOfBirth.Text = data.Dob.ToString();
        }

        private void btnDeletedList_Click(object sender, EventArgs e)
        {
            btnCurrentList.Enabled = true;
            btnDeletedList.Enabled = false;

            btnDelete.Enabled = false;
            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;

            btnRecovery.Enabled = true;
            btnRecovery.Visible = true;
            ShowDeletedUser();
        }

        private void btnCurrentList_Click(object sender, EventArgs e)
        {
            btnDeletedList.Enabled = true;
            btnCurrentList.Enabled = false;

            btnCreate.Enabled = true;

            btnRecovery.Enabled = false;
            btnRecovery.Visible = false;
            ShowListUser();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EmptyBoxes();
            btnCreate.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private async void btnRecovery_Click(object sender, EventArgs e)
        {
            var user = GetCurrentUser();
            await _resipotory.RecoveryUserAsync(user);
            EmptyBoxes();
            MessageBox.Show("Deleted");
            btnCreate.Enabled = true;
            btnRecovery.Enabled = false;
            ShowListUser();
        }
    }

}
