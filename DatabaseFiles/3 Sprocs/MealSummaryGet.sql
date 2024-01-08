create or alter proc dbo.MealSummaryGet(
	@Message varchar (500) = ''
	)
as
begin
	select [Meal Name] = m.MealName, [User] = concat(u.Firstname, ' ', u.LastName ), [Num Calories] = sum(r.Calories), [Num Courses] = count(distinct mc.MealCourseId), [Num Recipes] = count(mr.RecipeId)
	from Meal m
	join Users u
	on m.UsersId = u.UsersId
	join MealCourse mc
	on m.MealId = mc.MealId
	join MealCourseRecipe mr
	on mc.MealCourseId = mr.MealCourseId
	join Recipe r
	on mr.RecipeId = r.RecipeId
	group by m.MealName, u.FirstName, u.LastName
	order by m.MealName
end
go


