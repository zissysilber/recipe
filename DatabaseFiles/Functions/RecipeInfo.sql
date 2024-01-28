/*
Ex: Homemade Pizza (Italian) has 8 ingredients and 5 steps.
*/

create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(190)
as

begin
	declare @value varchar(190) = ''
	select @value = 
	concat(
			r.RecipeName, 
			' (',
			c.CuisineName,
			')',
			case when count(distinct ri.IngredientSequence) > 0
				 then
						concat( ' has ',count(distinct ri.IngredientSequence)
						, 
							case	when count(distinct ri.IngredientSequence) > 1 
									then concat(' ingredients and ', count(distinct rd.DirectionSequence), ' steps.' )
									else concat (' ingredient and ', count(distinct rd.DirectionSequence), ' steps.')
							end
							)
				else ' does not have published ingredients and directions.'
				end	
			)
from Recipe r
join Cuisine c on c.CuisineId = r.CuisineId
left join RecipeDirection rd on rd.RecipeId = r.RecipeId
left join RecipeIngredient ri on ri.RecipeId = r.RecipeId
where r.RecipeId = @RecipeId
group by r.RecipeName, c.CuisineName

return @value
end
go

/*
select RecipeInfo = dbo.RecipeInfo(r.RecipeId)
from recipe r

*/




