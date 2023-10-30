using Entities.Models;

namespace Repositories
{
    public class AnimalRepository : RepositoryBase<Animal>
    {
		public async Task<bool> DeleteUserAsync(Animal animal)
		{
			var animalDelete = await this.GetByIdAsync(animal);
			if (animalDelete == null)
			{
				return false;
			}
			animalDelete.IsDelete = true;
			await _context.SaveChangesAsync();

			return true;
		}
	}
}