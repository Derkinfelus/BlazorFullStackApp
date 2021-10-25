using BlazorFullStackApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFullStackApp.Client.Services
{
    interface IMultiDimensionalListService
    {
        event Action OnChange;
        OpenableMultiDimensionalList HightestDimensionElement { get; set; }
        Task GetHightestDimensionElement();
        Task PostElement(OpenableMultiDimensionalList element);
    }
}
