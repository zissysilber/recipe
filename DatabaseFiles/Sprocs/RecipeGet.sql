create or alter procedure dbo.RecipeGet(@RecipeID int = 0, @RecipeName varchar(100) = '', @All bit = 0)
as 
begin
	select  @RecipeName = nullif(@RecipeName, '')



	select r.RecipeID, r.UsersID, r.CuisineID, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage, RecipeInfo = dbo.RecipeInfo(@RecipeID)
	from Recipe r
	where r.RecipeID = @RecipeID
	or r.RecipeName like '%'+ @RecipeName +'%'
	or @All = 1

		 
end 
go


/*Test Scripts

exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeID = 2

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'ea'

declare @RecipeName varchar
select top 1 @RecipeName = r.RecipeName from Recipe r
exec RecipeGet @RecipeName = @RecipeName

*/

