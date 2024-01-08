create or alter proc dbo.UsersUpdate(
	@UsersId int  = 0 output,
	@UsersName varchar (50) = '',
	@FirstName varchar (30)= '',
	@LastName varchar (30)= '',
	@Messsage varchar (500) = '' output)

as
begin
	declare @return int = 0

	select @UsersId= isnull(@UsersId, 0)

	if @UsersId = 0
	begin
		insert Users(UsersName, FirstName, LastName)
		values (@UsersName, @FirstName, @LastName)
		
		select @UsersId = SCOPE_IDENTITY()

	end
	else
	begin
		update Users	
		set 
			UsersName = @UsersName, 
			FirstName = @FirstName, 
			LastName = @LastName
			where UsersId = @UsersId
		end

		return @return

end
go