create or alter proc dbo.CookbookCreate(
	@CookbookId int = null output,
	@Price int = 0,
	@CookbookName varchar (50) = ' ',
	@DateCreated date  = ' ' ,
	@BasedOnUsersId int = 0,
	@Message varchar (500) = ' ' output
	)

as 
begin

	declare @return int = 0

	select @CookbookName = concat('Recipes by ', u.FirstName, ' ', u.LastName) 
	from Users u
	where u.UsersId = @BasedOnUsersId

	declare @RecipesPerUser int
	select @RecipesPerUser = dbo.RecipesPerUser((@BasedOnUsersId))
	select @Price = @RecipesPerUser * 1.33

	
	select @DateCreated = GetDate()

	insert Cookbook(UsersId, CookbookName, Price, DateCreated, IsActive)
	select UsersId, @CookbookName, @Price, @DateCreated, IsActive
	from Cookbook c
	where UsersId = @BasedOnUsersId

	select @CookbookId = SCOPE_IDENTITY()

	insert CookbookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
	select @CookbookId, cr.RecipeId, cr.CookbookRecipeSequence
	from CookbookRecipe cr
	join Recipe r
	on cr.RecipeId = r.RecipeId
	order by r.RecipeName

	return @CookbookId

end
go


--declare
--	@CookbookId int,
--	@Price int,
--	@CookbookName varchar,
--	@DateCreated varchar ,
--	@BasedOnUsersId int,
--	@i int,
--	@m varchar(500)

--select top 1 @BasedOnUsersId =  u.UsersId from Users u where u.UsersName like '%Betty%'
--select @CookbookName =  'Test'
--select @Price = u.UsersId from Users u where u.UsersName like '%Betty%'










