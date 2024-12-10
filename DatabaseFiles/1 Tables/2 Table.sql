-- SM Excellent! 100% See comment, no need to resubmit. 
Use HeartyHearthDB
go

drop table if exists CookbookRecipe
drop table if exists Cookbook
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Course
drop table if exists Meal
drop table if exists RecipeDirection
drop table if exists RecipeIngredient
drop table if exists Measurement
drop table if exists Ingredient
drop table if exists Recipe
drop table if exists Cuisine
drop table if exists Users


create table dbo.Users(
    UsersId int not null identity primary key,
    UsersName varchar(25) not null    
        constraint Users_name unique
        constraint ck_Users_Usersname_cannot_be_blank check(UsersName <> ''),   
    FirstName varchar(30) not null constraint ck_Users_first_name_cannot_be_blank check(FirstName <> ''),
    LastName varchar (30) not null constraint ck_Users_last_name_cannot_be_blank check(LastName <> '')
)
go

create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineName varchar(50) not null 
        constraint u_Cuisine_CuisineName unique
        constraint ck_Cuisine_CuisineName_cannot_be_blank check(CuisineName <>'')
)
go

create table dbo.Ingredient( 
    IngredientId int not null identity primary key,
    IngredientName varchar(50) not null
        constraint ck_Ingredient_name_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_Name unique,
   IngredientImage as concat('ingredient_', replace(IngredientName, ' ', '_'), '.jpg')
)
go

create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementName varchar(25) not null
        constraint ck_Measurement_MeasurementName_cannot_be_blank check(MeasurementName <> '') 
        constraint u_Measurement_MeasurementName unique 
        
)
go

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    UsersId int not null constraint f_Users_Recipe foreign key references Users(UsersId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(100) not null
        constraint u_RecipeName unique
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> ''),
    Calories int not null
        constraint ck_Recipe_Calories_must_be_greater_than_zero check(Calories > 0),
    DateDrafted datetime not null default getdate()
		constraint ck_Recipe_date_drafted_cannot_be_future_date check(getdate()>= DateDrafted),
	DatePublished datetime null
		constraint ck_Recipe_date_published_cannot_be_future_date check(getdate()>= DatePublished),
    DateArchived datetime null
		constraint ck_Recipe_date_archived_cannot_be_future_date check(getdate()>= DateArchived),
    constraint ck_Recipe_dates_must_progress_sequentially check (DatePublished between DateDrafted and DateArchived),
	constraint ck_Recipe_date_archived_must_be_after_date_drafted check(DateArchived>= DateDrafted),
	RecipeImage as concat('recipe_', lower(replace(RecipeName, ' ', '')), '.jpg'),
    RecipeStatus as case
      when DateArchived is not null then 'Archived'
		 else case 
				when DatePublished is  not null  then 'Published'
				else 'Drafted'
				end
		end
)
go

alter table recipe add Vegan bit not null default 0;
go

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredients foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredients foreign key references Ingredient(IngredientId),
    MeasurementId int null constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId), 
    MeasurementAmt decimal (4,2) null,
	IngredientSequence int not null 
        constraint ck_RecipeIngredient_IngredientSequence_must_be_greater_than_zero check(IngredientSequence > 0),
    constraint u_RecipeIngredient_Recipe_IngredientSequence unique(RecipeId, IngredientSequence)    
)
go

create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeDirections foreign key references Recipe(RecipeId),
    DirectionSequence int not null 
        constraint ck_RecipeDirections_Sequence_must_be_greater_than_zero check(DirectionSequence > 0),
    DirectionDesc varchar(200) not null 
        constraint ck_RecipeDirections_description_cannot_be_blank check(DirectionDesc <> ''),
    constraint u_RecipeDirections_Recipe_sequence unique(RecipeId, DirectionSequence)
)
go

create table dbo.Meal(
    MealId int not null identity primary key,
    UsersId int not null constraint f_Users_Meal foreign key references Users(UsersId),
    MealName varchar(100) 
        constraint u_Meal_MealName unique
        constraint ck_Meal_MealName_cannot_be_blank check(MealName <> ''),
    DateCreated date not null default getdate()
        constraint ck_Meal_DateCreated_cannot_be_future_date check(DateCreated<= getdate()),
    IsActive bit not null default 1, 
    MealImage as concat('meal_', replace(MealName, ' ', '_'), '.jpg')
)
go

Create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(35) not null 
        constraint u_Course_CourseName unique
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> ''),
    CourseSequence int not null
        constraint ck_Course_CourseSequence_must_be_greater_than_zero check(CourseSequence> 0)
        constraint u_Course_CourseSequence unique
)
go

Create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),   
    constraint u_Meal_Course unique(MealId, CourseId)
)
go

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    IsMain bit not null default 1,
    constraint u_MealCourseRecipe_MealCourse_Recipe unique(MealCourseId, RecipeId) 
)
go

create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UsersId int not null constraint f_Users_Cookbook foreign key references Users(UsersId),
    CookbookName varchar(100) not null 
        constraint u_Cookbook_Name unique
        constraint ck_Cookbook_Name_cannot_be_blank check(CookbookName <> ''),
    Price decimal(5,2) not null,
    DateCreated date not null default getdate()
        constraint ck_Cookbook_DateCreated_cannot_be_future_date check(DateCreated <= getdate()),
    IsActive bit not null default 1,
    CookbookImage as concat('cookbook_', replace(CookbookName, ' ', '_'), '.jpg')
)
go
alter table cookbook add CookbookSkill int not null default 1;
go

create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    CookbookRecipeSequence int not null 
        constraint ck_CookbookRecipe_Sequence_must_be_greater_than_zero check(CookbookRecipeSequence > 0),
    constraint u_CookbookRecipe_Cookbook_Sequence unique(CookbookId, CookbookRecipeSequence),
    constraint u_Cookbook_Recipe unique(CookbookId, RecipeId)
)
go






    
