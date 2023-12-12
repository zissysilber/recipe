declare @recipeid int

select top 1 @recipeid =  r.RecipeID
	from Recipe r
    join Cuisine c
	on r.CuisineID = c.CuisineID
	join Users u
	on u.UsersID = r.UsersID


select * from recipe r where r.RecipeID = @recipeid

exec RecipeDelete @RecipeID = @recipeid

select * from Recipe r where r.RecipeID = @recipeid