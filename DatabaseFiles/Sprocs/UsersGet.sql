create or alter procedure dbo.UsersGet(@UsersID int = 0, @UsersName varchar(25) = '', @All bit = 0)
as
begin
	--Af Formatting tip: It's good to have a line break between the 2 select statements, to make it more readable
	select @UsersName = nullif(@UsersName,'')
	--AF In a basic get sproc, you should return all columns in the table, include the other columns in the users table
	select u.UsersID, u.UsersName
	from Users u
	where u.UsersID = @UsersID
	or u.UsersName like '%' + @UsersName + '%'
	or @All = 1
end
go


/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UsersID = 3

exec UsersGet @UsersName = ''

exec UsersGet @UsersName = 'f'

exec UsersGet @UsersName  = null

declare @UsersName varchar
select top 1 @UsersName = u.UsersName from Users U
exec UsersGet @UsersName = @UsersName

*/
