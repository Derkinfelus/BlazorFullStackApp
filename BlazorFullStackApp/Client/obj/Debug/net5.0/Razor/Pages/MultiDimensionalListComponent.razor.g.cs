#pragma checksum "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0480b7f4a81f813dbb27ed4d8f366e6950969931"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/MultiDimensionalList")]
    public partial class MultiDimensionalListComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
 if (MultiDimensionalListService.HightestDimensionElement == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h2>Elelments Are Loading</h2>");
#nullable restore
#line 9 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
                      elemToEdit.ParrentId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __Blazor.BlazorFullStackApp.Client.Pages.MultiDimensionalListComponent.TypeInference.CreateInputRadioGroup_0(__builder2, 4, 5, 
#nullable restore
#line 13 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
                                       elemToEdit.ParrentId

#line default
#line hidden
#nullable disable
                , 6, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => elemToEdit.ParrentId = __value, elemToEdit.ParrentId)), 7, () => elemToEdit.ParrentId, 8, (__builder3) => {
                    __builder3.OpenComponent<BlazorFullStackApp.Client.Shared.RecoursiveRenderMultiDimensionalListComponent>(9);
                    __builder3.AddAttribute(10, "lst", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(
#nullable restore
#line 14 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
                                                                 MultiDimensionalListService.HightestDimensionElement

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "elemToEdit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(
#nullable restore
#line 14 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
                                                                                                                                          elemToEdit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "elemToEditChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => elemToEdit = __value, elemToEdit))));
                    __builder3.CloseComponent();
                }
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorFullStackApp.Client.Shared.MultiDimensionalListManagementComponent>(13);
            __builder.AddAttribute(14, "elemToEdit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorFullStackApp.Shared.OpenableMultiDimensionalList>(
#nullable restore
#line 22 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
                                                     elemToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 23 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
__builder.AddContent(16, elemToEdit.Id);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 24 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
__builder.AddContent(18, elemToEdit.ParrentId);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 25 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
__builder.AddContent(20, elemToEdit.Name);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Derkin\source\repos\BlazorFullStackApp\BlazorFullStackApp\Client\Pages\MultiDimensionalListComponent.razor"
       
    public OpenableMultiDimensionalList elemToEdit = new OpenableMultiDimensionalList
    {
        Id = -1,
        Name = "",
        Data = 0,
        IsOpen = false,
        ParrentId = 0,
        LowerDimensionList = new List<OpenableMultiDimensionalList>()
    };


    protected override async Task OnInitializedAsync()
    {
        MultiDimensionalListService.OnChange += StateHasChanged;
        if (MultiDimensionalListService.HightestDimensionElement == null)
            await MultiDimensionalListService.GetHightestDimensionElement();
    }


    public void Dispose()
    {
        MultiDimensionalListService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMultiDimensionalListService MultiDimensionalListService { get; set; }
    }
}
namespace __Blazor.BlazorFullStackApp.Client.Pages.MultiDimensionalListComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputRadioGroup_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputRadioGroup<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
