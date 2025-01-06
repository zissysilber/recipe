using NUnit.Framework.Constraints;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RecipeAppsTest
{
    public class Tests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        //for hmwk submissions
        //string connstring = ConfigurationManager.ConnectionStrings["hmwkunittestconn"].ConnectionString;
        //string testconnstring = ConfigurationManager.ConnectionStrings["hmwkunittestconn"].ConnectionString;


        [SetUp]
        public void Setup()
        {

            DBManager.SetConnectionString(connstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            DBManager.SetConnectionString(testconnstring, false);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, false);
            return dt;
        }

        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            DBManager.SetConnectionString(testconnstring, false);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, false);
            return n;
        }

        private string GetFirstColumnFirstRowString(string sql)
        {
            string s = "";
            DBManager.SetConnectionString(testconnstring, false);
            s = SQLUtility.GetFirstColumnFirstRowString(sql);
            DBManager.SetConnectionString(connstring, false);
            return s;
        }

        private void ExecuteSQL(string sql)
        {
            DBManager.SetConnectionString(testconnstring, false);
            ExecuteSQL(sql);
            DBManager.SetConnectionString(connstring, false);
        }

        //[Test]
        //public void SearchRecipes()
        //{
        //    string recipename = GetFirstColumnFirstRowString("select top 1 recipename from recipe");
        //    recipename = recipename.Substring(0, 1);
        //    Assume.That(recipename is not null, "No recipe in DB, can't run test");
        //    TestContext.WriteLine("search for recipename that contains (" + recipename + ")");
        //    TestContext.WriteLine("ensure that app returns recipe with name that contains (" + recipename + ")");


        //    DataTable dt = Recipe.SearchRecipeByName(recipename);

        //    Assume.That(dt.Rows.Count > 0, "no recipes found, can't run test");
        //    string foundrecipename = dt.Rows[0]["recipename"].ToString();
        //    Assert.IsTrue(dt.Rows.Count > 0, "no recipename in DB that contains (" + recipename + ")");
        //    TestContext.WriteLine("found recipename (" + foundrecipename + ") that contains (" + recipename + ")");
        //}

        [Test]
        public void GetListOfRecipes()
        {
            int recipecount = GetFirstColumnFirstRowValue("select total = count (*) from recipe");
            Assume.That(recipecount > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe recipe = new();
            var lst = recipe.GetList();
            Assert.That(lst.Count == recipecount, "num rows returned by app (" + lst.Count + ") <>" + recipecount);
            //Assert.IsTrue();
            TestContext.WriteLine("Number of rows in Recipe returned by app = " + lst.Count);

        }


        [Test]
        public void SearchRecipeByCuisine()
        {
            string cuisinename = "American";  // Cuisine to search for

            int cuisinecount = GetFirstColumnFirstRowValue($"SELECT COUNT(DISTINCT r.RecipeId) FROM Recipe r JOIN Cuisine c ON r.CuisineId = c.CuisineId WHERE c.CuisineName LIKE '%{cuisinename}%'");

            TestContext.WriteLine("Number of search results in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that the number of rows returned by the app matches the expected count (" + cuisinecount + ")");

           
            bizRecipe recipe = new();
            var lst = recipe.SearchByCuisine(cuisinename);

                        Assert.That(lst.Count, Is.EqualTo(cuisinecount),
                        $"Number of rows returned by app ({lst.Count}) does not match DB count ({cuisinecount})");

            TestContext.WriteLine("Number of rows in Recipe returned by app = " + lst.Count);
        }
    }
}
    /*
        [Test]
        public void GetListOfIngredients()
        {
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count (*) from Ingredient");
            Assume.That(ingredientcount > 0, "No ingredients in DB, can't test");
            TestContext.WriteLine("Num of ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizRecipeIngredient ingredient = new();
            var lst = ingredient.GetList(false);

            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app (" + lst.Count + ") <>" + ingredientcount);
            TestContext.WriteLine("Number of rows in Ingredient returned by app = " + lst.Count);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = (" + recipeid + ")");
            TestContext.WriteLine("Ensure that app loads recipe (" + recipeid + ")");

            bizRecipe recipe = new();
            recipe.Load(recipeid);

            int loadedid = recipe.RecipeId;
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + recipeid + ")");
        }

        [Test]
        public void SearchRecipe() {
            string recipename = "a";
            int recipecount = GetFirstColumnFirstRowValue($"select total = count(*) from recipe where recipename like '%{recipename}%'");
            TestContext.WriteLine("Num of search results in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + recipecount);

            bizRecipe recipe = new();
            var lst = recipe.Search(recipename);

            Assert.IsTrue(lst.Count == recipecount, "num of rows returned by app (" + lst.Count + ") <>" + recipecount);
            TestContext.WriteLine("Number of rows in Recipe returned by app = " + lst.Count);
        }

        [Test]
        public void SearchIngredient()
        {
            string ingredientname = "ch";
            int ingredientcount = GetFirstColumnFirstRowValue($"select total = count(*) from ingredient where ingredientname like '%{ingredientname}%'");
            TestContext.WriteLine("Num of search results in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + ingredientcount);

            bizRecipeIngredient ing = new();
            var lst = ing.Search(ingredientname);

            Assert.IsTrue(lst.Count == ingredientcount, "num of rows returned by app (" + lst.Count + ") <>" + ingredientcount);
            TestContext.WriteLine("Number of rows in Ingredient returned by app = " + lst.Count);
        }

        [Test]
        public void InsertNewRecipe()
        {
                        int cuisineid = GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "can't run test, no cuisine in DB");
            int userid = GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(userid > 0, "can't run test, no users in DB");


            string testrecipename = "test";
            DateTime currenttime = DateTime.Now;


            testrecipename += currenttime.ToString();
            bizRecipe recipe = new();

            recipe.CuisineId = cuisineid;
            recipe.UsersId = userid;
            recipe.RecipeName = testrecipename;
            recipe.Calories = 20;
            recipe.DateDrafted = DateTime.Now.AddYears(-10);
            recipe.DatePublished = DateTime.Now.AddYears(-5);
            recipe.DateArchived = DateTime.Now;

            
            recipe.Save();

            TestContext.WriteLine("insert recipe with recipename = " + testrecipename);

            string newrecipename = GetFirstColumnFirstRowString("select recipename from recipe where recipename = '" + testrecipename + "'");
            Assert.IsTrue(testrecipename == newrecipename, "recipe with recipename (" + testrecipename + ") is not found in DB");
            TestContext.WriteLine("recipe with recipename " + testrecipename + " is found in DB");


        }
        
        [Test]
        public void DeleteRecipe()
        {
            string sql = @"
    select top 1  r.recipeid, r.recipename
	from recipe r
	left join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId
	left join CookbookRecipe cr on cr.RecipeId = r.RecipeId
	where mcr.RecipeID is null
	and cr.RecipeID is null 
	and ((r.RecipeStatus = 'Drafted') 
	or (r.RecipeStatus = 'Archived' and DateAdd(day, 30, r.DateArchived) <= GetDate()))
                ";

            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = (string)dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            TestContext.WriteLine("existing recipe with name " + recipename + " and recipe id (" + recipeid + ")");
            TestContext.WriteLine("ensure that app deletes recipe (" + recipeid + ")");
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = GetDataTable("select * from Recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid (" + recipeid + ") exists in DB");
            TestContext.WriteLine("record with recipeid (" + recipeid + ") does not exist in DB");
        }


        [Test]
        public void GetListOfCuisine()
        {
            int cuisinecount = GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisine in DB, can't run test");
            TestContext.WriteLine("num of cuisine in DB = " + cuisinecount);
            TestContext.WriteLine("ensure that num of rows return by app matches " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ")" + " <> " + cuisinecount);
            TestContext.WriteLine("number of rows in cuisine returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void GetListOfUsers()
        {
            
            int userscount = GetFirstColumnFirstRowValue("select total = count(*) from users u");
            Assume.That(userscount > 0, "No users in DB, can't run test");
            TestContext.WriteLine("num of users in DB = " + userscount);
            TestContext.WriteLine("ensure that num of rows return by app matches " + userscount);

            DataTable dt = Users.GetUsersList();
            //necessary to add -1 because getuser sproc has blank row
            Assert.IsTrue(dt.Rows.Count - 1 == userscount, "num rows returned by app (" + dt.Rows.Count + ")" + " <> " + userscount);
            TestContext.WriteLine("number of rows in users returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void ChangeCaloriesExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");
            int calories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for (" + recipeid + ") is (" + calories + ")");

            calories = calories + 10;
            TestContext.WriteLine("change calories to (" + calories + ")");
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["calories"] = calories;
            bizRecipe recipe = new();
            recipe.Save(dt);

            int newcalories = GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "calories for recipeid (" + recipeid + ") <> (" + calories + ")");
            TestContext.WriteLine("calories for recipeid (" + recipeid + ") = (" + calories + ")");

        }
        [Test]
        public void ChangeRecipeNameOfExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");
            string recipename = GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for (" + recipeid + ") is (" + recipename + ")");

            recipename = recipename + "!!";
            TestContext.WriteLine("change recipename to (" + recipename + ")");

            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);

            dt.Rows[0]["recipename"] = recipename;
            Recipe.Save(dt);

            string newrecipename = GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newrecipename == recipename, "recipename for recipeid (" + recipeid + ") <> (" + newrecipename + ")");
            TestContext.WriteLine("recipename for recipeid (" + recipeid + ") = (" + newrecipename + ")");

        }



        //Exception Tests

        [Test]
        public void SaveRecipeWithBlankName()
        {
            DataTable dt = GetDataTable("select top 1 * from recipe");
            int recipeid = (int)dt.Rows[0]["RecipeID"];
            string recipename = GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");

            TestContext.WriteLine("recipename for (" + recipeid + ") is \"" + recipename + "\"");

            string blankrecipename = "";

            TestContext.WriteLine("Ensure that recipe cannot be saved with blank RecipeName");
            TestContext.WriteLine("Change recipeid (" + recipeid + ") recipename \"" + recipename + "\" to (blank) recipe name ");

            dt.Rows[0]["RecipeName"] = blankrecipename;

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }

        [Test]
        public void SaveRecipeWithExistingName()
        {
            DataTable dt = GetDataTable("select top 1 * from recipe");
            int recipeid = (int)dt.Rows[0]["RecipeID"];
            string recipename = dt.Rows[0]["RecipeName"].ToString();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");

            TestContext.WriteLine("recipename for recipeID (" + recipeid + ") is " + recipename);

            int recipecount = GetFirstColumnFirstRowValue("select count (*) from recipe");
            Assume.That(recipecount > 1, "no additional recipes in DB, can't run test");

            DataTable dtchange = GetDataTable("select top 1 * from recipe where recipeid <> " + recipeid);
            int recipeidchange = (int)dtchange.Rows[0]["RecipeID"];
            string recipenamechange = (string)dtchange.Rows[0]["RecipeName"];

            TestContext.WriteLine("Change recipename " + recipename + " to recipe name \"" + recipenamechange + "\" which is existing name of RecipeID (" + recipeidchange + ")");

            dt.Rows[0]["RecipeName"] = recipenamechange;

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }

        [Test]
        public void DeleteRecipePublishedInCookbook()
        {
            DataTable dt = GetDataTable("select top 1 r.RecipeID, r.RecipeName from Recipe r join CookbookRecipe cr on cr.RecipeID = r.RecipeID");
            int recipeid = 0;
            string recipename = "";

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = (string)dt.Rows[0]["RecipeName"];
            }

            Assume.That(recipeid > 0, "Recipes published in cookbooks don't exist in DB, can't run test");
            TestContext.WriteLine("existing recipe published in cookbook, with id = " + recipeid + " " + recipename);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeArchivedLessThan30Days()
        {
            string sql = @"
            select top 1 r.RecipeID, r.RecipeName
            from recipe r
            left join MealCourseRecipe mcr on mcr.RecipeID = r.RecipeID
            left join CookbookRecipe cr on cr.RecipeID = r.RecipeID
            where mcr.RecipeID is null
            and cr.RecipeID is null and 
            (r.RecipeStatus != 'Drafted' 
            or DateAdd(day, 30, r.DateArchived) >= GetDate())
                            ";

            DataTable dt = GetDataTable(sql);
            int recipeid = 0;
            string recipename = "";

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = (string)dt.Rows[0]["recipename"];

            }
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            TestContext.WriteLine("recipe with name " + recipename + " and recipe id (" + recipeid + ") archived less than 30 days.");
            TestContext.WriteLine("ensure that app cannot delete recipe (" + recipeid + ")");

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void SaveRecipeWithZeroCalories()
        {
            DataTable dt = GetDataTable("select top 1 * from Recipe");
            int recipeid = (int)dt.Rows[0]["RecipeID"];
            int calories = (int)dt.Rows[0]["Calories"];
            string recipename = dt.Rows[0]["RecipeName"].ToString();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");

            TestContext.WriteLine("calories for " + recipename + " is (" + calories + ")");

            calories = 0;
            TestContext.WriteLine("change calories to (" + calories + ")");

            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }
        
        [Test]
        public void SaveRecipeWithFutureDate()
        {
            DataTable dt = GetDataTable("select top 1 * from Recipe");
            int recipeid = (int)dt.Rows[0]["RecipeID"];
            DateTime datedrafted = (DateTime)dt.Rows[0]["DateDrafted"];
            string recipename = dt.Rows[0]["RecipeName"].ToString();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");

            TestContext.WriteLine("DateDrafted for recipe (" + recipeid + ") " + recipename + " is " + datedrafted );

            DateTime advancedtime = DateTime.Now.AddYears(10);
            
            TestContext.WriteLine("Change DateDrafted of recipe (" + recipeid + ") " + recipename + " to " + advancedtime );

            dt.Rows[0]["DateDrafted"] = advancedtime;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }


        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
*/