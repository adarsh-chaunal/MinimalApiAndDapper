namespace WebAPI.Endpoints;

public static class Api
{
	public static void MapEndpoints(this WebApplication app)
	{
		app.MapGet("/Users", GetUsersAsync);
		app.MapGet("/Users/{id}", GetUserAsync);
		app.MapPost("/Users", InsertUserAsync);
		app.MapPut("/Users", UpdateUserAsync);
		app.MapDelete("/Users/{id}", DeleteUserAsync);
	}

	private static async Task<IResult> GetUsersAsync(IUserData userData, CancellationToken cancellationToken)
	{
		try
		{
			return Results.Ok(await userData.GetUsersAsync());
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> GetUserAsync(int id, IUserData userData, CancellationToken cancellationToken)
	{
		try
		{
			var result = await userData.GetUserAsync(id);

			if (result == null) return Results.NotFound();

			return Results.Ok(result);
			
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> InsertUserAsync(User user, IUserData userData, CancellationToken cancellationToken)
	{
		try
		{
			await userData.InsertUserAsync(user);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
	
	private static async Task<IResult> UpdateUserAsync(User user, IUserData userData, CancellationToken cancellationToken)
	{
		try
		{
			await userData.UpdateUserAsync(user);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> DeleteUserAsync(int id, IUserData userData, CancellationToken cancellationToken)
	{
		try
		{
			await userData.DeleteUserAsync(id);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
}
