
--Test shows that will not delete
declare @recipeid int

select top 1 @recipeid = r.RecipeID
from recipe r
left join MealCourseRecipe mcr on mcr.RecipeID = r.RecipeID
left join CookbookRecipe cr on cr.RecipeID = r.RecipeID
where mcr.RecipeID is null
and cr.RecipeID is null and 
(r.RecipeStatus != 'Drafted' 
or DateAdd(day, 30, r.DateArchived) >= GetDate())


select r.RecipeName from Recipe r where r.RecipeID = @recipeid

declare @return int, @message varchar(500)
exec @return =  RecipeDelete @Recipeid = @recipeid, @Message = @message output

select @return, @message

select r.RecipeName from Recipe r where r.RecipeID = @recipeid

go

--Test shows that will delete

declare @recipeid int

select top 1 @RecipeID = r.recipeid
	from recipe r
	left join MealCourseRecipe mcr on mcr.RecipeID = r.RecipeID
	left join CookbookRecipe cr on cr.RecipeID = r.RecipeID
	where mcr.RecipeID is null
	and cr.RecipeID is null 
	and ((r.RecipeStatus = 'Drafted') 
	or (r.RecipeStatus = 'Archived' and DateAdd(day, 30, r.DateArchived) <= GetDate()))

select r.RecipeName from Recipe r where r.RecipeID = @recipeid

declare @return int, @message varchar(500)
exec @return =  RecipeDelete @Recipeid = @recipeid, @Message = @message output

select @return, @message

select r.RecipeName from Recipe r where r.RecipeID = @recipeid



--Data that fits criteria
select r.recipeid, r.RecipeName, r.RecipeStatus, r.DateArchived from recipe r
left join MealCourseRecipe mcr on mcr.RecipeID = r.RecipeID
left join CookbookRecipe cr on cr.RecipeID = r.RecipeID
where mcr.RecipeID is null
and cr.RecipeID is null and 
(r.RecipeStatus = 'Drafted' 
or DateAdd(day, 30, r.DateArchived) <= GetDate())