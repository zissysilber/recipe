create or alter proc dbo.CookbookDelete(
	@CookbookId int,
	@Message varchar (500) = '' output)

as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId, 0)

	begin try
		begin tran
			delete mr
			from MealCourseRecipe mr
			join Recipe r
			on r.RecipeId = mr.RecipeId
			join CookbookRecipe cr
			on cr.RecipeId = r.RecipeId
			where cr.CookbookId = @CookbookId

			delete rd
			from RecipeDirection rd
			join Recipe r
			on rd.RecipeId = r.RecipeId
			join CookbookRecipe cr
			on cr.RecipeId = r.RecipeId
			where cr.CookbookId = @CookbookId

			delete ri
			from RecipeIngredient ri 
			join Recipe r
			on ri.RecipeId = r.RecipeId
			join CookbookRecipe cr
			on cr.RecipeId = r.RecipeId
			where cr.CookbookId = @CookbookId
			
			delete cr
			from CookbookRecipe cr		
			left join Recipe r
			on cr.RecipeId = r.RecipeId
			where cr.CookbookId = @CookbookId

			delete c
			from Cookbook c
			where c.CookbookId = @CookbookId
		commit
	end try
	begin catch
		rollback;
		throw

	end catch
	return @return
end
go