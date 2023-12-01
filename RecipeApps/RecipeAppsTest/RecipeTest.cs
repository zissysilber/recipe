using NUnit.Framework.Constraints;
using System.Data;

namespace RecipeAppsTest
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]
        public void SearchRecipes()
        {
            string recipename = SQLUtility.GetFirstColumnFirstRowString("select top 1 recipename from recipe");
            recipename = recipename.Substring(0, 1);
            Assume.That(recipename is not null, "No recipe in DB, can't run test");
            TestContext.WriteLine("search for recipename that contains (" + recipename + ")");
            TestContext.WriteLine("ensure that app returns recipe with name that contains (" + recipename + ")");

            DataTable dt = Recipe.SearchRecipes(recipename);

            Assume.That(dt.Rows.Count > 0, "no recipes found, can't run test");
            string foundrecipename = dt.Rows[0]["recipename"].ToString();
            Assert.IsTrue(dt.Rows.Count > 0, "no recipename in DB that contains (" + recipename + ")");
            TestContext.WriteLine("found recipename (" + foundrecipename + ") that contains (" + recipename + ")");
        }


        [Test]
        public void LoadSpecificRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = (" + recipeid + ")");
            TestContext.WriteLine("Ensure that app loads recipe (" + recipeid + ")");

            DataTable dt = Recipe.Load(recipeid);

            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + recipeid + ")");
        }

         

        
        [Test]
        public void InsertNewRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid  = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(cuisineid > 0, "can't run test, no cuisine in DB");
            int userid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            Assume.That(userid > 0, "can't run test, no users in DB");


            string testrecipename = "test";
            DateTime currenttime = DateTime.Now;


             testrecipename += currenttime.ToString();

            r["cuisineid"] = cuisineid;
            r["usersid"] = userid;
            r["RecipeName"] = testrecipename;
            r["Calories"] = 20;
            r["DateDrafted"] = "2020-10-10";
            r["DatePublished"] = "2021-10-10";
            r["DateArchived"] = "2022-10-10";

            Recipe.Save(dt);

            TestContext.WriteLine("insert recipe with recipename = " + testrecipename);

            string newrecipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipename = '" + testrecipename + "'");
            Assert.IsTrue(testrecipename == newrecipename, "recipe with recipename (" + testrecipename + ") is not found in DB");
            TestContext.WriteLine("recipe with recipename " + testrecipename + " is found in DB");


        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from recipe r ");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipe in DB, can't run test");
            TestContext.WriteLine("existing recipe with name " + recipename + " and recipe id (" + recipeid + ")");
            TestContext.WriteLine("ensure that app deletes recipe (" + recipeid + ")");

            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid (" + recipeid + ") exists in DB");
            TestContext.WriteLine("record with recipeid (" + recipeid + ") does not exist in DB");

        }

        [Test]
        public void GetListOfCuisine()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
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
            
            int userscount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from users");
            Assume.That(userscount > 0, "No users in DB, can't run test");
            TestContext.WriteLine("num of users in DB = " + userscount);
            TestContext.WriteLine("ensure that num of rows return by app matches " + userscount);

            DataTable dt = Recipe.GetUsersList();

            Assert.IsTrue(dt.Rows.Count == userscount, "num rows returned by app (" + dt.Rows.Count + ")" + " <> " + userscount);
            TestContext.WriteLine("number of rows in users returned by app = " + dt.Rows.Count);
        }

        [Test]
        public void ChangeCaloriesExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for (" + recipeid + ") is (" + calories + ")");

            calories = calories + 10;
            TestContext.WriteLine("change calories to (" + calories + ")");
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "calories for recipeid (" + recipeid + ") <> (" + calories + ")");
            TestContext.WriteLine("calories for recipeid (" + recipeid + ") = (" + calories + ")");

        }
        [Test]
        public void ChangeRecipeNameExistingRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "no recipes in DB, can't run test");
            string recipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for (" + recipeid + ") is (" + recipename + ")");

            recipename = recipename + "!!";
            TestContext.WriteLine("change recipename to (" + recipename + ")");
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["recipename"] = recipename;
            Recipe.Save(dt);

            string newrecipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newrecipename == recipename, "recipename for recipeid (" + recipeid + ") <> (" + newrecipename + ")");
            TestContext.WriteLine("recipename for recipeid (" + recipeid + ") = (" + newrecipename + ")");

        }


        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}