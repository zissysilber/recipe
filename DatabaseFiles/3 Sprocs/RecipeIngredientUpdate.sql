create or alter procedure dbo.RecipeIngredientUpdate (
	@RecipeIngredientId int = 0 output,
	@RecipeId int = 0,
	@IngredientId int = 0,
	@MeasurementId int = 0,
	@MeasurementAmt varchar (10) = '',
	@IngredientSequence int = 0,
	@Message varchar(500) = '' output
)

as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0), @RecipeId = isnull(@RecipeId, 0), @MeasurementId = isnull(@MeasurementId, 0), @IngredientSequence = isnull(@IngredientSequence, 0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmt, IngredientSequence)
		values (@RecipeId, @IngredientId, @MeasurementId, @MeasurementAmt, @IngredientSequence)

		select @RecipeIngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId = @RecipeId, 
			IngredientId = @IngredientId, 
			MeasurementId = @MeasurementId, 
			MeasurementAmt = @MeasurementAmt, 
			IngredientSequence = @IngredientSequence
			where RecipeIngredientId = @RecipeIngredientId
		end

		return @return
end
go
	