create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0, 
	@RecipeName	varchar(100) = '',
	@RecipeIngredientId int = 0,
	@DatePublished date = '' output,
	@RecipeCount int = 0 output,
	@IncludeBlank bit = 0,
	@Vegan varchar(3) = '',
	@All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName, ''), @RecipeIngredientId  = isnull(@RecipeIngredientId, 0)

	select @RecipeCount = count(distinct r.RecipeId)
	from Recipe r

	select @Vegan = case when r.Vegan = 0 then 'No' else 'Yes' end
	from recipe r

	select  r.RecipeId, r.UsersId, UserName = concat(u.FirstName, ' ', u.LastName), r.CuisineId, r.RecipeName, r.Calories, 
			r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage, 
			NumIngredients = count(distinct ri.IngredientSequence),
			Vegan = @Vegan, RecipeCount = @RecipeCount
	from Recipe r
	join Users u on u.UsersId = r.UsersId
	left join RecipeIngredient ri on r.RecipeId = ri.RecipeId
	where (r.RecipeId = @RecipeId)
	or (r.RecipeName like '%'+ @RecipeName +'%')
	or @All = 1
	group by r.RecipeId, r.UsersId, u.FirstName, u.LastName, r.CuisineId, r.RecipeName, 
    r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage 
	order by r.RecipeName
end 
go


/*Test Scripts

exec RecipeGet

select * from Recipe
exec RecipeGet @All = 1

exec RecipeGet @RecipeId = 129

exec RecipeGet @RecipeName = ''

exec RecipeGet @RecipeName = 'ee'

declare @RecipeName varchar
select top 1 @RecipeName = r.RecipeName from Recipe r
exec RecipeGet @RecipeName = @RecipeName

*/



