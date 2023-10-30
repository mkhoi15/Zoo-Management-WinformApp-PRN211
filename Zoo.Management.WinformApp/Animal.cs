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
	public partial class Animal : Form
	{

		public List<Animal> Animals = new List<Animal>();
		public AnimalRepository _AnimalRepository;
		public CageRepository _CageRepository;
		public Animal()
		{
			_AnimalRepository = new AnimalRepository();
			_CageRepository = new CageRepository();
			InitializeComponent();

			var listAnimal = _AnimalRepository.GetAll().Include(p => p.Cage).ToList();

			if (listAnimal != null)
			{
				dgvAnimal.DataSource = listAnimal;
			}
		}

		private void ShowListOfAnimals()
		{
			var animal = _AnimalRepository.GetAll().Include(_ => _.Cage).ToList();

			if (animal != null)
			{
				dgvAnimal.DataSource = animal;
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			btnCreate.Enabled = true;
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			var IsValidId = int.TryParse(txtAnimalName.Text, out int id);
			if (IsValidId == false)
			{
				MessageBox.Show("ID is not valid");
				btnDelete.Enabled = true;
				return;
			}

			var animal = _AnimalRepository.GetAll().Where(c => c.Id == id).FirstOrDefault();
			if (animal == null)
			{
				MessageBox.Show("Animal is not exist");
				btnDelete.Enabled = true;
				return;
			}

			_AnimalRepository.DeleteAsync(animal).Wait();

			this.ShowListOfAnimals();

			this.ClearText();
		}
		public void ClearText()
		{
			txtAnimalName.Text = "";
			txtSpecies.Text = "";
			txtAge.Text = "";
			cbCage.Text = "";
		}
	}
}
