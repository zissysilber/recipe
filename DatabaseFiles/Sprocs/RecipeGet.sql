create or alter procedure dbo.RecipeGet(@RecipeID int = 0, @RecipeName varchar(100) = '', @All bit = 0)
as 
begin
--AF Formatting tip - it's nice to indent the code inside the sproc, it makes it clearer and easier to read
select  @RecipeName = nullif(@RecipeName, '')
--AF In a basic get sproc, you should return all columns in the table, include the other columns in the recipe table
select r.RecipeID, r.RecipeName
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