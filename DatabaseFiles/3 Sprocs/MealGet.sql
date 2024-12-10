create or alter procedure dbo.MealGet(
	@MealId int = 0,
	@UsersId int = 0,
	@MealName varchar(100) = '',
	@DateCreated date = '',
	@IsActive bit = 0,
	@All bit = 0)

	as
	begin

	select m.MealId, m.UsersId, m.MealName, m.DateCreated, m.IsActive, UsersName = concat(u.FirstName, ' ', u.LastName),
        MealDesc = isnull(
            concat(
                m.MealName,
                ' has ',
                count(distinct mc.MealCourseId), 
                ' courses and the following ',
				count(distinct mcr.MealCourseRecipeId),
                ' recipes: ',
                string_agg(r.RecipeName, ', ') within group (order by r.RecipeName)
				
            ),
            'No description available'
        ), MealCount =  (select count(distinct m.MealId) from Meal m)  
    from Meal m
      JOIN MealCourse mc on m.MealId = mc.MealId
     JOIN MealCourseRecipe mcr on mcr.MealCourseId = mc.MealCourseId
     JOIN Recipe r on mcr.RecipeId = r.RecipeId
	 join Users u on u.UsersId = m.UsersId
    where (m.MealId = @MealId OR @All = 1)
    group by
        m.MealId, 
        m.UsersId, 
        m.MealName, 
        m.DateCreated, 
        m.IsActive,
		u.FirstName,
		u.LastName
    order by m.MealName;
end
go

	/*Test
	exec MealGet
	exec MealGet @All = 1
	*/









