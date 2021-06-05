#pragma checksum "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/Pages/Vendas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "353b57c266f627e1c0eceba74bb54b9ef0de4c90"
// <auto-generated/>
#pragma warning disable 1591
namespace Li4Fase3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Li4Fase3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Li4Fase3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Li4Fase3.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Li4Fase3.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Li4Fase3.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/_Imports.razor"
using Li4Fase3.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/venda")]
    public partial class Vendas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Lista Vendas </h3>\n");
            __builder.OpenComponent<Li4Fase3.Client.Shared.VendasList>(1);
            __builder.AddAttribute(2, "Vendas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Li4Fase3.Shared.DTOs.VendasDetailsDTO>>(
#nullable restore
#line 5 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/Pages/Vendas.razor"
                    Venda

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "/Users/johnny/Projects/Li4Fase3/Li4Fase3/Client/Pages/Vendas.razor"
 
    List<VendasDetailsDTO> Venda = new List<VendasDetailsDTO>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Venda = await vendaRepository.GetVendasDetailsDTO();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVendaRepository vendaRepository { get; set; }
    }
}
#pragma warning restore 1591