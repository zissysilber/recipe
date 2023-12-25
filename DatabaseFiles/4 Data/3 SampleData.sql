-- SM Excellent! 100%
Use HeartyHearthDB
go

delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Course
delete Meal
delete RecipeDirection
delete RecipeIngredient
delete Measurement
delete Ingredient
delete Recipe
delete Cuisine
delete Users


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


Insert Ingredient(IngredientName)
select 'baking powder'
union select 'baking soda'
union select 'balsamic vinegar'
union select 'beef stew meat'
union select 'black pepper'
union select 'bread'
union select 'brown sugar'
union select 'butter'
union select 'cantaloupe balls'
union select 'chocolate chips'
union select 'chopped parsley'
union select 'garlic (crushed)'
union select 'egg'
union select 'eggs'
union select 'English cucumber'
union select 'feta cheese'
union select 'flour'
union select 'fresh dill'
union select 'garlic powder'
union select 'granny smith apples'
union select 'ground beef'
union select 'honey'
union select 'ice cubes'
union select 'ketchup'
union select 'margarine'
union select 'mayonnaise'
union select 'meatball spice'
union select 'mustard'
union select 'oil'
union select 'olive oil'
union select 'onion'
union select 'onions'
union select 'onions (diced)'
union select 'orange juice'
union select 'pickle juice'
union select 'potatoes'
union select 'puff pastry sheets'
union select 'red potatoes'
union select 'salt'
union select 'scallion'
union select 'scallions'
union select 'sesame seeds'
union select 'shredded cheese'
union select 'purple onion'
union select 'small red potatoes'
union select 'sour cream'
union select 'sour pickles'
union select 'stick butter'
union select 'sugar'
union select 'vanilla pudding'
union select 'vanilla sugar'
union select 'vanilla yogurt'
union select 'vinegar'
union select 'whipped cream cheese'
go

Insert Measurement(MeasurementName)
select 'cup'
union select 'cups'
union select 'ounce'
union select 'ounces'
union select 'of'
union select 'pound'
union select 'pounds'
union select 'sprigs'
union select 'tsp'
union select 'tbsp'
union select 'package'
union select 'club'
union select 'oz'
union select 'stick'
union select 'sticks'
union select 'clove'
union select 'cloves'
union select 'package'
union select 'small'
union select 'bite-sized'
go


;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Chocolate Chip Cookies', Calories = 75, DateDrafted = '10/01/2005', DatePublished = '12/01/2005', DateArchived = null 
    union select 'Betty101', 'French', 'Apple Yogurt Smoothie', 120,  '10/01/2006', null, '12/01/2006'
    union select 'Betty101', 'English', 'Cheese Bread', 165,  '10/21/2021', '12/21/2021', '1/2/2022' 
    union select 'Betty101', 'American', 'Butter Muffins', 185,  '01/01/2021', '01/02/2021', null 
    union select 'Cindy202', 'American', 'Meat Stew', 150,  '05/05/2005', null, '07/07/2005' 
    union select 'Cindy202', 'Hungarian', 'Express Doughless Knishes', 150,  '09/09/2009', '10/10/2010', null 
    union select 'Fay303', 'French', 'Meatball Bites', 175,  '10/01/2020', '12/01/2020', '12/01/2022'
    union select 'Fay303', 'American', 'Red Potato Salad', 180,  '01/01/2020', '01/02/2020', null 
    union select 'Fay303', 'French', 'Cantaloupe and Feta Salad', 110,  '12/12/2020', '1/2/2021', null
    union select 'Fay303', 'Italian', 'Basic Balsamic Dressing', 30, '1/1/2022', null, null 
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
    select RecipeName = 'Chocolate Chip Cookies', MsmtAmt = '1', Msmt = 'cup', Ingredient = 'sugar', IngSeq = 1
    union select 'Chocolate Chip Cookies', '1/2', 'cup', 'oil', 2
    union select 'Chocolate Chip Cookies', '3', null, 'eggs', 3
    union select 'Chocolate Chip Cookies', '2', 'cups', 'flour', 4
    union select 'Chocolate Chip Cookies', '1', 'tsp', 'vanilla sugar', 5
    union select 'Chocolate Chip Cookies', '2', 'tsp', 'baking powder', 6
    union select 'Chocolate Chip Cookies', '1/2', 'tsp', 'baking soda', 7
    union select 'Chocolate Chip Cookies', '1', 'cup', 'chocolate chips', 8
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

