/*
Insert Recipe(UserId, CuisineId, RecipeName, Calories)
select r.UserId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.Calories
from Recipe r
where r.RecipeName = 'Butter Muffins'
*/
create or alter proc dbo.RecipeClone(
	@RecipeId int  = 0 output,
	@Message varchar (500) = ' '
)

as
begin
	declare @return int = 0

	insert Recipe(UsersId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	select r.UsersId, CuisineId, concat(RecipeName, ' -clone'), Calories, GetDate(), null, null
	from Recipe r
	where r.RecipeId = @RecipeId

	Select @RecipeId = SCOPE_IDENTITY() 

	insert RecipeIngredient (RecipeId, IngredientId, MeasurementId, MeasurementAmt, IngredientSequence)
	select @RecipeId, IngredientId, MeasurementId, MeasurementAmt, IngredientSequence
	from RecipeIngredient ri
	where ri.RecipeId = @RecipeId

	insert RecipeDirection(RecipeId, DirectionSequence, DirectionDesc)
	select @RecipeId, DirectionSequence, DirectionDesc
	from RecipeDirection rd
	where rd.RecipeId = @RecipeId
	
	return @return

end
go

exec RecipeClone
@RecipeId = 127
