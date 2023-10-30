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
		private readonly AnimalRepository _animalRepository;
		private readonly CageRepository _cageRepository;
		public Animal()
		{
			InitializeComponent();
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