;
with x as(
    select RecipeName = 'Apple Yogurt Smoothie', MsmtAmt = '3', Msmt = null, Ingredient = 'granny smith apples', IngSeq = 1
    union select 'Apple Yogurt Smoothie', '2', 'cups', 'vanilla yogurt', 2
    union select 'Apple Yogurt Smoothie', '2', 'tsp', 'sugar', 3
    union select 'Apple Yogurt Smoothie', '1/2', 'cup', 'orange juice', 4
    union select 'Apple Yogurt Smoothie', '2', 'tbsp', 'honey', 5
    union select 'Apple Yogurt Smoothie', '5-6', null, 'ice cubes', 6
)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Msmt = m.MeasurementName


;
with x as(
    select RecipeName = 'Cheese Bread', MsmtAmt = '1', Msmt = 'club', Ingredient = 'bread', IngSeq = 1
    union select 'Cheese Bread', '4', 'oz', 'butter', 2
    union select 'Cheese Bread', '8', 'oz', 'shredded cheese', 3
    union select 'Cheese Bread', '2', 'cloves', 'garlic (crushed)', 4
    union select 'Cheese Bread', '1/4', 'tsp', 'black pepper', 5
    union select 'Cheese Bread', 'pinch', 'of', 'salt', 6

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName = 'Butter Muffins', MsmtAmt = '1', Msmt = 'stick', Ingredient = 'butter', IngSeq = 1
    union select 'Butter Muffins', '3', 'cups', 'sugar', 2
    union select 'Butter Muffins', '2', 'tbsp', 'vanilla pudding', 3
    union select 'Butter Muffins', '4', null, 'eggs', 4
    union select 'Butter Muffins', '8', 'oz', 'whipped cream cheese', 5
    union select 'Butter Muffins', '8', 'oz', 'sour cream', 6
    union select 'Butter Muffins', '1', 'cup', 'flour', 7
    union select 'Butter Muffins', '2', 'tsp', 'baking powder', 8

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName = 'Meat Stew', MsmtAmt = '1', Msmt = null, Ingredient = 'onion', IngSeq = 1
    union select 'Meat Stew', '1', 'tsp', 'garlic powder', 2
    union select 'Meat Stew', '3', 'tbsp', 'oil', 3
    union select 'Meat Stew', '1', 'package', 'beef stew meat', 4
    union select 'Meat Stew', '1/2', 'cup', 'ketchup', 5
    union select 'Meat Stew', '3/4', 'cup', 'brown sugar', 6
    union select 'Meat Stew', '2', 'tbsp', 'vinegar', 7
)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName = 'Meatball Bites', MsmtAmt = '1', Msmt = 'package', Ingredient = 'puff pastry sheets', IngSeq = 1
    union select 'Meatball Bites', '1', 'pound', 'ground beef', 2
    union select 'Meatball Bites', '3', 'tbsp', 'meatball spice', 3
    union select 'Meatball Bites', '2', 'tbsp', 'chopped parsley', 4
    union select 'Meatball Bites', '1', null, 'egg', 5

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName = 'Red Potato Salad', MsmtAmt = '2 to 3', Msmt = 'pounds', Ingredient = 'small red potatoes', IngSeq = 1
    union select 'Red Potato Salad', '1', 'tbsp', 'mustard', 2
    union select 'Red Potato Salad', '1/2', 'cup', 'mayonnaise', 3
    union select 'Red Potato Salad', '2 to 3', 'tbsp', 'pickle juice', 4
    union select 'Red Potato Salad', '1', 'small', 'purple onion', 5
    union select 'Red Potato Salad', '6', null, 'scallions', 6
    union select 'Red Potato Salad', '2', null, 'sour pickles', 7
    union select 'Red Potato Salad', '2 to 3', 'sprigs', 'fresh dill', 8

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName = 'Express Doughless Knishes', MsmtAmt = '4', MsmtName = null, Ingredient = 'onions (diced)', IngSeq = 1
    union select 'Express Doughless Knishes', '1/2', 'cup', 'oil', 2
    union select 'Express Doughless Knishes', '8 ', null, 'potatoes', 3
    union select 'Express Doughless Knishes', '4', null, 'eggs', 4
    union select 'Express Doughless Knishes', '2 1/2', 'cups', 'flour', 5
    union select 'Express Doughless Knishes', '6', 'oz', 'margarine', 6
    union select 'Express Doughless Knishes', '1', 'tbsp', 'salt', 7
    union select 'Express Doughless Knishes', '1/2', 'tsp', 'black pepper', 8
    union select 'Express Doughless Knishes', ' ', null, 'sesame seeds', 9

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.MsmtName = m.MeasurementName


