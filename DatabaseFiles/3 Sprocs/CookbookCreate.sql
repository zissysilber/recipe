create or alter proc dbo.CookbookCreate(
	@CookbookId int = null output,
	@Price int,
	@CookbookName varchar (50),
	@DateCreated varchar,
	@BasedOnUsersId int,
	@Message varchar (500) = ' ' output
	)

as 
begin

	declare @return int = 0

	select @CookbookName = concat('Recipes by ', u.FirstName, ' ', u.LastName) from Users u

	
	insert Cookbook(UsersId, CookbookName, Price, DateCreated, IsActive)
	select UsersId, @CookbookName, @Price, @DateCreated, IsActive
	from Cookbook c
	where UsersId = @BasedOnUsersId

	select @CookbookId = SCOPE_IDENTITY()

	insert CookbookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
	select @CookbookId, cr.RecipeId, cr.CookbookRecipeSequence
	from CookbookRecipe cr