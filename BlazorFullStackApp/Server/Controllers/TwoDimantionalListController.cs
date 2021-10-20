using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFullStackApp.Shared;

namespace BlazorFullStackApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwoDimantionalListController : ControllerBase
    {
        static Dictionary<string, List<ListElement>> ListOfElements = new Dictionary<string, List<ListElement>>
        {
            { "First Type", new List<ListElement> { new ListElement { Name = "First Element", Data = 1 }, new ListElement { Name = "Second Element", Data = 2 } } },
            { "Second Type", new List<ListElement> { new ListElement { Name = "Third Element", Data = 3 }, new ListElement { Name = "Fourth Element", Data = 4 } } },
        };

        [HttpGet]
        public async Task<IActionResult> GetListOfElements()
        {
            return Ok(ListOfElements);
        }

        [HttpPost]
        public async Task<IActionResult> AddElement(ElementTransporter transporter)
        {
            if (ListOfElements.ContainsKey(transporter.Type))
                ListOfElements[transporter.Type].Add(transporter.Element);
            else
                ListOfElements.Add(transporter.Type, new List<ListElement> { new ListElement { Name = transporter.Element.Name, Data = transporter.Element.Data } });

            return Ok(ListOfElements);
        }
    }
}
