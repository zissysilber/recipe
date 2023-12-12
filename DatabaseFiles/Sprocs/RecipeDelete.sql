create or alter procedure dbo.RecipeDelete(
	@RecipeID int
)
as
begin
	begin try
		begin tran
			delete Recipe
			from Recipe r
			left join Cuisine c 
			on r.CuisineID = c.CuisineID
			left join Users u
			on u.UsersID = r.UsersID
			where r.RecipeID = @RecipeID
		commit
	end try
	begin catch
		rollback;
		throw
	end catch
end
go







