create or alter proc dbo.CookbookRecipeGet(
	@CookbookRecipeId int = 0  output,
	@CookbookId int = 0 ,
	@RecipeId int = 0 ,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar (500)  = '' output
)

as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = isnull(@CookbookId,0), @RecipeId = isnull(@RecipeId, 0)

	select cr.CookbookRecipeId, cr.CookbookId, cr.RecipeId, cr.CookbookRecipeSequence 
	from CookbookRecipe cr
	join Recipe r
	on r.RecipeId = cr.RecipeId
	where cr.CookbookId = @CookbookId
	or @All = 1
	order by cr.CookbookRecipeSequence

	return @return

end
go

execute CookbookRecipeGet @All = 1