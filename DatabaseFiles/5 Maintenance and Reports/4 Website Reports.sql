-- SM Excellent work! 100% See comments, no need to resubmit 
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
The way the website works is that a list of items are displayed and then the Users picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.

Home Page
    One resultset with number of recipes, meals, and cookbooks
*/
select TotalRecipes = count(distinct r.RecipeId), TotalMeals = count(distinct m.MealId), TotalCookbooks = count(distinct c.CookbookId) 
from recipe r
cross join Cookbook c
cross join Meal m


/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived (blank if not archived), Users, number of calories and number of ingredients.
*/
select RecipeName = 
    case
        when r.RecipeStatus = 'Archived' then concat('<span style="color:gray">', r.RecipeName, '</span>')
        else r.RecipeName
        end,
    r.RecipeStatus, 
    DatePublished = isnull(convert(varchar, r.DatePublished, 21),''), 
    DateArchived = isnull(convert(varchar, r.DateArchived, 21),''), 
    u.UsersName, 
    r.Calories, 
    TotalIngredients = count(ri.IngredientId)
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Users u
on r.UsersId = u.UsersId
where r.RecipeStatus in ('Published', 'Archived')
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived, u.UsersName, r.Calories
order by r.RecipeStatus desc, r.RecipeName




/*
Recipe details page:
    Show for a specific recipe (three result sets):      
*/        
--a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
select r.RecipeName, r.Calories, NumberOfIngredients = count(distinct ri.RecipeIngredientId), NumberofDirections = count(distinct rd.DirectionSequence), r.RecipeImage
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.recipeId
join RecipeDirection rd
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Butter Muffins'
group by r.RecipeName, r.Calories, r.RecipeImage

--b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
select Ingredient = concat(ri.MeasurementAmt, 
                            case when m.MeasurementName is not null then concat(' ', m.MeasurementName) 
-- SM No need for else, concat() ignores null. And you really wont need the concat(' ', m.MeasurementName), you'll only need ' ', and adding measurement name after case, but the way you dId is probably better.
                                else '' 
                                end, 
                            ' ',
                            i.IngredientName), 
                            i.IngredientImage
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
left join Measurement m
on ri.MeasurementId = m.MeasurementId
join Ingredient i
on ri.IngredientId = i.IngredientId
where r.RecipeName = 'Butter Muffins'
order by ri.IngredientSequence

--c) List of prep steps sorted by sequence.
select rd.DirectionDesc
from RecipeDirection rd
join Recipe r
on rd.RecipeId = r.RecipeId
where r.RecipeName = 'Butter Muffins'
order by rd.DirectionSequence
/*



Meal list page:
    All active meals, meal name, Users that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, u.UsersName, MealCalories = sum(r.Calories), TotalCourses = count(distinct mc.MealCourseId), TotalRecipes = count(mr.RecipeId), m.MealImage
from Meal m
join Users u
on m.UsersId = u.UsersId
join MealCourse mc
on m.MealId = mc.MealId
join MealCourseRecipe mr
on mc.MealCourseId = mr.MealCourseId
join Recipe r
on mr.RecipeId = r.RecipeId
where m.IsActive = 1
group by m.MealName, u.UsersName, m.MealImage
order by m.MealName


/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, Users, date created.

*/
select m.MealName, u.FirstName, u.LastName, m.DateCreated, m.MealImage
from Meal m
join Users u
on m.UsersId = u.UsersId
where m.MealName = 'Breakfast Bash'

