using DataAccess.Data;
using DataAccess.DbAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DependencyInjection
{
	public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
		services.AddSingleton<IUserData, UserData>();

		return services;
	}
}
