-- SM Excellent sketch! I think you can start creating database, see comments below.
/*
-- SM Image should be on each table as a computed column, not a separate table.


User
    UserID primary key
    UserName varchar(25) unique
    FirstName varchar(30)
    LastName varchar (30)

Cuisine 
    CuisineID primary key
    CuisineName varchar(50) unique

Ingredient 
    IngredientID primary key
    ImageID(fk Image)
    IngredientName varchar(50) unique
    
-- SM No need for this table
Status
    StatusID primary key
    StatusName varchar(10) unique

Measurement
    MeasurementID primary key
    MeasurementName varchar(25) unique

-- SM In recipe table, add datetime columns for date drafted, published, archived. And add computed column that returns status by checking which date/s is null
Recipe
    ImageID (fk Image)
    UserID (fk User)
    CuisineID (fk Cuisine)
    RecipeName varchar(100) unique
    Calories int

RecipeIngredients 
    RecipeIngredientsID primary key
    RecipeID (fk Recipe)
    IngredientID (fk Ingredient)
-- SM Should be unique to recipe, not to table
    IngredientSequence int unique
    Measurement ID (fk Measurement)  
    MeasurementAmt int
          
RecipeDirections
    RecipeDirectionsID primary key
    RecipeID (fk Recipe)
-- SM Should be unique to recipe, not to table
    Sequence int unique
    DirectionDesc varchar(200)

-- SM No need for this table
RecipeStatus
    RecipeStatusID primary key
    RecipeID (fk Recipe)
    StatusID (fk Status)
    DateRecorded datetime

Meal
    MealID primary key
    ImageID (fk Image)
    UserID (fk User)
    MealName varchar(100) unique
    DateCreated datetime
    IsActive bit 
    
Course
    CourseID primary key
    CourseName varchar(35) unique

MealCourse
    MealCourseID primary key
    MealID (fk Meal)
    CourseId (fk Course)
-- SM Should be unique to meal/course not to table
    CourseSequence int unique
    MealID, CourseID unique

MealCourseRecipes
    MealCourseRecipeID primary key
    MealCourseId (fk MealCourse)
    RecipeID (fk Recipe)
    MainDish bit

Cookbook
    ImageID (fk Image)
    UserID (fk User)
    CookbookName varchar(100) unique
    Price decimal(5,2)
    DateCreated date
    IsActive bit

CookbookRecipe
    CookbookRecipeID primary key
    CookbookID (fk Cookbook)
    RecipeID (fk Recipe)
    CookbookRecipeSequence int unique
    CookbookID, RecipeID unique

    
