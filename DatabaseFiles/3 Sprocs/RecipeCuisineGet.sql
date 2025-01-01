create or alter proc dbo.RecipeCuisineGet(
	@RecipeId int = 0,
	@CuisineName varchar(100) = '',
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar (500)  = '')

as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0)

select r.RecipeId, r.RecipeName, c.CuisineId, c.CuisineName
from Recipe r
join Cuisine c
on r.CuisineId = c.CuisineId
where (c.CuisineName like '%' + @CuisineName + '%')

end
go
/*
exec RecipeCuisineGet @CuisineName = '%English%'
exec RecipeCuisineGet @CuisineName = '%American%'
*/

