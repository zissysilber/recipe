create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0  output,
	@RecipeId int = 0 ,
	@IngredientId int = 0 ,
	@MeasurementId int = 0 ,
	@MeasurementAmt varchar (10) = '' output,
	@IngredientSequence int = 0 output,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar (500)  = '' output
)

as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0)


	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, ri.MeasurementId, 
	ri.MeasurementAmt,   ri.IngredientSequence   
	from RecipeIngredient ri
	where @RecipeId = ri.RecipeId
	or @All = 1
	return @return

end
go


exec RecipeIngredientGet @RecipeId = 122