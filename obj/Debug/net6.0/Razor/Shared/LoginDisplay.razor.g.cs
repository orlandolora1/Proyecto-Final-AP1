#pragma checksum "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2f2fe5d11913580c5c426b7ca26265d4ee3b41"
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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "Identity/Cuenta/Administrar");
                __builder2.AddContent(4, "Hola, ");
#nullable restore
#line (3,54)-(3,81) 25 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Shared\LoginDisplay.razor"
__builder2.AddContent(5, context.User.Identity?.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.AddMarkupContent(8, "<form method=\"post\" action=\"Identity/Account/LogOut\"><button type=\"submit\" class=\"nav-link btn btn-link\">Cerrar Sesi??n</button></form>");
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<a href=\"Identity/Account/Register\">Registrate</a>\n        ");
                __builder2.AddMarkupContent(11, "<a href=\"Identity/Account/Login\">Iniciar Sesi??n</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
