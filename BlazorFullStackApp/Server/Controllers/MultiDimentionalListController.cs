using BlazorFullStackApp.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiDimentionalListController : ControllerBase
    {
        static List<MultiDimentionalList> ListOfElements = new List<MultiDimentionalList>
        {
            new MultiDimentionalList { LowerDimentionList = new List<MultiDimentionalList> { new MultiDimentionalList { LowerDimentionList = new List<MultiDimentionalList>(), Id = 3, Name = "Third Item" } }, Id = 0, Name = "First Item", Data = 1 },
            new MultiDimentionalList { LowerDimentionList = new List<MultiDimentionalList>(), Id = 1, Name = "Second Item", Data = 2 }
        };

        [HttpGet]
        public async Task<IActionResult> GetListOfElements()
        {
            return Ok(ListOfElements);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> AddElement(int id, MultiDimentionalList toAdd)
        {
            bool recourseEnd = false;

            async Task RecoursiveAddElem(List<MultiDimentionalList> lowerDimentionList)
            {
                foreach (var i in lowerDimentionList)
                {
                    if (i.Id == id || recourseEnd)
                    {
                        recourseEnd = true;
                        lowerDimentionList.Add(toAdd);
                        return;
                    }
                    await RecoursiveAddElem(i.LowerDimentionList);
                }
            }


            await RecoursiveAddElem(ListOfElements);

            return Ok();
        }
    }
}
