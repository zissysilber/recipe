create or alter proc dbo.IngredientDelete(
	@IngredientId int,
	@Message varchar(500) = ''
	)

as
begin
	declare @return int = 0
	select @IngredientId = isnull(@IngredientId, 0)

	begin try
		begin tran
			delete RecipeIngredient
			from RecipeIngredient ri
			where ri.IngredientId = @IngredientId

			delete Ingredient 
			where IngredientId  = @IngredientId
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return

end
go

/*
declare @IngredientId int
select @IngredientId = 109
			delete RecipeIngredient
			from RecipeIngredient ri
			where ri.IngredientId = @IngredientId

			delete Ingredient 
			where IngredientId  = @IngredientId

select * from Ingredient

*/
