create or alter proc dbo.RecipeDirectionDelete(
	@RecipeDirectionId int,
	@Message varchar (500) = '' output)

as
begin
	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId, 0)

	begin try
		begin tran
			delete mr
			from MealCourseRecipe mr
			join RecipeDirection rd
			on mr.RecipeId = rd.RecipeId
			where rd.RecipeDirectionId = @RecipeDirectionId

			delete rd
			from RecipeDirection rd
			where rd.RecipeDirectionId = @RecipeDirectionId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
	return @return
end
go
