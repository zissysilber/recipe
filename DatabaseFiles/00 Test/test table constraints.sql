--test script



--Users
--blanks, duplicates
Insert Users(UsersName, FirstName, LastName)
select 'Betty101',  'Betty', 'Baker'

Insert Users(UsersName, FirstName, LastName)
select 'Betty102',  '', 'Baker'

Insert Users(UsersName, FirstName, LastName)
select 'Betty102', 'Betty', ''

--Cuisine
Insert Cuisine(CuisineName)
select ''

Insert Cuisine(CuisineName)
select 'English'




--same day drafted and published

--Test Scripts

--same day
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea', Calories = 5, DateDrafted = '10/01/2005', DatePublished = '10/02/2005', DateArchived = '10/03/2005' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies1', Calories = 75, DateDrafted = '10/01/2005', DatePublished = '10/01/2005', DateArchived = null 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

delete recipe


-- later day drafted
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies', Calories = 75, DateDrafted = '10/01/2007', DatePublished = '12/01/2005', DateArchived = null 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

-- later day published
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies1', Calories = 75, DateDrafted = '10/01/2004', DatePublished = '12/01/2005', DateArchived = '12/01/2004' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

delete recipe

--future date drafted
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea1', Calories = 5, DateDrafted = '10/01/2025', DatePublished = '10/02/2005', DateArchived = '10/03/2005' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

--future date published
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea2', Calories = 5, DateDrafted = '10/01/2005', DatePublished = '10/02/2025', DateArchived = '10/03/2025' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName


--future date archived
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea2', Calories = 5, DateDrafted = '10/01/2005', DatePublished = '10/02/2005', DateArchived = '10/03/2025' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName


--date published before drafed
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea2', Calories = 5, DateDrafted = '10/01/2005', DatePublished = '09/02/2005', DateArchived = '10/03/2005' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName


--test date archived before published
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea2', Calories = 5, DateDrafted = '10/01/2005', DatePublished = '09/02/2005', DateArchived = '08/03/2005' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

--with null values for date published

;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea2', Calories = 5, DateDrafted = '10/01/2005', DatePublished = null, DateArchived = '10/03/2005' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

--with null values for date archived

;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea3', Calories = 5, DateDrafted = '10/01/2005', DatePublished = null, DateArchived = null 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

--test null published date archived before drafted
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'Hot Tea3', Calories = 5, DateDrafted = '10/01/2005', DatePublished = null, DateArchived = '12/03/2005' 
)
Insert Recipe(UsersId, CuisineId, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersId, c.CuisineId, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName