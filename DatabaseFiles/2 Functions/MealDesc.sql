--MealName  has ()courses and () the following () recipes: 

create or alter function dbo.MealDesc(@MealId int)
returns varchar (190)
as
begin
	declare @value varchar(190) = ''
	select @value = 

	concat (
		m.MealName,
		' has ',
		count(distinct mc.MealCourseId),
		' courses and the following ',
		count(distinct mcr.MealCourseRecipeId),
		 ' recipes: ',
		 string_agg(r.RecipeName, ', ') within group (order by r.RecipeName)

	
	)

	from Meal m
	join MealCourse mc on m.MealId = mc.MealId
	join MealCourseRecipe mcr on mcr.MealCourseId = mc.MealCourseId
	join Course c on c.CourseId = mc.CourseId
	join Recipe r on mcr.RecipeId = r.RecipeId
	where m.MealId = @MealId 
    group by m.MealName

	return @value
end
go


/*
select MelaDesc = dbo.MealDesc(m.MealId)
from meal m
where m.MealId = 1
*/