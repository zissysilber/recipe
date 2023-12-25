create or alter proc dbo.SummaryDatabaseGet(
	@Message varchar (500) = '' output)

as
begin
	select Type = 'Recipe', Number = count(distinct r.RecipeID) 
	from Recipe r
	union select  'Meals',  count(distinct m.MealID)
	from Meal m
	union select 'Cookbooks',  count(distinct c.CookbookID)
	from Cookbook c

end
go

exec SummaryDatabaseGet



