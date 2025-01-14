create or alter proc dbo.RecipeUpdate(
	@RecipeId int = 0 output,
	@UsersId int = 0,
	@CuisineId int = 0,
	@RecipeName varchar (100) = ' ',
	@Calories int = 0,
	@Vegan bit = false,
	@DateDrafted datetime = ' ' output,
	@DatePublished datetime,
	@DateArchived datetime,
	@RecipeStatus varchar (10) output
	)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0), 
	@UsersId = isnull(@UsersId, 0), 
	@CuisineId = isnull(@CuisineId, 0), 
	@DateDrafted = isnull(@DateDrafted, GETDATE()), 
	@DatePublished = nullif(@DatePublished, 0), 
	@DateArchived = nullif(@DateArchived, 0),
	@RecipeStatus = isnull(@RecipeStatus, '');
	
	
	if @RecipeId = 0
	begin
		insert Recipe(UsersId, CuisineId, RecipeName, Calories, Vegan, DateDrafted, DatePublished, DateArchived)
		values(@UsersId, @CuisineId, @RecipeName, @Calories, @Vegan, @DateDrafted, @DatePublished, @DateArchived)

		select @RecipeId = SCOPE_IDENTITY()
		select @DateDrafted = GetDate();

	end
	
	else
	

		if @DatePublished > @DateArchived
		begin
			select @DateArchived = null
		end

		if @DateDrafted > @DatePublished
		begin
			select @DatePublished = null
			select @DateArchived = null
		end

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

			select @RecipeStatus = RecipeStatus
			from Recipe
			where RecipeId = @RecipeId;

	return @return
	

end
go