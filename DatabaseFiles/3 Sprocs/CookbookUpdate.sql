create or alter proc dbo.CookbookUpdate (
	@CookbookId int = 0  output,
	@UsersId int = 0,
	@CookbookName varchar (100) = '',
	@Price decimal = 0 ,
	@DateCreated date = ' ' output,
	@IsActive bit = 0 ,
	@Message varchar (500)  = '' output
)

as 
begin

	declare @return int = 0
	
	select @CookbookId = isnull(@CookbookId, 0), @UsersId = isnull(@UsersId, 0)

	if @CookbookId = 0
	begin
		insert Cookbook(UsersId, CookbookName, Price)
		values (@UsersId, @CookbookName, @Price)

		select @CookbookId = SCOPE_IDENTITY()
		select @DateCreated = GetDate();
	end

	else

	begin
		update Cookbook
		set
		UsersId = @UsersId, 
		CookbookName = @CookbookName, 
		Price = @Price, 
		DateCreated = @DateCreated, 
		IsActive = @IsActive
		where CookbookId = @CookbookId
	end

	return @return

end
go
		
