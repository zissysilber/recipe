create or alter procedure dbo.IngredientGet(
	@IngredientId int = 0,
	@IngredientName varchar(25) = '',
	@All bit = 0,
	@Message varchar(500) = ' ' output)

as
begin
	declare @return int = 0

	select @All = isnull(@All, 0), @IngredientId = isnull(@IngredientId, 0), @IngredientName = nullif(@IngredientName, '')

	select i.IngredientId, i.IngredientName
	from Ingredient i
	where IngredientId  = @IngredientId
	or (IngredientName like '%' +  @IngredientName + '%') 
	or @All = 1
	order by i.IngredientName

	return @return

end
go

/*
exec IngredientGet @IngredientName = 'ee'
*/