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
            return new bizCuisine().GetList(true);
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
            return new bizUsers().GetList(true);
        }

        [HttpPost]
        public IActionResult Post(bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                recipe.ErrorMessage = "Recipe saved successfully!";
                return Ok(recipe);
            }
            catch (Exception ex)
            {
                recipe.ErrorMessage = ex.Message;
                return BadRequest(recipe);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            bizRecipe r = new();
            try
            {
                r.Delete(id);
                return Ok(r);
            }
            catch(Exception ex)
            {
                r.ErrorMessage = ex.Message;
                return BadRequest(r);
            }
        }


    }
}
