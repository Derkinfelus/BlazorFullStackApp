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
    public class MultiDimensionalListController : ControllerBase
    {
        static int MaxId = 4;

        static MultiDimensionalList HightestDimensionElement = new MultiDimensionalList
        {
            ParrentId = 0, Id = 0, Name = "First Item", Data = 0, LowerDimensionList = new List<MultiDimensionalList>
            {
                new MultiDimensionalList
                {
                    ParrentId = 0, Id = 1, Name = "Post-First First Item", Data = 1, LowerDimensionList = new List<MultiDimensionalList>
                    {
                        new MultiDimensionalList
                        {
                            ParrentId = 1, Id = 2, Name = "Post-First Post-First First Item", Data = 2, LowerDimensionList = new List<MultiDimensionalList>()
                        },
                        new MultiDimensionalList
                        {
                            ParrentId = 1, Id = 3, Name = "Post-First Post-First Second Item", Data = 3, LowerDimensionList = new List<MultiDimensionalList>()
                        }
                    }
                },
                new MultiDimensionalList
                {
                    ParrentId = 0, Id = 4, Name = "Post-First Second Item", Data = 4, LowerDimensionList = new List<MultiDimensionalList>()
                }
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetHightestDimensionElement()
        {
            return Ok(HightestDimensionElement);
        }

        [HttpPost]
        public async Task<IActionResult> PostElement(MultiDimensionalList element)
        {
            MaxId += 1;
            element.Id = MaxId;
            
            (await HightestDimensionElement.FindElement(element.ParrentId)).LowerDimensionList.Add(element);

            return Ok(element.Id);
        }
    }
}
