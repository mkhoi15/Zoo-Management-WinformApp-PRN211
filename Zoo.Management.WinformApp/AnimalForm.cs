using Entities.Helper;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class AnimalForm : Form
	{
		private readonly AnimalRepository _animalRepository;
		private readonly CageRepository _cageRepository;
		public AnimalForm()
		{
			_animalRepository = new AnimalRepository();
			_cageRepository = new CageRepository();
			InitializeComponent();

			ShowListOfAnimal();

			var cage = _cageRepository.GetAll();
			var listCage = new List<Cage>();

			listCage = cage.ToList();

			listCage.Insert(0, new Cage { Id = 0, CageName = "Select Cage" });
			cbCage.DataSource = listCage;
			cbCage.DisplayMember = "CageName";
			cbCage.ValueMember = "Id";

			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

		}

		private async void btnCreate_Click(object sender, EventArgs e)
		{
			btnCreate.Enabled = false;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
			var animalName = txtAnimalName.Text;
			var animalSpecies = txtSpecies.Text;

			var isValidAge = int.TryParse(txtAge.Text, out int age);

			if (!isValidAge || age < 0)
			{
				btnCreate.Enabled = true;
				MessageBox.Show("Invalid Age");
				return;
			}

			if (cbCage.SelectedItem == null)
			{
				MessageBox.Show("Please select the cage for Animal");
				btnCreate.Enabled = true;
				return;
			}

			Cage? cage = cbCage.SelectedItem as Cage;

			if (cage == null)
			{
				MessageBox.Show("The cage can not be null!");
				return;
			}

			Animal animal = new Animal()
			{
				AnimalName = animalName,
				Species = animalSpecies,
				Age = age,

				CageId = cage.Id
			};

			AnimalValidationHelper validator = new();
			var result = validator.Validate(animal);

			if (!result.IsValid)
			{
				var errorsMessage = result.ToString("\n");
				MessageBox.Show(errorsMessage);
				return;
			}

			await _animalRepository.AddAsync(animal);

			this.ShowListOfAnimal();
			btnCreate.Enabled = true;
			this.ClearTextBox();
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			btnUpdate.Enabled = false;
			var id = txtID.Text;
			var animalName = txtAnimalName.Text;
			var animalSpecies = txtSpecies.Text;

			var isValidAge = int.TryParse(txtAge.Text, out int age);

			if (!isValidAge || age < 0)
			{
				btnUpdate.Enabled = true;
				MessageBox.Show("Invalid Age");
				return;
			}

			if (cbCage.SelectedItem == null)
			{
				MessageBox.Show("Please select the cage for Animal");
				btnUpdate.Enabled = true;
				return;
			}

			var cage = cbCage.SelectedItem as Cage;

			Animal animal = new Animal()
			{
				Id = int.Parse(id),
				AnimalName = animalName,
				Species = animalSpecies,
				Age = age,
				CageId = cage.Id
			};

			AnimalValidationHelper validator = new();
			var result = validator.Validate(animal);

			if (!result.IsValid)
			{
				var errorsMessage = result.ToString("\n");
				MessageBox.Show(errorsMessage);
				return;
			}

			await _animalRepository.UpdateAsync(animal);

			this.ShowListOfAnimal();
			btnUpdate.Enabled = true;
			this.ClearTextBox();
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			btnCreate.Enabled = true;
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			var IsValidId = int.TryParse(txtID.Text, out int id);
			if (IsValidId == false)
			{
				MessageBox.Show("ID is not valid");
				btnDelete.Enabled = true;
				return;
			}

			var animal = _animalRepository.GetAll().Where(a => a.Id == id).FirstOrDefault();
			if (animal == null)
			{
				MessageBox.Show("Animal is not exist");
				btnDelete.Enabled = true;
				return;
			}

			var isDeleted = await _animalRepository.DeleteUserAsync(animal);
			if (isDeleted)
			{
				MessageBox.Show("Deleted");
			}
			else
			{
				MessageBox.Show("Delete failed!");
			}

			this.ShowListOfAnimal();

			this.ClearTextBox();

		}

		private void dgvAnimal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnCreate.Enabled = false;
			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;

			var data = dgvAnimal.Rows[e.RowIndex].Cells;

			txtID.Text = data[0].Value.ToString();
			txtAnimalName.Text = data[1].Value.ToString();
			txtSpecies.Text = data[2].Value.ToString();
			txtAge.Text = data[3].Value.ToString();
			cbCage.SelectedItem = data[4].Value.ToString();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			var searchString = txtSearch.Text;
			Search(searchString);
		}

		private void btnCurrentAnimal_Click(object sender, EventArgs e)
		{
			btnDeletedAnimal.Enabled = true;
			btnCurrentAnimal.Enabled = false;

			btnCreate.Enabled = true;

			btnRecovery.Enabled = false;
			btnRecovery.Visible = false;
			ShowListOfAnimal();
		}

		private void btnDeletedAnimal_Click(object sender, EventArgs e)
		{
			btnCurrentAnimal.Enabled = true;
			btnDeletedAnimal.Enabled = false;

			btnDelete.Enabled = false;
			btnCreate.Enabled = false;
			btnUpdate.Enabled = false;

			btnRecovery.Enabled = true;
			btnRecovery.Visible = true;
			ShowListOfDeleteAnimal();
		}

		private async void btnRecovery_Click(object sender, EventArgs e)
		{
			var animal = GetCurrentAnimal();
			var isRecovered = await _animalRepository.RecoveryUserAsync(animal);
			EmptyBoxes();
			if (isRecovered)
			{
				MessageBox.Show("Recovered");
			}
			else
			{
				MessageBox.Show("Recover failed!");
			}
			btnCreate.Enabled = true;
			btnRecovery.Enabled = false;
			btnRecovery.Visible = false;
			btnDeletedAnimal.Enabled = true;
			btnCurrentAnimal.Enabled = false;
			ShowListOfAnimal();
		}

		private void Search(string searchString)
		{
			var listAnimal = _animalRepository.GetAll().AsNoTracking()
								.Where(a => a.AnimalName != null && a.IsDelete == false && a.AnimalName.Contains(searchString))
								.Include(p => p.Cage)
								.Select(a => new
								{
									Name = a.AnimalName,
									Species = a.Species,
									Age = a.Age,
									Cage = a.Cage.CageName
								}).ToList();


			dgvAnimal.DataSource = listAnimal;

		}

		private Animal GetCurrentAnimal()
		{
			var id = txtID.Text;
			var animalName = txtAnimalName.Text;
			var species = txtSpecies.Text;
			var age = txtAge.Text;
			var cage = cbCage.SelectedItem as Cage;

			var currentAnimal = new Animal()
			{
				Id = int.Parse(id),
				AnimalName = animalName,
				Species = species,
				Age = int.Parse(age),
				Cage = cage,
				IsDelete = false
			};
			return currentAnimal;
		}

		private void ShowListOfAnimal()
		{
			var listAnimal = _animalRepository.GetAll().AsNoTracking()
								.Where(a => a.IsDelete == false)
								.Include(p => p.Cage)
								.ToList();

			dgvAnimal.DataSource = listAnimal.Select(a => new
			{
				Id = a.Id,
				Name = a.AnimalName,
				Species = a.Species,
				Age = a.Age,
				Cage = a.Cage?.CageName
			}).ToList();
		}

		private void ShowListOfDeleteAnimal()
		{
			var listAnimal = _animalRepository.GetAll().AsNoTracking()
								.Where(a => a.IsDelete == true)
								.Include(p => p.Cage)
								.ToList();


			dgvAnimal.DataSource = listAnimal.Select(a => new
			{
				Id = a.Id,
				Name = a.AnimalName,
				Species = a.Species,
				Age = a.Age,
				Cage = a.Cage?.CageName
			}).ToList();

		}

		private void ClearTextBox()
		{
			txtID.Text = "";
			txtAnimalName.Text = "";
			txtSpecies.Text = "";
			txtAge.Text = "";
			txtID.Text = "";
			cbCage.SelectedItem = "";
		}


		private void EmptyBoxes()
		{
			txtID.Text = String.Empty;
			txtAnimalName.Text = String.Empty;
			txtSpecies.Text = String.Empty;
			txtAge.Text = String.Empty;
			txtSearch.Text = String.Empty;
			cbCage.Text = String.Empty;
		}
	
	}
}
