Use HeartyHearthDB
go


create or alter procedure dbo.CuisineGet(
	@CuisineId int = 0, 
	@CuisineName varchar(50) = '', 
	@All bit = 0,
	@Message varchar (500)  = '' output
	)

as
begin
	select c.CuisineId, c.CuisineName
	from Cuisine c
	where c.CuisineId = @CuisineId
	or (@CuisineName <> '' and c.CuisineName like '%' + @CuisineName + '%')
	or @All = 1
	union select 0, ''
	order by c.CuisineName
end
go


/*
exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineId = 2

exec CuisineGet @CuisineName = null

exec CuisineGet @CuisineName = ''

exec CuisineGet @CuisineName = 'm'

declare @CuisineId int
select top 1 @CuisineId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CuisineId

*/