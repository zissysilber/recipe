declare @recipeid int

select top 1 @recipeid =  r.RecipeId
	from Recipe r
    join Cuisine c
	on r.CuisineId = c.CuisineId
	join Users u
	on u.UsersId = r.UsersId


select * from recipe r where r.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid

select * from Recipe r where r.RecipeId = @recipeid
