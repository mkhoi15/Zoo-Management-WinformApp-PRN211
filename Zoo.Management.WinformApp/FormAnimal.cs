using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System.Data;



namespace Zoo.Management.WinformApp
{
	public partial class FormAnimal : Form
	{
		private readonly AnimalRepository _animalRepository;
		private readonly CageRepository _cageRepository;
		public FormAnimal()
		{
			_animalRepository = new AnimalRepository();
			_cageRepository = new CageRepository();
			InitializeComponent();

			ShowListOfAnimal();

			var cages = _cageRepository.GetAll();
			if (cages != null)
			{
				var listCage = cages.ToList();
				cbCage.DataSource = listCage;
				cbCage.DisplayMember = "CageName";
				cbCage.ValueMember = "Id";
			}

		}

		private void ShowListOfAnimal()
		{
			var listAnimal = _animalRepository.GetAll().Include(p => p.Cage)
								.Select(a => new
								{
									Id = a.Id,
									Name = a.AnimalName,
									Species = a.Species,
									Age = a.Age,
									Cage = a.Cage.CageName
								}).ToList();

			if (listAnimal != null)
			{
				dgvAnimal.DataSource = listAnimal;
			}
		}

		public void ClearTextBox()
		{
			txtId.Text = string.Empty;
			txtName.Text = string.Empty;
			txtAge.Text = string.Empty;
			cbCage.SelectedItem = "";
			txtSpecies.Text = string.Empty;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			btnCreate.Enabled = false;
			var animalName = txtName.Text;
			var animalAge = txtAge.Text;	
			var animalSpecies = txtSpecies.Text;

			if(cbCage.SelectedItem == null)
			{
				MessageBox.Show("Please select the cage for Animal");
				btnCreate.Enabled = true;
				return;
			}

			var cage = cbCage.SelectedItem as Cage;

			Animal animal = new Animal()
			{
				AnimalName = animalName,
				Species= animalSpecies,
				Age= animalAge,
				Cage = cage
				
			};

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
