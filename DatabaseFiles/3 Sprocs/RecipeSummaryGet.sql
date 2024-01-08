create or alter proc.RecipeSummaryGet(
	@All bit = 0,
	@Message varchar (500) = ' '
)

as
begin
	select r.RecipeId, r.RecipeName, Status = r.RecipeStatus, [User] = concat(u.Firstname, ' ', u.LastName ), r.Calories, [Num Ingredients] = count(distinct ri.IngredientId) 
	from Recipe r
	join Users u
	on u.UsersId = r.UsersId
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	group by r.RecipeID, r.RecipeName, r.RecipeStatus, u.FirstName, u.LastName, r.Calories
	order by 
		case r.RecipeStatus  
			when  'published' then 1
			when  'draft' then 2
			else 3
			end

	select @All = 1
end
go

