create or alter procedure dbo.RecipeDelete(
	@RecipeID int
)
as
begin
	begin try
		begin tran
			delete RecipeDirection where RecipeID  = @RecipeID
			delete RecipeIngredient where RecipeID = @RecipeID
			delete Recipe where RecipeID = @RecipeID
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go

/*
