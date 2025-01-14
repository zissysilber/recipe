create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0, 
	@RecipeName	varchar(100) = '',
	@CuisineName varchar(100) = '',
	@RecipeIngredientId int = 0,
	@DatePublished date = '' output,
	@RecipeCount int = 0 output,
	@IncludeBlank bit = 0,
	@Vegan bit = 0,
	@All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName, ''), @RecipeIngredientId  = isnull(@RecipeIngredientId, 0)

	select @RecipeCount = count(distinct r.RecipeId)
	from Recipe r


	select  r.RecipeId, r.UsersId, UserName = concat(u.FirstName, ' ', u.LastName), r.CuisineId, c.CuisineName, r.RecipeName, r.Calories, 
			r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage, 
			NumIngredients = count(distinct ri.IngredientSequence),
			Vegan = @Vegan, RecipeCount = @RecipeCount
	from Recipe r
	join Users u on u.UsersId = r.UsersId
	join Cuisine c on c.CuisineId = r.CuisineId
	left join RecipeIngredient ri on r.RecipeId = ri.RecipeId
	where (r.RecipeId = @RecipeId)
	or (r.RecipeName like '%'+ @RecipeName +'%')
	or (c.CuisineName like '%'+@CuisineName+'%')
	or @All = 1
	group by r.RecipeId, r.UsersId, u.FirstName, u.LastName, r.CuisineId, r.RecipeName, 
    r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage, c.CuisineName 
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
exec RecipeGet @CuisineName = 'American'

declare @RecipeName varchar
select top 1 @RecipeName = r.RecipeName from Recipe r
exec RecipeGet @RecipeName = @RecipeName

select total = count(*) from Recipe r where CuisineName like '%{cuisinename}%'"
select count(*) @CuisineName = c.CuisineName like 'English'
*/



