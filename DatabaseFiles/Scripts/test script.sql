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



--constraint ck_Recipe_DatePublished_must_be_later_than_DateDrafted check(datediff(day, DateDrafted, DatePublished)> = 0),
--constraint ck_Recipe_DateArchived_must_be_later_than_DateDrafted check(datediff(day, DateDrafted, DateArchived) > = 0)

--same day drafted and published
;
with x as(
    select UsersName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies', Calories = 75, DateDrafted = '10/01/2005', DatePublished = '10/01/2005', DateArchived = null 
)
Insert Recipe(UsersID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UsersName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

delete recipe


-- later day drafted
;
with x as(
    select UserName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies', Calories = 75, DateDrafted = '10/01/2007', DatePublished = '12/01/2005', DateArchived = null 
)
Insert Recipe(UsersID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

-- later day published
;
with x as(
    select UserName = 'Betty101', Cuisine = 'American', RecipeName = 'ChocoChip Cookies1', Calories = 75, DateDrafted = '10/01/2004', DatePublished = '12/01/2005', DateArchived = '12/01/2004' 
)
Insert Recipe(UsersID, CuisineID, RecipeName, Calories,  DateDrafted, DatePublished, DateArchived)
select u.UsersID, c.CuisineID, x.RecipeName, x.Calories, x.DateDrafted, x.DatePublished, x.DateArchived
from x
join Users u
on x.UserName = u.UsersName
join Cuisine c 
on x.Cuisine = c.CuisineName

delete recipe

insert Recipe(UsersID, CuisineID, RecipeName, Calories)select '1', '1','test12/1/2023 10:34:55 AM',20'
insert Recipe(UsersID, CuisineID, RecipeName, Calories)select '1', '1','test12/1/2023 10:34:55 AM',20'