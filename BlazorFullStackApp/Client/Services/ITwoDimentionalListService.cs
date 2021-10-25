using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFullStackApp.Shared;

namespace BlazorFullStackApp.Client.Services
{
    interface ITwodimensionalListService
    {
        event Action OnChange;
        Dictionary<string, List<ListElement>> ListOfElements { get; set; }
        Task GetList();
        Task PostElement(ElementTransporter transporter);
    }
}
