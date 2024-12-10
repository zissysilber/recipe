create or alter procedure dbo.CookbookSearch(
	@CookbookId int = 0,
	@CookbookName varchar(100) = '',
	@Message varchar (100) = '' output
)
as
begin
	declare @return int = 0

	select c.CookbookId, c.CookbookName, r.RecipeName 
	from Cookbook c
	join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId
	join Recipe r
	on r.RecipeId = cr.RecipeId
	where (@CookbookId = 0 or c.CookbookId = @CookbookId)
	and (@CookbookName = '' or c.CookbookName like '%' + @CookbookName + '%')

	return @return
end
go

/*
exec CookbookSearch
exec CookbookSearch @CookbookId = 1
exec CookbookSearch @CookbookName = 'Dairy Delights'
*/