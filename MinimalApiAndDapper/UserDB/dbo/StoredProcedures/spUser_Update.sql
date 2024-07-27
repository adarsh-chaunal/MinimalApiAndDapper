CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
    @FirstName varchar(50),
    @LastName varchar(50)
AS
begin
    update dbo.[User]
    set FirstName = @FirstName, LastName = @LastName
    where Id = @Id
end
