use HeartyHearthDB
go

;
with x as(
    select UserName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Chocolate', Calories = 75, DateDrafted = '10/01/2005', DatePublished = '12/01/2005', DateArchived = null 
    union select 'Betty101', 'French', 'Flavorful Tea', 120,  '10/01/2006', null, '12/01/2006'
    union select 'Cindy202', 'American', 'Lovely Lemonade', 150,  '05/05/2005', null, '07/07/2005' 
    union select 'Cindy202', 'Hungarian', 'Peanut Butter Smoothie', 150,  '09/09/2009', '10/10/2010', null 
    union select 'Fay303', 'French', 'Warm Cinnamon Milk', 175,  '10/01/2020', '12/01/2020', '12/01/2021'

)
Insert Recipe(UserID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UserID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UserName
join Cuisine c 
on x.Cuisine = c.CuisineName

select * from Recipe
select * from Users







