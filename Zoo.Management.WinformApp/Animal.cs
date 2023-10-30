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

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}
	}
}
