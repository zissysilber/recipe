Use HeartyHearthDB
go


create or alter procedure dbo.CuisineGet(@CuisineID int = 0, @CuisineName varchar(50) = '', @All bit = 0)
as
begin
	select c.CuisineID, c.CuisineName
	from Cuisine c
	where c.CuisineId = @CuisineID
	or (@CuisineName <> '' and c.CuisineName like '%' + @CuisineName + '%')
	or @All = 1
end
go


/*
exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineID = 2

exec CuisineGet @CuisineName = null

exec CuisineGet @CuisineName = ''

exec CuisineGet @CuisineName = 'm'

declare @CuisineID int
select top 1 @CuisineID = c.CuisineID from Cuisine c
exec CuisineGet @CuisineID = @CuisineID

*/