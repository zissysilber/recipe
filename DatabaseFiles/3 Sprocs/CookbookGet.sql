create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0 output,
	@All bit  = 0,
	@Message varchar (500) = '' output
	)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @CookbookId = isnull(@CookbookId, 0)

	select c.CookbookId, c.UsersId, c.CookbookName, c.DateCreated, c.IsActive, c.Price
	from Cookbook c
	where c.CookbookId = @CookbookId
	or @All = 1

	return @return

end
go

exec CookbookGet @All = 1

select * from cookbook