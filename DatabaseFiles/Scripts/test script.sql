--test script



--Users
--blanks, duplicates
Insert Users(UserName, FirstName, LastName)
select 'Betty101',  'Betty', 'Baker'

Insert Users(UserName, FirstName, LastName)
select 'Betty102',  '', 'Baker'

Insert Users(UserName, FirstName, LastName)
select 'Betty102', 'Betty', ''

--Cuisine
Insert Cuisine(CuisineName)
select ''

Insert Cuisine(CuisineName)
select 'English'



--constraint ck_Recipe_DatePublished_must_be_later_than_DateDrafted check(datediff(day, DateDrafted, DatePublished)> = 0),
--constraint ck_Recipe_DateArchived_must_be_later_than_DateDrafted check(datediff(day, DateDrafted, DateArchived) > = 0)

--same day drafted and published
;
with x as(
    select UserName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies', Calories = 75, DateDrafted = '10/01/2005', DatePublished = '10/01/2005', DateArchived = null 
)
Insert Recipe(UserID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UserID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UserName
join Cuisine c 
on x.Cuisine = c.CuisineName

delete recipe


-- later day drafted
;
with x as(
    select UserName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies', Calories = 75, DateDrafted = '10/01/2006', DatePublished = '12/01/2005', DateArchived = null 
)
Insert Recipe(UserID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UserID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UserName
join Cuisine c 
on x.Cuisine = c.CuisineName

delete recipe