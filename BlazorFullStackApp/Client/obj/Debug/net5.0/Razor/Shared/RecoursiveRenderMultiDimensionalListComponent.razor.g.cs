#pragma checksum "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f0f0f1de468ab7dd9da0524de5406a50d6edbc9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorFullStackApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\_Imports.razor"
using BlazorFullStackApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class RecoursiveRenderMultiDimensionalListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.OpenElement(1, "li");
#nullable restore
#line 3 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
         if (lst.LowerDimensionList.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "label");
            __builder.AddContent(3, "Id: ");
#nullable restore
#line 5 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(4, lst.Id);

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, ", ParrentId = ");
#nullable restore
#line 5 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(6, lst.ParrentId);

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, ", ");
#nullable restore
#line 5 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(8, lst.Name);

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, ": ");
#nullable restore
#line 5 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(10, lst.Data);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
                              (() => lst.IsOpen = !lst.IsOpen)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "btn-primary");
#nullable restore
#line 9 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(14, ListStatus(lst.IsOpen));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, "Id: ");
#nullable restore
#line 10 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(18, lst.Id);

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, ", ");
#nullable restore
#line 10 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
__builder.AddContent(20, lst.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
                                                    () => BoundValue = lst

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddMarkupContent(26, "<label>To add</label>\r\n        ");
            __Blazor.BlazorFullStackApp.Client.Shared.RecoursiveRenderMultiDimensionalListComponent.TypeInference.CreateInputRadio_0(__builder, 27, 28, 
#nullable restore
#line 14 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
                           lst.Id

#line default
#line hidden
#nullable disable
            , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
                                               async () => await OnAddClick(lst.Id)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 15 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
         foreach (var i in lst.LowerDimensionList)
        {
            if (lst.IsOpen)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorFullStackApp.Client.Shared.RecoursiveRenderMultiDimensionalListComponent>(30);
            __builder.AddAttribute(31, "lst", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(
#nullable restore
#line 19 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
                                                                     i

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "elemToEdit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(
#nullable restore
#line 19 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
                                                                                           BoundValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "elemToEditChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BoundValue = __value, BoundValue))));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Shared\RecoursiveRenderMultiDimensionalListComponent.razor"
       
    [Parameter]
    public OpenableMultiDimensionalList lst { get; set; }
    [Parameter]
    public OpenableMultiDimensionalList elemToEdit { get; set; }
    [Parameter]
    public EventCallback<OpenableMultiDimensionalList> elemToEditChanged { get; set; }
    private OpenableMultiDimensionalList BoundValue
    {
        get => elemToEdit;
        set => elemToEditChanged.InvokeAsync(value);
    }


    string ListStatus(bool isOpen)
    {
        if (isOpen)
            return "Hide";
        else
            return "Show";
    }


    async Task OnAddClick(int parrentId)
    {
        var tmp = new OpenableMultiDimensionalList
        {
            ParrentId = parrentId,
            Id = -1,
            LowerDimensionList = new List<OpenableMultiDimensionalList>()
        };
        await elemToEditChanged.InvokeAsync(tmp);

        elemToEdit.Id = -1;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorFullStackApp.Client.Shared.RecoursiveRenderMultiDimensionalListComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadio_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadio<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591