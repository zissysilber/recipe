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
    UserID int not null identity primary key,
    UserName varchar(25) not null    
        constraint User_name unique
        constraint ck_Users_Username_cannot_be_blank check(UserName <> ''),   
    FirstName varchar(30) not null constraint ck_Users_first_name_cannot_be_blank check(FirstName <> ''),
    LastName varchar (30) not null constraint ck_Users_last_name_cannot_be_blank check(LastName <> '')
)
go

create table dbo.Cuisine(
    CuisineID int not null identity primary key,
    CuisineName varchar(50) not null 
        constraint u_Cuisine_CuisineName unique
        constraint ck_Cuisine_CuisineName_cannot_be_blank check(CuisineName <>'')
)
go

create table dbo.Ingredient( 
    IngredientID int not null identity primary key,
    IngredientName varchar(50) not null
        constraint ck_Ingredient_name_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_Name unique,
   IngredientImage as concat('ingredient_', replace(IngredientName, ' ', '_'), '.jpg')
)
go

create table dbo.Measurement(
    MeasurementID int not null identity primary key,
    MeasurementName varchar(25) not null
        constraint ck_Measurement_MeasurementName_cannot_be_blank check(MeasurementName <> '') 
        constraint u_Measurement_MeasurementName unique 
        
)
go

create table dbo.Recipe(
    RecipeID int not null identity primary key,
    UserID int not null constraint fk_Users_Recipe foreign key references Users(UserID),
    CuisineID int not null constraint fk_Cuisine_Recipe foreign key references Cuisine(CuisineID),
    RecipeName varchar(100) not null
        constraint u_RecipeName unique
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName <> ''),
    Calories int not null
        constraint ck_Recipe_Calories_must_be_greater_than_zero check(Calories > 0),
    DateDrafted datetime not null default getdate()
        constraint ck_Recipe_date_drafted_cannot_be_future_date check(DateDrafted<= getdate()),
        --constraint ck_Recipe_date_drafted_cannot_be_after_date_published check(DatePublished >= DateDrafted),
    DatePublished datetime null
        constraint ck_Recipe_date_published_cannot_be_future_date check(DatePublished<= getdate()),
    DateArchived datetime null
            constraint ck_Recipe_date_archived_cannot_be_future_date check(DateArchived<= getdate()),
    RecipeImage as concat('recipe_', replace(RecipeName, ' ', '_'), '.jpg'),
    RecipeStatus as case
        when (DateArchived is null or DatePublished > DateArchived)  and DatePublished >= DateDrafted then 'Published'
        when (DatePublished is null or DateArchived >= DatePublished) and DateArchived >=  DateDrafted then 'Archived'
        else 'Drafted'
     end
)


create table dbo.RecipeIngredient(
    RecipeIngredientID int not null identity primary key,
    RecipeID int not null constraint fk_Recipe_RecipeIngredients foreign key references Recipe(RecipeID),
    IngredientID int not null constraint fk_Ingredient_RecipeIngredients foreign key references Ingredient(IngredientID),
    MeasurementID int null constraint fk_Measurement_RecipeIngredient foreign key references Measurement(MeasurementID), 
    MeasurementAmt varchar(10) not null,
    IngredientSequence int not null 
        constraint ck_RecipeIngredient_IngredientSequence_must_be_greater_than_zero check(IngredientSequence > 0),
    constraint u_RecipeIngredient_Recipe_IngredientSequence unique(RecipeID, IngredientSequence)    
)
go

create table dbo.RecipeDirection(
    RecipeDirectionID int not null identity primary key,
    RecipeID int not null constraint fk_RecipeDirections_Recipe foreign key references Recipe(RecipeID),
    DirectionSequence int not null 
        constraint ck_RecipeDirections_Sequence_must_be_greater_than_zero check(DirectionSequence > 0),
    DirectionDesc varchar(200) not null 
        constraint ck_RecipeDirections_description_cannot_be_blank check(DirectionDesc <> ''),
    constraint u_RecipeDirections_Recipe_sequence unique(RecipeID, DirectionSequence)
)
go

create table dbo.Meal(
    MealID int not null identity primary key,
    UserID int not null constraint fk_Meal_User foreign key references Users(UserID),
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
    CourseID int not null identity primary key,
    CourseName varchar(35) not null 
        constraint u_Course_CourseName unique
        constraint ck_Course_CourseName_cannot_be_blank check(CourseName <> ''),
    CourseSequence int not null
        constraint ck_Course_CourseSequence_must_be_greater_than_zero check(CourseSequence> 0)
        constraint u_Course_CourseSequence unique
)
go

Create table dbo.MealCourse(
    MealCourseID int not null identity primary key,
    MealID int not null constraint fk_MealCourse_Meal foreign key references Meal(MealID),
    CourseID int not null constraint fk_MealCourse_Course foreign key references Course(CourseID),   
    constraint u_Meal_Course unique(MealID, CourseID)
)
go

create table dbo.MealCourseRecipe(
    MealCourseRecipeID int not null identity primary key,
    MealCourseID int not null constraint fk_MealCourseRecipe_MealCourse foreign key references MealCourse(MealCourseID),
    RecipeID int not null constraint fk_MealCourseRecipe_Recipe foreign key references Recipe(RecipeID),
    IsMain bit not null default 1,
    constraint u_MealCourseRecipe_MealCourse_Recipe unique(MealCourseID, RecipeID) 
)
go

create table dbo.Cookbook(
    CookbookID int not null identity primary key,
    UserID int not null constraint fk_Cookbook_Users foreign key references Users(UserID),
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

create table dbo.CookbookRecipe(
    CookbookRecipeID int not null identity primary key,
    CookbookID int not null constraint fk_CookbookRecipe_Cookbook foreign key references Cookbook(CookbookID),
    RecipeID int not null constraint fk_CookbookRecipe_Recipe foreign key references Recipe(RecipeID),
    CookbookRecipeSequence int not null 
        constraint ck_CookbookRecipe_Sequence_must_be_greater_than_zero check(CookbookRecipeSequence > 0),
    constraint u_CookbookRecipe_Cookbook_Sequence unique(CookbookID, CookbookRecipeSequence),
    constraint u_Cookbook_Recipe unique(CookbookID, RecipeID)
)
go






    
