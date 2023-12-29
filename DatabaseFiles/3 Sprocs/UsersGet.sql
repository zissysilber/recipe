create or alter procedure dbo.UsersGet(
	@UsersId int = 0, 
	@UsersName varchar(25) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output)
as
begin
	select @UsersName = nullif(@UsersName,'')

	select u.UsersId, u.UsersName, u.FirstName, u.LastName
	from Users u
	where u.UsersId = @UsersId
	or u.UsersName like '%' + @UsersName + '%'
	or @All = 1
	union select 0, 0, ' ', ' '
	where @IncludeBlank = 1

end
go


/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UsersId = 3

exec UsersGet @UsersName = ''

exec UsersGet @UsersName = 'f'

exec UsersGet @UsersName  = null

declare @UsersName varchar
select top 1 @UsersName = u.UsersName from Users U
exec UsersGet @UsersName = @UsersName

*/

select * from Users