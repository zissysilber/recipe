create or alter proc dbo.CookbookRecipeDelete(
	@CookbookRecipeId int,
	@Message varchar (500) = '' output)

as
begin	
	declare @return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

	begin try
		begin tran
			delete CookbookRecipe	
			from CookbookRecipe cr
			where cr.CookbookRecipeId = @CookbookRecipeId
		commit
		end try
	begin catch
		rollback;
		throw

	end catch
	return @return

end
go