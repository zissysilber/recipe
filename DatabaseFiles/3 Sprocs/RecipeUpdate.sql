create or alter proc dbo.RecipeUpdate(
	@RecipeID int output,
	@UsersID int,
	@CuisineID int,
	@RecipeName varchar (100),
	@Calories int,
	@DateDrafted datetime,
	@DatePublished datetime,
	@DateArchived datetime
	)
as
begin
	declare @return int = 0

	select @RecipeID = isnull(@RecipeID, 0), @DateDrafted = isnull(@DateDrafted, GETDATE()), @DatePublished = nullif(@DatePublished, 0), @DateArchived = nullif(@DateArchived, 0)
	
	
	if @RecipeID = 0
	begin
		insert Recipe(UsersID, CuisineID, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
		values(@UsersID, @CuisineID, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

		select @RecipeID = SCOPE_IDENTITY()
	end
	
	else
	
	begin
		update Recipe
		set
			UsersID = @UsersID, 
			CuisineID = @CuisineID, 
			RecipeName = @RecipeName, 
			Calories = @Calories, 
			DateDrafted = @DateDrafted, 
			DatePublished = @DatePublished, 
			DateArchived = @DateArchived 
		where RecipeID = @RecipeID
	end

	return @return
	

end
go