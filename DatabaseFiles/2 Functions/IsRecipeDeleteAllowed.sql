create or alter function dbo.IsRecipeDeleteAllowed(
	@RecipeId int)

	returns varchar(60)

as 
begin

	declare @value varchar (60) = ''
	if exists (select * from 