create or alter proc.RecipeSummaryGet(
	@All bit = 0,
	@Message varchar (500) = ' '
)

as
begin
	select r.RecipeId, r.RecipeName, [Recipe Details]=dbo.RecipeInfo(r.RecipeId), 
	Status = r.RecipeStatus, [User] = concat(u.Firstname, ' ', u.LastName ), r.Calories 
	from Recipe r
	join Users u
	on u.UsersId = r.UsersId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	group by r.RecipeID, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories
	order by 
		case r.RecipeStatus  
			when  'Published' then 1
			when  'Drafted' then 2
			when 'Archived' then 3
			end

	select @All = 1
end
go



