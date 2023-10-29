using Entities.Models;
using Repositories;

namespace Zoo.Management.WinformApp
{
	public partial class Form1 : Form
	{
		private readonly List<Area> areas = new();
		private readonly AreaRepository areaRepository = new();
		public Form1()
		{
			InitializeComponent();
		}
	}
}