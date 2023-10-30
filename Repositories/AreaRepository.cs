using Entities.Models;

namespace Repositories
{
    public class AreaRepository : RepositoryBase<Area>
    {
		public async Task<bool> DeleteUserAsync(Area area)
		{
			var areaDelete = await this.GetByIdAsync(area);
			if (areaDelete == null)
			{
				return false;
			}
			areaDelete.IsDeleted = true;
			await _context.SaveChangesAsync();

			return true;
		}
	}
}