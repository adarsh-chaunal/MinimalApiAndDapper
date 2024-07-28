using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
	private readonly IConfiguration _configuration;

	public SqlDataAccess(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure,
													   U parameters,
													   string connectionId = "Default")
	{
		// this 'using' in the below statement is used to create a connection and shut it down when the method is completed or if some interruption occurs while executing this method. 
		using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

		return await connection.QueryAsync<T>(storedProcedure,
										parameters,
										commandType: CommandType.StoredProcedure);
	}

	public async Task SaveDataAsync<T>(string storedProcedure,
									T parameters,
									string connectionId = "Default")
	{
		using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

		await connection.ExecuteAsync(storedProcedure,
								parameters,
								commandType: CommandType.StoredProcedure);
	}
}