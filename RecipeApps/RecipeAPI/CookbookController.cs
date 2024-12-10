using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
            [HttpGet]
            public List<bizCookbook> Get()
            {
                return new bizCookbook().GetList();
            }

            [HttpGet("cookbookid/{cookbookid:int:min(1)}")]
            public List<bizCookbook> getCookbookDetail(int cookbookid)
            {
            bizCookbook c = new bizCookbook();
            return c.SearchCookbook(cookbookid, "");
            }
        }
    }


