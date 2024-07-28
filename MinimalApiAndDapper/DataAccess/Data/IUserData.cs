using DataAccess.Models;

namespace DataAccess.Data;
public interface IUserData
{
	Task DeleteUser(int id);
	Task<User?> GetUserAsync(int id);
	Task<IEnumerable<User>> GetUsersAsync();
	Task InsertUserAsync(User user);
	Task UpdateUserAsync(User user);
}