create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int = 0  output,
	@CookbookId int = 0 ,
	@RecipeId int = 0 ,
	@CookbookRecipeSequence int = 0)

as
begin
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0), @CookbookId = isnull(@CookbookId, 0), @RecipeId = isnull(@RecipeId, 0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
		values (@CookbookId, @RecipeId, @CookbookRecipeSequence)

		select @CookbookRecipeId = SCOPE_IDENTITY()

	end

	else
	begin
		update CookbookRecipe
		set
			CookbookId = @CookbookId, 
			RecipeId = @RecipeId, 
			CookbookRecipeSequence = @CookbookRecipeSequence
			where CookbookRecipeId = @CookbookRecipeId
		end

		return @return

	end
	go


