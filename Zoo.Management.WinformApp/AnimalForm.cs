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
