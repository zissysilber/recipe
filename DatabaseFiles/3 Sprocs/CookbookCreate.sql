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
	;
	with x as(
		select Users = u.Usersname, TotalRecipes = Count(r.RecipeId)
		from Recipe r
		join Users u
		on r.UsersId = u.UsersId
		where u.UsersId = @BasedOnUsersId
		group by u.UsersName
	)
	Insert Cookbook(UsersId, CookbookName, Price, IsActive)
	select u.UsersId, concat('Recipes by ', u.FirstName, ' ', u.LastName), x.TotalRecipes * 1.33, 1
	from x
	join Users u
	on x.Users = u.UsersName
	where u.UsersId = @BasedOnUsersId

	Select @CookbookId = SCOPE_IDENTITY() 

	Insert CookBookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
	select  @CookbookId , r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
	from Cookbook c
	join Users u
	on c.UsersId = u.UsersId
	join Recipe r
	on u.UsersId = r.UsersId
	where c.CookbookName = concat('Recipes by ', u.FirstName, ' ', u.LastName) 
	and u.UsersId = @BasedOnUsersId

	select @return = @CookbookId

	finished:
	return @return

end
go













