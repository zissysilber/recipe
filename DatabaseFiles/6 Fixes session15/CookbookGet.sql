create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0 output,
	@CookbookSkill varchar(15) = '',
	@CookbookCount int = 0 output ,
	@All bit  = 0,
	@Message varchar (500) = '' output
	)
as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @CookbookId = isnull(@CookbookId, 0)

	select @CookbookSkill = case when c.CookbookSkill = 1 then 'Beginner' when c.CookbookSkill = 2 then 'Intermediate' else 'Advanced' end
	from Cookbook c

	select @CookbookCount = count(distinct c.cookbookId) from Cookbook c

	select c.CookbookId, c.UsersId, UsersName = concat(u.FirstName, ' ', u.LastName), c.CookbookName, c.DateCreated, c.IsActive, c.Price, CookbookSkill = @CookbookSkill, CookbookCount = @CookbookCount
	from Cookbook c
	join Users u
	on c.UsersId = u.UsersId
	where c.CookbookId = @CookbookId
	or @All = 1

	return @return

end
go

/*
exec CookbookGet @All = 1
*/
