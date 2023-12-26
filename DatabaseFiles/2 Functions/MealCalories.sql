create or alter function dbo.MealCalories(@MealId int)
returns varchar (110)
as

begin
	declare @value varchar(110) = ''

	select @value = concat (m.MealName, ' - ', Sum(r.Calories) )
	from MealCourseRecipe mcr
	join MealCourse mc on mc.MealCourseId = mcr.MealCourseId
	join Meal m on m.MealId = mc.MealId
	join Recipe r on r.RecipeId = mcr.RecipeId
	where m.MealId = @MealId
	group by    m.MealName
	
	return @value
end
go


/*
select MealCalories =  dbo.MealCalories(m.MealId)
from Meal m
*/



