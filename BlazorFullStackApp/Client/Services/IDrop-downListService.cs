using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    interface IDrop_downListService
    {
        event Action OnChange;
        Dictionary<string, OpenableDrop_downList> ListOfElements { get; set; }
        Task GetList();
        Task PostElement(ElementTransporter transporter);
    }
}
