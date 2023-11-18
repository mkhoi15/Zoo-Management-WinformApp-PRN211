using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class AnimalService
	{
		private readonly AnimalRepository _animalRepository;

		public AnimalService()
		{
			_animalRepository = new AnimalRepository();
		}


        public List<Animal> GetAll()
        {
            //change the include propety folowing your question
            return _animalRepository.GetAll().Include(a => a.Cage)
                                              .ToList();
        }
        public async Task<bool> Add(Animal animal)
        {
            try
            {
                await _animalRepository.AddAsync(animal);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
		public async Task<bool> Delete(int id)
		{
			try
			{
				var animal = _animalRepository.GetAll()
					.FirstOrDefault(a => a.Id == id);

				if (animal == null) return false;

				await _animalRepository.DeleteAsync(animal);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		public async Task<bool> Update(Animal animal)
        {
            var objUpdate = _animalRepository.GetAll()
                .Include(obj => obj.Cage)
                .FirstOrDefault(obj => obj.Id == animal.Id);
            if (objUpdate == null)
            {
                return false;
            }
            //change this
            
            objUpdate.AnimalName = animal.AnimalName;
            objUpdate.Species = animal.Species;
            objUpdate.CageId = animal.CageId;
            objUpdate.Age = animal.Age;
          

            await _animalRepository.UpdateAsync(animal);
            return true;
        }
        public List<Animal> Search(string searchString, bool IsDelete)
        {
            if (IsDelete == true)
            {
                return _animalRepository.GetAll().
								Where(a => a.IsDelete == true
								&& a.AnimalName.Contains(searchString))
								.Include(p => p.Cage)
								.AsNoTracking().ToList();
			}
            else
            {
                return _animalRepository.GetAll().
							 Where(a => a.IsDelete == false
							 && a.AnimalName.Contains(searchString))
							.Include(p => p.Cage)
							.AsNoTracking().ToList();
			}

        }

        public async Task<Animal?> GetAnimalById(int id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);

            if(animal is null)
            {
                return null;
            }

            return animal;
        }
            
        public async Task<bool> Recovery(int id)
        {
            var animal = _animalRepository.GetAll()
                         .FirstOrDefault(a => a.Id == id);

            if (animal is null)
            {
                return false;
            }

            await _animalRepository.RecoveryAsync(animal);

            return true;

        }

    }
}
