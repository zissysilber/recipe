create or alter proc dbo.SummaryDatabaseGet(
	@Message varchar (500) = '' output)

as
begin
	select Type = 'Recipe', Number = count(distinct r.RecipeId) 
	from Recipe r
	union select  'Meals',  count(distinct m.MealId)
	from Meal m
	union select 'Cookbooks',  count(distinct c.CookbookId)
	from Cookbook c

end
go

exec SummaryDatabaseGet



