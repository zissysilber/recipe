create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0, 
	@RecipeName	varchar(100) = '',
	@RecipeIngredientId int = 0,
	@DatePublished date = '' output,
	@IncludeBlank bit = 0,
	@All bit = 0)
as 
begin
	select  @RecipeIngredientId  = isnull(@RecipeIngredientId, 0)

	select r.RecipeId, r.UsersId, r.CuisineId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage
	from Recipe r
	where r.RecipeId = @RecipeId
	or r.RecipeName like '%'+ @RecipeName +'%'
	or @All = 1
	order by r.RecipeName
end 
go


/*Test Scripts

exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeId = 2

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'ea'

declare @RecipeName varchar
select top 1 @RecipeName = r.RecipeName from Recipe r
exec RecipeGet @RecipeName = @RecipeName

*/

