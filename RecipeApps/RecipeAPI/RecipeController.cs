using Microsoft.AspNetCore.Http;
using RecipeSystem;
using Microsoft.AspNetCore.Mvc;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetList();
        }

        [HttpGet("getbyid/{recipeid:int:min(1)}")]
        public bizRecipe Get(int recipeid)
        {
            bizRecipe r = new bizRecipe();
            r.Load(recipeid);
            return r;
        }

        [HttpGet("Cuisine")]
        public List<bizCuisine> GetCuisine()
        {
            return new bizCuisine().GetList();
        }

        [HttpGet("GetByCuisine/{cuisineName}")]
        public List<bizRecipe> GetByCuisine(string cuisineName)
        {
            bizRecipe r = new bizRecipe();
            return r.SearchByCuisine(cuisineName);

        }

        [HttpGet("Users")]
        public List<bizUsers> GetUsers()
        {
            return new bizUsers().GetList();
        }

        [HttpPost]
        public IActionResult Post([FromForm] bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(new { message = $"Recipe \"{recipe.RecipeName}\" saved successfully.", recipeid = recipe.RecipeId, recipestatus = recipe.RecipeStatus });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                bizRecipe r = new();
                r.Delete(id);
                return Ok(new { message = "Recipe deleted" });
            }
            catch(Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }


    }
}
