create or alter procedure dbo.CookbookSummaryGet(
	@Message varchar (500) = '' output
)

as
begin
	Select c.CookbookId, c.CookbookName, Author = u.UsersName, [Num Recipes] = count(cr.CookbookId), c.Price
	from Cookbook c
	join Users u
	on u.UsersId = c.UsersId
	left join CookbookRecipe cr
	on cr.CookbookId = c.CookbookId
	group by c.CookbookId, c.CookbookName, u.UsersName, c.Price
	order by c.CookbookName

end
go


