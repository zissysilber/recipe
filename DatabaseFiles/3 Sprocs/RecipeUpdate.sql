create or alter proc dbo.RecipeUpdate(
	@RecipeId int output,
	@UsersId int,
	@CuisineId int,
	@RecipeName varchar (100),
	@Calories int,
	@DateDrafted datetime,
	@DatePublished datetime,
	@DateArchived datetime
	)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @DateDrafted = isnull(@DateDrafted, GETDATE()), @DatePublished = nullif(@DatePublished, 0), @DateArchived = nullif(@DateArchived, 0)
	
	
	if @RecipeId = 0
	begin
		insert Recipe(UsersId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		values(@UsersId, @CuisineId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

		select @RecipeId = SCOPE_IDENTITY()
	end
	
	else
	
	begin
		update Recipe
		set
			UsersId = @UsersId, 
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DateDrafted = @DateDrafted, 
			DatePublished = @DatePublished, 
			DateArchived = @DateArchived 
		where RecipeId = @RecipeId
	end

	return @return
	

end
go