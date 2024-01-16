create or alter proc dbo.CookbookCreate(
	@CookbookId int = null output,
	@BasedOnUsersId int = 0,
	@Message varchar (500) = ' ' output
	)

as 
begin
	
	declare @return int = 0

	select @BasedonUsersId = isnull(@BasedOnUsersId, 0)

	if exists(select * from Users u
				left join Recipe r
				on r.UsersId = u.UsersId
				where u.UsersId  = @BasedOnUsersId
				and r.RecipeId is null)

	begin
		select @return = 1, @Message = 'Cookbook cannot be created because selected User does not have saved Recipes.'
		goto finished
	end

	select @CookbookId = isnull(@CookbookId, 0), @BasedOnUsersId = isnull(@BasedOnUsersId, 0)


	Insert Cookbook(UsersId, CookbookName, Price, IsActive)
	select u.UsersId, concat('Recipes by ', u.FirstName, ' ', u.LastName), TotalRecipes = Count(r.RecipeId) * 1.33, 1
	from  Users u
	join Recipe r
	on r.UsersId = u.UsersId
	where u.UsersId = @BasedOnUsersId
	group by u.UsersId, u.FirstName, u.LastName

	Select @CookbookId = SCOPE_IDENTITY() 

	Insert CookBookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
	select  @CookbookId , r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
	from Recipe r
	where r.UsersId = @BasedOnUsersId


	select @return = @CookbookId

	finished:
	return @return

end
go













