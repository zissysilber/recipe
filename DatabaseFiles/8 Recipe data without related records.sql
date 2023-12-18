use HeartyHearthDB
go

/*Only insert below if not populating with other sample data
Insert Users(UsersName, FirstName, LastName)
select 'Betty101', 'Betty', 'Baker'
union select 'Cindy202', 'Cindy', 'Chef'
union select 'Fay303', 'Fay', 'Foodie'
union select 'Dina404', 'Dina', 'Dietetic'
go

Insert Cuisine(CuisineName)
select 'English'
union select 'French'
union select 'Italian'
union select 'American'
union select 'Hungarian'
go
*/
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Chocolate', Calories = 75, DateDrafted = '10/01/2005', DatePublished = '12/01/2005', DateArchived = '12/12/2021' 
    union select 'Betty101', 'French', 'Flavorful Tea', 120,  '10/01/2006', null, '12/01/2016'
    union select 'Cindy202', 'American', 'Lovely Lemonade', 150,  '05/05/2005', null, '07/07/2005' 
    union select 'Cindy202', 'Hungarian', 'Peanut Butter Smoothie', 150,  '09/09/2009', '10/10/2010', null 
    union select 'Fay303', 'French', 'Warm Cinnamon Milk', 175,  '10/01/2020', '12/01/2020', '12/01/2021'

)
Insert Recipe(UsersID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea', Calories = 5, DateDrafted = '10/01/2005', DatePublished = '10/02/2005', DateArchived = '10/03/2005' 
)
Insert Recipe(UsersID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

Insert Ingredient(IngredientName)
select 'water'

;
with x as(
    select RecipeName = 'Flavorful Tea', MsmtAmt = '1', Msmt = 'cup', Ingredient = 'water', IngSeq = 1
    union select 'Flavorful Tea', '1', 'tsp', 'sugar', 2

)
Insert RecipeIngredient(RecipeID, MeasurementAmt, MeasurementID, IngredientID, IngredientSequence)
select r.RecipeID, x.MsmtAmt, m.MeasurementID, i.IngredientID, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
left join Measurement m
on x.Msmt = m.MeasurementName
join Ingredient i
on x.Ingredient = i.IngredientName

select * from recipe r
left join recipeingredient ri
on ri.RecipeID = r.RecipeID
where r.RecipeName = 'Flavorful Tea'


;
with x as(
    select RecipeName = 'Flavorful Tea', DirectionSequence = 1, DirectionDesc = 'Boil water.' 
    union select 'Flavorful Tea', 2, 'Pour over tea bag and allow to stew.' 
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName


