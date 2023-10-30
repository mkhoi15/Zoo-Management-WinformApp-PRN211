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
		private readonly List<Animal> animals = new List<Animal>();
		private readonly AnimalRepository _animalRepository;
		private readonly CageRepository _cageRepository;
		public Animal()
		{
			_animalRepository = new AnimalRepository();
			_cageRepository = new CageRepository();
			InitializeComponent();
		}

		private void ShowListOfAnimal()
		{
			var animal = _cageRepository.GetAll().Include(_ => _.CageName).ToList();

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

			var IsValidId = int.TryParse(txtId.Text, out int id);
			if (IsValidId == false)
			{
				MessageBox.Show("ID is not valid");
				btnDelete.Enabled = true;
				return;
			}

			var animal = _animalRepository.GetAll().Where(c => c.Id == id).FirstOrDefault();
			if (animal == null)
			{
				MessageBox.Show("Animal is not exist");
				btnDelete.Enabled = true;
				return;
			}

			_animalRepository.DeleteAsync(animal).Wait();

			this.ShowListOfAnimal();

			this.ClearText();
		}
		public void ClearText()
		{
		}
	}
}
