-- SM Excellent work! 100%
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause 
--using a unique value that identifies it, do not use the primary key.


--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete mr
--select * 
from MealCourseRecipe mr
left join MealCourse mc
on mr.MealCourseId = mc.MealCourseId
left join meal m
on mc.MealId = m.MealId
join Users u
on m.UsersId = u.UsersId
where U.UsersName = 'Fay303'

delete mr
--select * 
from MealCourseRecipe mr
join Recipe r
on mr.RecipeId = r.RecipeId
join Users u
on r.UsersId = U.UsersId
where u.UsersName = 'Fay303'

delete mc
--select *
from MealCourse mc
join Meal m
on mc.MealId = m.MealId
join Course c
on mc.CourseId = c.CourseId
join Users u
on m.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete m
--select *
from Meal m
join Users u
on m.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete rd
--select *
from RecipeDirection rd
join RecipeIngredient ri
on rd.RecipeId = ri.RecipeId
join Recipe r
on rd.RecipeId = r.RecipeId
join Users u
on r.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete ri
--select *
from RecipeIngredient ri 
join Recipe r
on ri.RecipeId = r.RecipeId
join Users u
on r.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete cr
--select * 
from Cookbook c 
left join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
left join Recipe r
on cr.RecipeId = r.RecipeId
left join Users u
on c.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete r
--select *
from Recipe r
join Users u
on r.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete c
--select *
from Cookbook c
join Users u
on c.UsersId = u.UsersId
where u.UsersName = 'Fay303'

delete u
--select *
from Users u
where u.UsersName = 'Fay303'



--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
Insert Recipe(UsersId, CuisineId, RecipeName, Calories)
select r.UsersId, r.CuisineId, concat(r.RecipeName, ' - clone'), r.Calories
from Recipe r
where r.RecipeName = 'Butter Muffins'

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.


*/

;
with x as(
	select Users = u.Usersname, TotalRecipes = Count(r.RecipeId)
	from Recipe r
	join Users u
	on r.UsersId = u.UsersId
	where u.UsersName = 'Betty101'
	group by u.UsersName
)
Insert Cookbook(UsersId, CookbookName, Price, IsActive)
select u.UsersId, concat('Recipes by ', u.FirstName, ' ', u.LastName), x.TotalRecipes * 1.33, 1
from x
join Users u
on x.Users = u.UsersName
where u.UsersName = 'Betty101'

Insert CookBookRecipe(CookbookId, RecipeId, CookbookRecipeSequence)
select c.CookbookId, r.RecipeId, ROW_NUMBER() over (order by r.RecipeName)
from Cookbook c
join Users u
on c.UsersId = u.UsersId
join Recipe r
on u.UsersId = r.UsersId
where c.CookbookName = concat('Recipes by ', u.FirstName, ' ', u.LastName) 
and u.Usersname = 'Betty101'

/*
Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example,  
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 

*/
--the calorie count for butter went down by 2 per ounce, and 10 per stick of butter.
Update r
set r.Calories =  case
--select r.RecipeName, r.Calories, ri.MeasurementAmt, NewCalories = case
	when m.MeasurementName = 'stick' then r.Calories - (ri.MeasurementAmt*10)
	when m.MeasurementName = 'oz' then r.Calories - (ri.MeasurementAmt*2)
	end
from RecipeIngredient ri
join Ingredient i
on ri.IngredientId = i.IngredientId
join Measurement m
on ri.MeasurementId = m.MeasurementId
join Recipe r
on ri.RecipeId = r.RecipeId
where i.IngredientName = 'Butter'
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	Users First Name, 
	Users Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
		
*/

;
With x as(
	select TimeLapse = Avg(datediff(hour, r.DateDrafted, r.DatePublished))
	from Recipe r
	where r.DatePublished is not null

)
Select	u.FirstName, 
		u.Lastname, 
		EmailAddress = (lower((substring(u.FirstName,1,1))) + lower(u.LastName) + '@heartyhearth.com'),
		Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour, r.DateDrafted, getdate()), ' hours.  That is ', datediff(hour, r.DateDrafted, getdate()) - x.TimeLapse, ' hours more than the average ', x.TimeLapse,' hours all other recipes took to be published.') 
	from users u
	join Recipe r
	on u.UsersId = r.UsersId
	join x
	on (datediff(hour, r.DateDrafted, getdate())) > x.TimeLapse
	where r.RecipeStatus = 'Drafted'

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/

;
with x as(	
	select AvgPrice = AVG(c.Price)
	from Cookbook c
)
select 
EmailBody = concat('We have ', 
count(c.CookbookId), 
' books for sale, average price is ', 
convert(decimal(5,2), x.AvgPrice), 
'. You can order them all and receive a 25% discount, for a total of ', 
convert(decimal(5,2),(sum(c.Price)*.75)), 
'. Click <a href = "www.heartyhearth.com/order/', 
NewId(), '">here</a> to order.' ) 
from cookbook c
join x
on x.AvgPrice > c.Price or x.AvgPrice < c.Price or x.AvgPrice = c.Price
group by x.AvgPrice