#pragma checksum "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40663db9a65dbec4d8d169beacc1d77805482338"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyectoFinal.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using ProyectoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using ProyectoFinal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row ps-3 navbar navbar-dark");
            __builder.AddAttribute(2, "b-fx6gbz8hvx");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "b-fx6gbz8hvx");
            __builder.AddMarkupContent(6, "<a class=\"navbar-brand\" href b-fx6gbz8hvx>Proyecto final</a>\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "title", "Navigation menu");
            __builder.AddAttribute(9, "class", "navbar-toggler");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\NavMenu.razor"
                                                                         ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "b-fx6gbz8hvx");
            __builder.AddMarkupContent(12, "<span class=\"navbar-toggler-icon\" b-fx6gbz8hvx></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", 
#nullable restore
#line 10 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\NavMenu.razor"
               NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\NavMenu.razor"
                                          ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "b-fx6gbz8hvx");
            __builder.OpenElement(18, "nav");
            __builder.AddAttribute(19, "class", "flex-column");
            __builder.AddAttribute(20, "b-fx6gbz8hvx");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "nav-item px-3");
            __builder.AddAttribute(23, "b-fx6gbz8hvx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "");
            __builder.AddAttribute(27, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(29, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-fx6gbz8hvx></span> Home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "nav-item px-3");
            __builder.AddAttribute(33, "b-fx6gbz8hvx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "class", "nav-link");
            __builder.AddAttribute(36, "href", "Jugadas");
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-fx6gbz8hvx></span> Registro de Jugada\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "nav-item px-3");
            __builder.AddAttribute(42, "b-fx6gbz8hvx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(43);
            __builder.AddAttribute(44, "class", "nav-link");
            __builder.AddAttribute(45, "href", "Ganancias");
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<span class=\"oi oi-plus\" aria-hidden=\"true\" b-fx6gbz8hvx></span> Registro de Ganancia\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "nav-item px-3");
            __builder.AddAttribute(51, "b-fx6gbz8hvx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "nav-link");
            __builder.AddAttribute(54, "href", "C_Jugadas");
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(56, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-fx6gbz8hvx></span> Consulta de Jugadas\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "nav-item px-3");
            __builder.AddAttribute(60, "b-fx6gbz8hvx");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "nav-link");
            __builder.AddAttribute(63, "href", "C_Ganancias");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-fx6gbz8hvx></span> Consulta de Ganancias\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string? NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591