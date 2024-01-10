create or alter proc dbo.UsersDelete (
	@UsersId int,
	@MessageId varchar(500) = '')

as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId, 0)

	begin try
		begin tran
			delete mr
			from MealCourseRecipe mr
			left join MealCourse mc
			on mr.MealCourseId = mc.MealCourseId
			left join meal m
			on mc.MealId = m.MealId
			where m.UsersId = @UsersId

			delete mr
			from MealCourseRecipe mr
			left join Recipe r
			on mr.RecipeId = r.RecipeId
			where r.UsersId = @UsersId

			delete mc
			from MealCourse mc
			join Meal m
			on mc.MealId = m.MealId
			join Course c
			on mc.CourseId = c.CourseId
			where m.UsersId = @UsersId

			delete m
			from Meal m
			where m.UsersId = @UsersId

			delete rd
			from RecipeDirection rd
			join RecipeIngredient ri
			on rd.RecipeId = ri.RecipeId
			join Recipe r
			on rd.RecipeId = r.RecipeId
			where r.UsersId = @UsersId

			delete ri
			from RecipeIngredient ri 
			join Recipe r
			on ri.RecipeId = r.RecipeId
			where r.UsersId = @UsersId
			
			delete cr
			from CookbookRecipe cr		
			left join Recipe r
			on cr.RecipeId = r.RecipeId
			where r.UsersId = @UsersId

			delete cr
			from CookbookRecipe cr 			
			left join Cookbook c
			on c.CookbookId = cr.CookbookId
			where c.UsersId = @UsersId

			delete r
			from Recipe r
			join Users u
			on u.UsersId = r.UsersId
			where r.UsersId = @UsersId

			delete c
			from Cookbook c
			where c.UsersId = @UsersId

			delete u
			from Users u
			where u.UsersId = @UsersId
		commit
	end try
	begin catch
		rollback;
		throw

	end catch
	return @return

end
go


