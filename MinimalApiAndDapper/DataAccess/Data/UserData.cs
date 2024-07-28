using DataAccess.DbAccess;
using DataAccess.Models;

namespace DataAccess.Data;
public class UserData : IUserData
{
	private readonly ISqlDataAccess _db;

	public UserData(ISqlDataAccess db)
	{
		_db = db;
	}

	public async Task<IEnumerable<User>> GetUsersAsync() =>
		await _db.LoadDataAsync<User, dynamic>("dbo.spUser_GetAll",
										 new { });

	public async Task<User?> GetUserAsync(int id)
	{
		var user = await _db.LoadDataAsync<User, dynamic>("dbo.spUser_Get",
													new { Id = id });

		return user.FirstOrDefault();
	}

	public async Task InsertUserAsync(User user) => await _db.SaveDataAsync<dynamic>("dbo.spUser_Insert",
																				  new { user.FirstName, user.LastName });

	public async Task UpdateUserAsync(User user) => await _db.SaveDataAsync<User>("dbo.spUser_Update",
																			   user);

	public async Task DeleteUserAsync(int id) => await _db.SaveDataAsync<dynamic>("dbo.spUser_Delete",
																		  new { Id = id });
}