;
with x as(
    select RecipeName = 'Cantaloupe and Feta Salad', MsmtAmt = '18', Msmt = 'bite-sized', Ingredient = 'cantaloupe balls', IngSeq = 1
    union select 'Cantaloupe and Feta Salad', '2', 'tbsp', 'feta cheese', 2
    union select 'Cantaloupe and Feta Salad', '1/4 ', null, 'English cucumber', 3

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName = 'Basic Balsamic Dressing', MsmtAmt = '3/4', Msmt = 'cup', Ingredient = 'olive oil', IngSeq = 1
    union select 'Basic Balsamic Dressing', '1/4', 'cup', 'balsamic vinegar', 2
    union select 'Basic Balsamic Dressing', 'pinch', 'of', 'salt', 3
    union select 'Basic Balsamic Dressing', 'pinch', 'of', 'black pepper', 4

)
Insert RecipeIngredient(RecipeID, IngredientID, MeasurementID, MeasurementAmt, IngredientSequence)
select r.RecipeID, i.IngredientID, m.MeasurementID, x.MsmtAmt, x.IngSeq
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
join Measurement m
on x.Msmt = m.MeasurementName

;
with x as(
    select RecipeName ='Chocolate Chip Cookies', DirectionSequence =  1, DirectionDesc = 'First combine sugar, oil and eggs in a bowl.' 
    union select 'Chocolate Chip Cookies', 2,'Mix well.' 
    union select 'Chocolate Chip Cookies', 3, 'Add flour, vanilla sugar, baking powder and baking soda.' 
    union select 'Chocolate Chip Cookies', 4, 'Beat for 5 minutes.' 
    union select 'Chocolate Chip Cookies', 5, 'Add chocolate chips.' 
    union select 'Chocolate Chip Cookies', 6, 'Freeze for 1-2 hours.' 
    union select 'Chocolate Chip Cookies', 7, 'Roll into balls and place spread out on a cookie sheet.' 
    union select 'Chocolate Chip Cookies', 8, 'Bake on 350 for 10 min.' 
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Apple Yogurt Smoothie', DirectionSequence =  1, DirectionDesc = 'Peel the apples and dice.' 
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes.' 
    union select 'Apple Yogurt Smoothie', 3, 'Mix until smooth.' 
    union select 'Apple Yogurt Smoothie', 4, 'Add apples and ice cubes.' 
    union select 'Apple Yogurt Smoothie', 5, 'Pour into glasses.' 
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Cheese Bread' , DirectionSequence = 1, DirectionDesc = 'Slit bread every 3/4 inch.' 
    union select 'Cheese Bread', 2,'Combine all ingredients in bowl.' 
    union select 'Cheese Bread', 3, 'Fill slits with cheese mixture.' 
    union select 'Cheese Bread', 4, 'Wrap bread into a foil and bake for 30 minutes.'
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Butter Muffins', DirectionSequence =  1,  DirectionDesc = 'Cream butter with sugars' 
    union select 'Butter Muffins', 2, 'Add eggs and mix well.' 
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well.' 
    union select 'Butter Muffins', 4, 'Fill muffin pans 3/4 full and bake for 30 minutes.' 
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Meat Stew', DirectionSequence = 1, DirectionDesc = 'In a skillet, saute onion and garlic powder in oil for 10-15 minutes.' 
    union select 'Meat Stew', 2, 'Add beef stew and mix until meat is browned.' 
    union select 'Meat Stew', 3, 'In a small bowl, mix ketchup, brown sugar, and vinegar well.' 
    union select 'Meat Stew', 4, 'Cook at least 1 hour on a low flame.' 
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Meatball Bites', DirectionSequence = 1, DirectionDesc = 'In a bowl, mix the ground beef with seasoning and parsley. Mix in egg.' 
    union select 'Meatball Bites', 2, 'Roll them into bite-sized meatballs. Place them in the fridge for about 10 minutes.' 
    union select 'Meatball Bites', 3, 'In the meantime, lay out your puff pastry sheet and cut one-to-two-inch strips.' 
    union select 'Meatball Bites', 4, 'Begin taking your meatballs and wrapping the puff pastry around. Slide them onto skewers.' 
    union select 'Meatball Bites', 5, 'Repeat the process until you used up all of the puff pastry.'
    union select 'Meatball Bites', 6, 'Coat with egg wash. Then, place in the oven to bake for about 25 to 30 minutes.'
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Red Potato Salad', DirectionSequence = 1, DirectionDesc = 'Boil red potatoes whole and unpeeled until cooked through. Let cool.' 
    union select 'Red Potato Salad', 2, 'Meanwhile, mix mustard with mayonnaise and pickle juice. Finely chop onions, scallions and pickles and add to mayonnaise mixture.' 
    union select 'Red Potato Salad', 3, 'Cut potatoes in large chunks and combine with dressing.' 
    union select 'Red Potato Salad', 4, 'Refrigerate overnight for best results. Sprinkle with fresh dill immediately before serving.' 
  
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as (
    select RecipeName = 'Express Doughless Knishes', DirectionSequence = 1, DirectionDesc = 'Cook potatoes and mash well.'  
    union select 'Express Doughless Knishes', 2, 'In a separate pot, sauté onions in oil until golden.'
    union select 'Express Doughless Knishes', 3, 'Combine onions with all ingredients, mixing well.' 
    union select 'Express Doughless Knishes', 4, 'Place into a nine- x 13-inch pan. Brush with eggs and sprinkle with sesame seeds. Bake for one hour at 375 degrees Fahrenheit.'
    union select 'Express Doughless Knishes', 5, 'Cut into two-and-a-half-inch squares.' 

)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName

;
with x as(
    select RecipeName = 'Cantaloupe and Feta Salad', DirectionSequence = 1, DirectionDesc = 'Place cantaloupe balls on appetizer spoons.' 
    union select 'Cantaloupe and Feta Salad', 2, 'Sprinkle feta and cucumber over the cantaloupe.' 

)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName


;
with x as(
    select RecipeName = 'Basic Balsamic Dressing', DirectionSequence = 1, DirectionDesc= 'Whisk together all dressing ingredients in a bowl.' 
    union select 'Basic Balsamic Dressing', 2, 'Drizzle over salad.' 
)
Insert RecipeDirection (RecipeID, DirectionSequence, DirectionDesc) 
select r.RecipeID, x.DirectionSequence, x.DirectionDesc
from x
join Recipe r
on x.RecipeName = r.RecipeName


go

Insert Meal(UsersID, MealName, IsActive)
select u.UsersID, 'Breakfast Bash', 1 from Users u where u.UsersName = 'Betty101' 
union select u.UsersID, 'Favor in Flavor', 0 from Users u where u.UsersName = 'Betty101'
union select u.UsersID, 'Supper''s a Picnic', 0 from Users u where u.UsersName = 'Fay303'
union select u.UsersID, 'Lunch in the Lounge', 1 from Users u where u.UsersName = 'Betty101'
go



Insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Salad', 2
union select 'Soup', 3
union select 'Main Course', 4
union select 'Dessert', 5
go



;
with x as(
    select MealName = 'Breakfast Bash', Course = 'Main Course'
    union select 'Breakfast Bash', 'Appetizer'
    union select 'Favor in Flavor', 'Main Course'
    union select 'Favor in Flavor', 'Dessert'
    union select 'Supper''s a Picnic', 'Main Course'
    union select 'Supper''s a Picnic', 'Dessert'
    union select 'Lunch in the Lounge', 'Appetizer'
    union select 'Lunch in the Lounge', 'Salad'
)
Insert MealCourse(MealID, CourseID)
select m.MealID, c.CourseID
from x
join Meal m
on x.MealName = m.MealName
join Course c
on x.Course = c.CourseName

;
with x as(    
    select MealName = 'Breakfast Bash', Course = 'Main Course', Recipe = 'Cheese Bread', Main = 1 
    union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
    union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
    union select 'Favor in Flavor', 'Main Course', 'Meat Stew', 1
    union select 'Favor in Flavor', 'Main Course', 'Express Doughless Knishes',0
    union select 'Favor in Flavor', 'Dessert', 'Chocolate Chip Cookies', 1
    union select 'Supper''s a Picnic', 'Main Course', 'Meatball Bites', 1
    union select 'Supper''s a Picnic', 'Main Course', 'Red Potato Salad', 0
    union select 'Supper''s a Picnic', 'Dessert', 'Chocolate Chip Cookies', 1 
    union select 'Lunch in the Lounge', 'Appetizer', 'Butter Muffins', 1
    union select 'Lunch in the Lounge', 'Salad', 'Cantaloupe and Feta Salad', 1
    union select 'Lunch in the Lounge', 'Salad', 'Basic Balsamic Dressing', 0
)
Insert MealCourseRecipe(MealCourseID, RecipeID, IsMain)
select mc.MealCourseID, r.RecipeID, x.Main
from x
join Meal m
on x.MealName = m.MealName
join Course c
on x.Course = c.CourseName
join MealCourse mc
on mc.CourseId = c.CourseID
and mc.MealID = m.MealID
join Recipe r
on x.Recipe = r.RecipeName

go


Insert Cookbook(UsersID, CookbookName, Price, IsActive)
select u.UsersID, 'Treats for Two', 30, 0 from Users u where u.UsersName = 'Betty101'
union select u.UsersID, 'Supper 1-2-3', 36, 1 from Users u where u.UsersName = 'Cindy202'
union select u.UsersID, 'Salad, Salad, Salad', 25, 1 from Users u where u.UsersName = 'Fay303'
union select u.UsersID, 'Dairy Delights', 28, 0 from Users u where u.UsersName = 'Betty101'

go

;
with x as (
    select Cookbook = 'Treats for Two', Recipe = 'Chocolate Chip Cookies', RecipeSeq = 1
    union select 'Treats for Two', 'Apple Yogurt Smoothie', 2
    union select 'Treats for Two', 'Cheese Bread', 3
    union select 'Treats for Two', 'Butter Muffins', 4
    union select 'Supper 1-2-3', 'Meat Stew', 1
    union select 'Supper 1-2-3', 'Meatball Bites', 2 
    union select 'Supper 1-2-3', 'Express Doughless Knishes', 3 
    union select 'Supper 1-2-3', 'Red Potato Salad', 4
    union select 'Salad, Salad, Salad', 'Cantaloupe and Feta Salad', 1 
    union select 'Salad, Salad, Salad', 'Basic Balsamic Dressing', 2
    union select 'Salad, Salad, Salad', 'Red Potato Salad', 3
    union select 'Dairy Delights', 'Cantaloupe and Feta Salad', 1 
    union select 'Dairy Delights', 'Butter Muffins', 2 
    union select 'Dairy Delights', 'Cheese Bread', 3
)
Insert CookbookRecipe(CookbookID, RecipeID, CookbookRecipeSequence)
select c.CookBookID, r.RecipeID, x.RecipeSeq
from x
join Cookbook c
on x.Cookbook = c.CookbookName
join Recipe r
on x.Recipe = r.RecipeName


select * from recipe