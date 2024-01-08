create or alter function dbo.RecipesPerUser(@UsersId int)
returns int 

as

begin
declare @value int = ''
	select @value =  (count(r.UsersId))
	from Recipe r
	left join Users u
	on r.UsersId = u.UsersId
	where r.UsersId = @UsersId
	group by r.UsersId

return @value

end
go

/*
select u.UsersName, RecipesPerUser = dbo.RecipesPerUser( r.UsersId)
from Recipe r
join Users u
on r.UsersId = u.UsersId
--where u.UsersName = 'Betty101'
group by r.UsersId, u.UsersName
*/




