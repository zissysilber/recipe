create or alter function dbo.MealCalories(@MealID int)
returns varchar (110)
as

begin
	declare @value varchar(110) = ''

	select @value = concat (m.MealName, ' - ', Sum(r.Calories) )
	from MealCourseRecipe mcr
	join MealCourse mc on mc.MealCourseID = mcr.MealCourseID
	join Meal m on m.MealID = mc.MealID
	join Recipe r on r.RecipeID = mcr.RecipeID
	where m.MealID = @MealID
	group by    m.MealName
	
	return @value
end
go


/*
select MealCalories =  dbo.MealCalories(m.MealID)
from Meal m
*/



