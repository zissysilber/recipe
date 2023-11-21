-- SM Excellent work! 100%
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause 
--using a unique value that identifies it, do not use the primary key.


--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete mr
--select * 
from MealCourseRecipe mr
left join MealCourse mc
on mr.MealCourseId = mc.MealCourseID
left join meal m
on mc.MealID = m.MealID
join Users u
on m.UserID = u.UserID
where U.UserName = 'Betty101'

delete mr
--select * 
from MealCourseRecipe mr
join Recipe r
on mr.RecipeID = r.RecipeID
join Users u
on r.UserID = U.UserID
where u.UserName = 'Betty101'

delete mc
--select *
from MealCourse mc
join Meal m
on mc.MealID = m.MealID
join Course c
on mc.CourseId = c.CourseID
join Users u
on m.UserID = u.UserID
where u.UserName = 'Betty101'

delete m
--select *
from Meal m
join Users u
on m.UserID = u.UserID
where u.UserName = 'Betty101'

delete rd
--select *
from RecipeDirection rd
join RecipeIngredient ri
on rd.RecipeID = ri.RecipeID
join Recipe r
on rd.RecipeID = r.RecipeID
join Users u
on r.UserID = u.UserID
where u.UserName = 'Betty101'

delete ri
--select *
from RecipeIngredient ri 
join Recipe r
on ri.RecipeID = r.RecipeID
join Users u
on r.UserID = u.UserID
where u.UserName = 'Betty101'

delete cr
--select * 
from Cookbook c 
left join CookbookRecipe cr
on c.CookbookID = cr.CookbookID
left join Recipe r
on cr.RecipeID = r.RecipeID
left join Users u
on c.UserID = u.UserID
where u.UserName = 'Betty101'

delete r
--select *
from Recipe r
join Users u
on r.UserID = u.UserID
where u.UserName = 'Betty101'

delete c
--select *
from Cookbook c
join Users u
on c.UserID = u.UserID
where u.UserName = 'Betty101'

delete u
--select *
from Users u
where u.UserName = 'Betty101'



--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
Insert Recipe(UserID, CuisineID, RecipeName, Calories)
select r.UserID, r.CuisineID, concat(r.RecipeName, ' - clone'), r.Calories
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
	select Users = u.Username, TotalRecipes = Count(r.RecipeID)
	from Recipe r
	join Users u
	on r.UserID = u.UserID
	where u.UserName = 'Betty101'
	group by u.UserName
)
Insert Cookbook(UserID, CookbookName, Price, IsActive)
select u.UserID, concat('Recipes by ', u.FirstName, ' ', u.LastName), x.TotalRecipes * 1.33, 1
from x
join Users u
on x.Users = u.UserName
where u.UserName = 'Betty101'

Insert CookBookRecipe(CookbookID, RecipeID, CookbookRecipeSequence)
select c.CookbookID, r.RecipeID, ROW_NUMBER() over (order by r.RecipeName)
from Cookbook c
join Users u
on c.UserID = u.UserID
join Recipe r
on u.UserID = r.UserID
where c.CookbookName = concat('Recipes by ', u.FirstName, ' ', u.LastName) 
and u.Username = 'Betty101'

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
on ri.IngredientID = i.IngredientID
join Measurement m
on ri.MeasurementID = m.MeasurementID
join Recipe r
on ri.RecipeID = r.RecipeID
where i.IngredientName = 'Butter'
/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
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
	on u.UserID = r.UserID
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
count(c.CookbookID), 
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