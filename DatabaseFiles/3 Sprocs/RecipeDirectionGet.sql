create or alter proc dbo.RecipeDirectionGet(
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar (500)  = '')

as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0)

	select rd.RecipeDirectionId, rd.RecipeId, rd.DirectionDesc, rd.DirectionSequence 
	from RecipeDirection rd
	where rd.RecipeId = @RecipeId

end
go
/*
exec RecipeDirectionGet @RecipeId = 2
*/

select * from Recipe r where r.RecipeName like '%Apple Yogurt Smoothie%'