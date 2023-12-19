create or alter procedure dbo.RecipeDelete(
	@RecipeID int,
	@Message varchar(500) = '' output

)
as
begin
	declare @return int = 0

	if exists(select * from Recipe r 
				where r.RecipeID = @RecipeID 
				 and (r.RecipeStatus = 'Published'
				 or (r.RecipeStatus = 'Archived' and DateAdd(day, 30, r.DateArchived) >= GetDate()) ))
				 
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is currently published or has been archived less than 30 days ago.'
		goto finished
	end

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

	finished:
	return @return

end
go

