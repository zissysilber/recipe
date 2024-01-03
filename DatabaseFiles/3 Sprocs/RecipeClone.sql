create or alter proc dbo.RecipeClone(
	@RecipeId int  = null output,
	@BasedOnRecipeId int, 
	@Message varchar (500) = ' ' output
)

as
begin
	declare @return int = 0

	

	insert Recipe(UsersId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	select r.UsersId, CuisineId, concat(RecipeName, ' -clone'), Calories, GetDate(), null, null
	from Recipe r
	where r.RecipeId = @BasedOnRecipeId

	Select @RecipeId = SCOPE_IDENTITY() 

	insert RecipeIngredient (RecipeId, IngredientId, MeasurementId, MeasurementAmt, IngredientSequence)
	select @RecipeId, ri.IngredientId, ri.MeasurementId, ri.MeasurementAmt, ri.IngredientSequence
	from RecipeIngredient ri
	where ri.RecipeId = @BasedOnRecipeId

	insert RecipeDirection(RecipeId, DirectionSequence, DirectionDesc)
	select @RecipeId, DirectionSequence, DirectionDesc
	from RecipeDirection rd
	where rd.RecipeId = @BasedOnRecipeId
	
	return @RecipeId

end
go


declare @RecipeId int,
@i int,
@BasedOnRecipeId int,
@m varchar (500)

select top 1 @BasedonRecipeId = r.RecipeId from Recipe r 

exec @i = RecipeClone 
@BasedOnRecipeId = @BasedOnRecipeId,
@RecipeId = @RecipeId output,
@Message = @m output

select @i, @m

select *
from Recipe r

join RecipeIngredient ri
on ri.RecipeId = r.RecipeId
join RecipeDirection rd
on rd.RecipeId = r.RecipeId
where r.RecipeId = @RecipeId


