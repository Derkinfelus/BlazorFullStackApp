using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    interface IMultiDimentionalListService
    {
        event Action OnChange;
        List<OpenableMultiDimentionalList> ListOfElements { get; set; }
        Task GetList();
        Task PostElement(int id, OpenableMultiDimentionalList transporter);
    }
}
