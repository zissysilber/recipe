-- SM Excellent sketch! I think you can start creating database, see comments below.
/*
-- SM Image should be on each table as a computed column, not a separate table.


User
    UserId primary key
    UserName varchar(25) unique
    FirstName varchar(30)
    LastName varchar (30)

Cuisine 
    CuisineId primary key
    CuisineName varchar(50) unique

Ingredient 
    IngredientId primary key
    ImageId(fk Image)
    IngredientName varchar(50) unique
    
-- SM No need for this table
Status
    StatusId primary key
    StatusName varchar(10) unique

Measurement
    MeasurementId primary key
    MeasurementName varchar(25) unique

-- SM In recipe table, add datetime columns for date drafted, published, archived. And add computed column that returns status by checking which date/s is null
Recipe
    ImageId (fk Image)
    UserId (fk User)
    CuisineId (fk Cuisine)
    RecipeName varchar(100) unique
    Calories int

RecipeIngredients 
    RecipeIngredientsId primary key
    RecipeId (fk Recipe)
    IngredientId (fk Ingredient)
-- SM Should be unique to recipe, not to table
    IngredientSequence int unique
    Measurement Id (fk Measurement)  
    MeasurementAmt int
          
RecipeDirections
    RecipeDirectionsId primary key
    RecipeId (fk Recipe)
-- SM Should be unique to recipe, not to table
    Sequence int unique
    DirectionDesc varchar(200)

-- SM No need for this table
RecipeStatus
    RecipeStatusId primary key
    RecipeId (fk Recipe)
    StatusId (fk Status)
    DateRecorded datetime

Meal
    MealId primary key
    ImageId (fk Image)
    UserId (fk User)
    MealName varchar(100) unique
    DateCreated datetime
    IsActive bit 
    
Course
    CourseId primary key
    CourseName varchar(35) unique

MealCourse
    MealCourseId primary key
    MealId (fk Meal)
    CourseId (fk Course)
-- SM Should be unique to meal/course not to table
    CourseSequence int unique
    MealId, CourseId unique

MealCourseRecipes
    MealCourseRecipeId primary key
    MealCourseId (fk MealCourse)
    RecipeId (fk Recipe)
    MainDish bit

Cookbook
    ImageId (fk Image)
    UserId (fk User)
    CookbookName varchar(100) unique
    Price decimal(5,2)
    DateCreated date
    IsActive bit

CookbookRecipe
    CookbookRecipeId primary key
    CookbookId (fk Cookbook)
    RecipeId (fk Recipe)
    CookbookRecipeSequence int unique
    CookbookId, RecipeId unique

    
