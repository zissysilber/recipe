create or alter procedure dbo.UsersGet(@UsersID int = 0, @UsersName varchar(25) = '', @All bit = 0)
as
begin
	select @UsersName = nullif(@UsersName,'')
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
