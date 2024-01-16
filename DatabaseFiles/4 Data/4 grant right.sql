Use HeartyHearthDB
go

/*
select concat ('grant execute on ', r.ROUTINE_NAME,' to approle')
from INFORMATION_SCHEMA.ROUTINES r
where r.ROUTINE_NAME not like '%gener%'
and r.ROUTINE_NAME not like '%colna%'
*/

grant execute on RecipeInfo to approle
grant execute on MealCalories to approle
grant execute on RecipesPerUser to approle
grant execute on UsersUpdate to approle
grant execute on UsersGet to approle
grant execute on UsersDelete to approle
grant execute on SummaryDatabaseGet to approle
grant execute on RecipeUpdate to approle
grant execute on RecipeSummaryGet to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on RecipeIngredientGet to approle
grant execute on RecipeIngredientDelete to approle
grant execute on RecipeGet to approle
grant execute on RecipeDirectionUpdate to approle
grant execute on RecipeDirectionGet to approle
grant execute on RecipeDirectionDelete to approle
grant execute on RecipeDelete to approle
grant execute on RecipeClone to approle
grant execute on MeasurementUpdate to approle
grant execute on MeasurementGet to approle
grant execute on MeasurementDelete to approle
grant execute on MealSummaryGet to approle
grant execute on IngredientUpdate to approle
grant execute on IngredientGet to approle
grant execute on IngredientDelete to approle
grant execute on CuisineUpdate to approle
grant execute on CuisineGet to approle
grant execute on CuisineDelete to approle
grant execute on CourseUpdate to approle
grant execute on CourseGet to approle
grant execute on CourseDelete to approle
grant execute on CookbookUpdate to approle
grant execute on CookbookSummaryGet to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on CookbookRecipeGet to approle
grant execute on CookbookRecipeDelete to approle
grant execute on CookbookGet to approle
grant execute on CookbookDelete to approle
grant execute on CookbookCreate to approle

