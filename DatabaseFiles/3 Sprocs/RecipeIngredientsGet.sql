create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0  output,
	@RecipeId int = 0 ,
	@IngredientId int = 0 ,
	@MeasurementId int = 0 ,
	@MeasurementAmt varchar (10) = '',
	@IngredientSequence int = 0 ,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar (500)  = '')

as 
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @RecipeIngredientId = isnull(@RecipeIngredientId, 0)


	select ri.RecipeIngredientId, ri.RecipeId, i.IngredientId, m.MeasurementId, Amt = ri.MeasurementAmt, Sequence = ri.IngredientSequence   
	
	from RecipeIngredient ri
	join Ingredient i
	on i.IngredientId = ri.IngredientId
	join Measurement m
	on ri.MeasurementId = m.MeasurementId
	where @RecipeId = ri.RecipeId
	and @MeasurementAmt = ri.MeasurementAmt
	and @IngredientSequence = ri.IngredientSequence
	or @All = 1
	return @return

end
go
