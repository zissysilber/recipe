create or alter procedure dbo.RecipeDelete(
	@RecipeId int,
	@Message varchar(500) = '' output

)
as
begin
	declare @return int = 0

	if exists(select * from Recipe r 
				where r.RecipeId = @RecipeId 
				 and (r.RecipeStatus = 'Published'
				 or (r.RecipeStatus = 'Archived' and DateAdd(day, 30, r.DateArchived) >= GetDate()) ))
				 
	begin
		select @return = 1, @Message = 'Cannot delete recipe that is currently published or has been archived less than 30 days ago.'
		goto finished
	end

	begin try
		begin tran
			delete RecipeDirection where RecipeId  = @RecipeId
			delete RecipeIngredient where RecipeId = @RecipeId
			delete Recipe where RecipeId = @RecipeId
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

