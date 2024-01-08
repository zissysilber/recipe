create or alter proc dbo.MeasurementDelete(
	@MeasurementId int,
	@Message varchar(500) = ''
	)

as
begin
	declare @return int = 0
	
	select @MeasurementId = isnull(@MeasurementId, 0)

	begin try
		begin tran
			delete CookbookRecipe
			from CookbookRecipe cr
			join Recipe r
			on cr.CookbookId = cr.CookbookId
			join RecipeIngredient ri
			on r.RecipeId = ri.RecipeId
			where ri.MeasurementId = @MeasurementId

			delete MealCourseRecipe
			from MealCourseRecipe mcr
			join Recipe r
			on mcr.RecipeId = r.RecipeId
			join RecipeIngredient ri
			on r.RecipeId = ri.RecipeId
			where ri.MeasurementId = @MeasurementId

			delete RecipeDirection
			from RecipeDirection rd
			join Recipe r
			on rd.RecipeId = r.RecipeId
			join RecipeIngredient ri
			on r.RecipeId = ri.RecipeId
			where ri.MeasurementId = @MeasurementId

			delete RecipeIngredient
			from RecipeIngredient ri
			where ri.MeasurementId = @MeasurementId

			delete Recipe 
			from Recipe r
			where r.CuisineId = @MeasurementId
			delete Cuisine where CuisineId  = @MeasurementId

			delete Measurement
			from Measurement m
			where m.MeasurementId = @MeasurementId
		commit
	end try
	begin catch
		rollback;
		throw

	end catch

	return @return

end
go