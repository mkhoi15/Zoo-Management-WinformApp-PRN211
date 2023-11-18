using Entities.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class CageService
	{
		private readonly CageRepository _cageRepository;

		public CageService()
		{
			_cageRepository = new CageRepository();
		}

		public List<Cage> GetAll()
		{
			return _cageRepository.GetAll().ToList();
		}

	}
}
