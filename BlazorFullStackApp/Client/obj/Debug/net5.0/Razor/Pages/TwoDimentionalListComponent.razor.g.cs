#pragma checksum "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d9cb156b27e70e1e5321283e809845ec08346d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFullStackApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/list")]
    public partial class TwoDimentionalListComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TwoDimentionalListComponent</h3>\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 8 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
     foreach (var i in TwoDimentionalListService.ListOfElements)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "h3");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
                 i.Key

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "ul");
#nullable restore
#line 13 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
                 foreach (var j in i.Value)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "li");
            __builder.OpenElement(8, "p");
            __builder.AddContent(9, "Name: ");
            __builder.AddContent(10, 
#nullable restore
#line 16 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
                                  j.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, ", Data: ");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
                                                 j.Data

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorFullStackApp.Client.Shared.ListManagementComponent>(14);
            __builder.AddAttribute(15, "transporterToEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFullStackApp.Shared.ElementTransporter>(
#nullable restore
#line 26 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
                                            transporter

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Derkinfel\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\TwoDimentionalListComponent.razor"
       
    ElementTransporter transporter = new ElementTransporter { Element = new ListElement() };

    protected override async Task OnInitializedAsync()
    {
        TwoDimentionalListService.OnChange += StateHasChanged;
        await TwoDimentionalListService.GetList();
    }

    public void Dispose()
    {
        TwoDimentionalListService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITwoDimentionalListService TwoDimentionalListService { get; set; }
    }
}
#pragma warning restore 1591
