using Entities.ApplicationDbCon;
using Entities.Models;

namespace Repositories
{
	public class UserRepository : RepositoryBase<ApplicationUser>
	{
        public async Task<bool> DeleteUserAsync(ApplicationUser user)
		{
			var userDelete = await this.GetByIdAsync(user);
			if (userDelete == null)
			{
				return false;
			}
			user.IsDeleted = true;
			await _context.SaveChangesAsync();

			return true;
		}
        public async Task<bool> RecoveryUserAsync(ApplicationUser user)
        {
            var userDelete = await this.GetByIdAsync(user);
            if (userDelete == null)
            {
                return false;
            }
            user.IsDeleted = false;
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
