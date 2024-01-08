create or alter proc dbo.CuisineDelete(
	@CuisineId int,
	@Message varchar(500) = ' '
	)

as
begin

	declare @return int = 0
	
	select @CuisineId = isnull(@CuisineId, 0)

	
	begin try
		begin tran
			delete CookbookRecipe
			from CookbookRecipe cr
			join Recipe r
			on cr.RecipeId = r.RecipeId
			where r.CuisineId = @CuisineId

			delete MealCourseRecipe
			from MealCourseRecipe mcr
			join Recipe r
			on mcr.RecipeId = r.RecipeId
			where r.CuisineId = @CuisineId

			delete RecipeDirection
			from RecipeDirection rd
			join Recipe r
			on rd.RecipeId = r.RecipeId
			where r.CuisineId = @CuisineId

			delete RecipeIngredient
			from RecipeIngredient ri
			join Recipe r
			on ri.RecipeId = r.RecipeId
			where r.CuisineId = @CuisineId

			delete Recipe 
			from Recipe r
			where r.CuisineId = @CuisineId
			delete Cuisine where CuisineId  = @CuisineId

			delete Cuisine
			from Cuisine
			where CuisineId = @CuisineId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch


	return @return

end


/*

*/
