
--Test shows that will not delete
declare @recipeid int

select top 1 @recipeid = r.RecipeId
from recipe r
left join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr on cr.RecipeId = r.RecipeId
where mcr.RecipeId is null
and cr.RecipeId is null and 
(r.RecipeStatus != 'Drafted' 
or DateAdd(day, 30, r.DateArchived) >= GetDate())


select r.RecipeName from Recipe r where r.RecipeId = @recipeId

declare @return int, @message varchar(500)
exec @return =  RecipeDelete @RecipeId = @recipeid, @Message = @message output

select @return, @message

select r.RecipeName from Recipe r where r.RecipeId = @recipeid

go

--Test shows that will delete

declare @recipeid int

select top 1 @RecipeId = r.recipeId
	from recipe r
	left join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId
	left join CookbookRecipe cr on cr.RecipeId = r.RecipeId
	where mcr.RecipeId is null
	and cr.RecipeId is null 
	and ((r.RecipeStatus = 'Drafted') 
	or (r.RecipeStatus = 'Archived' and DateAdd(day, 30, r.DateArchived) <= GetDate()))

select r.RecipeName from Recipe r where r.RecipeId = @recipeid

declare @return int, @message varchar(500)
exec @return =  RecipeDelete @RecipeId = @recipeid, @Message = @message output

select @return, @message

select r.RecipeName from Recipe r where r.RecipeId = @recipeid



--Data that fits criteria
select r.recipeId, r.RecipeName, r.RecipeStatus, r.DateArchived from recipe r
left join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr on cr.RecipeId = r.RecipeId
where mcr.RecipeId is null
and cr.RecipeId is null and 
(r.RecipeStatus = 'Drafted' 
or DateAdd(day, 30, r.DateArchived) <= GetDate())