/*
        b) List of all recipes. 
            Display in one column the course type, recipe, and for the main course show which dish is the main and which are sIde. 
			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select  MealRecipe =   
        case C.CourseName
            when 'Main Course' then
                    case mr.IsMain 
                        when 1 then concat('<b>Main: Main dish - ', r.RecipeName, '</b>')
                        else concat('Main: Side dish - ', r.RecipeName) 
                    end
            else concat(c.CourseName, ': ', r.RecipeName)
        end, 
        r.RecipeImage
from MealCourseRecipe mr
join MealCourse mc
on mr.MealCourseId = mc.MealCourseId
join Course c
on mc.CourseId = c.CourseId
join Recipe r
on mr.RecipeId = r.RecipeId
join Meal m
on mc.MealId = m.MealId
where m.MealName = 'Breakfast Bash'



/*

Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, u.FirstName, u.LastName,  TotalRecipes = count(cr.RecipeId), c.CookbookImage 
from Cookbook c
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
join Users u
on c.UsersId = u.UsersId
where c.IsActive = 1
group by c.CookbookName, u.FirstName, u.LastName, c.CookbookImage
order by c.CookbookName


--Cookbook details page:
--Show for specific cookbook:

--a) Cookbook header: cookbook name, Users, date created, price, number of recipes.
select c.CookbookName, u.UsersName, c.DateCreated, c.Price, TotalRecipes = count(cr.RecipeId), c.CookbookImage 
from Cookbook c
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
join Users u
on c.UsersId = u.UsersId
where c.CookbookName = 'Supper 1-2-3'
group by c.CookbookName, u.UsersName, c.DateCreated, c.Price, c.CookbookImage

--b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: Users will click on recipe to see all ingredients and steps.
select r.RecipeName, s.CuisineName, TotalIng = count(distinct ri.RecipeIngredientId), TotalDirections = count(distinct rd.RecipeDirectionId), r.RecipeImage
from Cookbook c
join CookbookRecipe cr
on c.CookbookId = cr.CookbookId
join Users u
on c.UsersId = u.UsersId
join Recipe r
on cr.RecipeId = r.RecipeId
join Cuisine s
on r.CuisineId = s.CuisineId
join RecipeIngredient ri
on r.RecipeId  = ri.RecipeId
join RecipeDirection rd
on r.RecipeId = rd.RecipeId
where c.CookbookName = 'Supper 1-2-3'
group by r.RecipeName, s.CuisineName, cr.CookbookRecipeSequence, r.RecipeImage
order by cr.CookbookRecipeSequence


--April Fools Page:
    --On April 1st we have a page with a joke cookbook. For that page provide the following.
    --a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.

    select RecipeName = concat(substring(upper(reverse(r.RecipeName)), 1, 1), substring(lower(reverse(r.RecipeName)), 2, len(r.RecipeName))),
        Images = concat(
        'recipe_', 
        substring(upper(reverse(r.RecipeName)), 1, 1), replace(substring(lower(reverse(r.RecipeName)), 2, len(r.RecipeName)), ' ', '_'), '.jpg'
        )   
    from CookbookRecipe cr
    join cookbook c
    on cr.CookbookId = c.CookbookId
    join Recipe r
    on cr.RecipeId = r.RecipeId

--b) When the Users clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system
;
with x as(
    select  FirstIngredient = min(ri.IngredientSequence),  RecipeDirectionId = rd.RecipeId, HighestInstruction = max(rd.DirectionSequence)
    from Recipe r
    join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    join RecipeDirection rd
    on r.RecipeId = rd.RecipeId
    group by rd.RecipeId
)
select  RecipeName = concat(substring(upper(reverse(r.RecipeName)), 1, 1), substring(lower(reverse(r.RecipeName)), 2, 1000)),
        IngredientList = concat(ri.MeasurementAmt, 
                                case when m.MeasurementName is not null then concat(' ', m.MeasurementName) 
                                else '' 
                                end, 
                                ' ', 
                                i.IngredientName),
         rd.DirectionDesc
from RecipeDirection rd
join x
on rd.RecipeId = x.RecipeDirectionId and x.HighestInstruction = rd.DirectionSequence
join RecipeIngredient ri
on rd.RecipeId = ri.RecipeId and x.FirstIngredient = ri.IngredientSequence
left join Measurement m
on ri.MeasurementId = m.MeasurementId
join Ingredient i
on ri.IngredientId = i.IngredientId
cross join Recipe r
where r.RecipeName = 'Chocolate Chip Cookies'




--For site administration page: 5 separate reports

--a) List of how many recipes each Users created per status. Show 0 if none
select u.FirstName, u.LastName, TotalDrafted = count(r.DateDrafted), TotalPublished = count(r.DatePublished), TotalArchived = count(r.DateArchived)
from Users u
left join Recipe r
on r.UsersId = u.UsersId
group by u.FirstName, u.LastName



--b) List of how many recipes each Users created and average amount of days that it took for the Users's recipes to be published.
select FirstName = u.FirstName, LastName = u.LastName, TotalDrafted = count(r.DateDrafted), AvgDaysToPublish = avg(datediff(day, r.DateDrafted, r.DatePublished))
from Users u
left join Recipe r
on r.UsersId = u.UsersId
group by u.FirstName, u.LastName
having count(r.DateDrafted) > 0



--c) List of how many meals each Users created and whether they're active or inactive. Show 0 if none
select  u.FirstName, u.LastName, TotalMealsCreated = count(m.UsersId), 
        IsActive = case m.IsActive 
            when 1 then 'Active' 
            when 0 then 'Inactive'
            else 'N/A'
            end
from Users u
left join Meal m
on m.UsersId = u.UsersId
group by u.FirstName, u.LastName, m.IsActive

--d) List of how many cookbooks each Users created and whether they're active or inactive. Show 0 if none
select u.FirstName, u.LastName, TotalCookbooks = count(c.UsersId), 
        IsActive = case c.IsActive
            when 1 then 'Active' 
            when 0 then 'Inactive'
            else 'N/A'
            end
from Users u
left join Cookbook c
on c.UsersId = u.UsersId
group by u.FirstName, u.LastName, c.IsActive

--e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, DraftToArchiveDays = datediff(day, r.DateDrafted, r.DateArchived)
from Recipe r
where r.RecipeStatus = 'Archived'
and r.DatePublished is null


--For Users dashboard page:

--a) Show number of the Users's recipes, meals and cookbooks. 
select u.FirstName, u.LastName, TotalRecipes = count(distinct r.RecipeId), TotalMeals = count( distinct m.MealId), TotalCookbook = count(distinct c.CookbookId)
from Users u
left join Recipe r
on u.UsersId = r.UsersId
left join Meal m
on U.UsersId = m.UsersId
left join Cookbook c
on u.UsersId = c.UsersId
where u.UsersName = 'Betty101'
group by u.FirstName, u.LastName



--b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.

-- SM Remove extra columns, and only show Users that have recipes.

--This sql for seeing all Users and any recipes they may have
select distinct 
    u.FirstName, u.LastName, r.RecipeName, r.RecipeStatus, r.DateDrafted, r.DatePublished, r.DateArchived,
    HoursTimeLapse = case 
            when r. RecipeStatus in ( 'Published', 'Archived')
             then  
            datediff(hour, 
            case  
                when r.DatePublished is not null then 
                    case 
                        when r.DatePublished < r.DateArchived then r.DatePublished 
                        else r.DateDrafted 
                    end 
                else r.DateDrafted
            end,
            case r.RecipeStatus 
                when 'Published' then r.DatePublished 
                else r.DateArchived 
            end) 
            end
from Users u
left join Recipe r
on u.UsersId = r.UsersId



--c) Count of their recipes per cuisine. Show 0 for none.


select U.UsersName, c.CuisineName, TotalRecipes = count(r.UsersId)
from Cuisine c
cross join Users u
left join Recipe r
on c.CuisineId = r.CuisineId and u.UsersId = r.UsersId
group by U.UsersName, c.CuisineName
order by u.UsersName


 


