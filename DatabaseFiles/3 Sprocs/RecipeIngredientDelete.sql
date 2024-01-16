create or alter proc dbo.RecipeIngredientDelete(
	@RecipeIngredientId int,
	@Message varchar (500) = '' output)

as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	begin try
		begin tran
			delete mr
			from MealCourseRecipe mr
			join RecipeIngredient rd
			on mr.RecipeId = rd.RecipeId
			where rd.RecipeIngredientId = @RecipeIngredientId

			delete rd
			from RecipeIngredient rd
			where rd.RecipeIngredientId = @RecipeIngredientId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	return @return
end
go
