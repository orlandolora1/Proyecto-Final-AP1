// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyectoFinal.Pages.Registro
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
#nullable restore
#line 3 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/R_Tickets/{JugadaId:int}")]
    public partial class R_Tickets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
       

    [Parameter]
    public int JugadaId { get; set; }
    public Ganancias ganancias = new Ganancias();
    public Jugadas jugadas { get; set; } = new Jugadas();
    public List<Jugadas> jugada { get; set; } = new List<Jugadas>();
    public List<Loterias> list { get; set; }
    public List<TipoJugada> lista { get; set; }
    public JugadaDetalle Detalles { get; set; } = new JugadaDetalle();
    protected override void OnInitialized()
    {
        base.OnInitialized();

        var juego = jugadasBLL.BuscarTJ(Detalles.TipoJugadaId);
        var ganancia = gananciaBLL.BuscarJ(Detalles.GananciaId);
        var loto = jugadasBLL.BuscarL(Detalles.LoteriaId);

        list = jugadasBLL.LoteryList();
        lista = jugadasBLL.TypeGame();
        jugada = jugadasBLL.GetList();
        jugadas.JugadaId = 0;
        jugadas.Fecha = DateTime.Now;
        jugadas.Monto = 0.00;
        jugadas.JugadaId = JugadaId;
        jugadas.LoteriaId = 0;
        jugadas.TipoJugadaId = 0;
        jugadas.NombreLoteria = "";
        jugadas.Nombre = "";
        jugadas.MontoGanancia = 0.00;
        Buscar();

    }

    public void Nuevo()
    {
        if (jugadas.Monto > 0)
        {

            jugadas = new Jugadas();
            Detalles = new JugadaDetalle();

        }
    }
    void Buscar()
    {
        if (this.jugadas.JugadaId > 0)
        {
            Jugadas encontrado = jugadasBLL.BuscarJ(this.jugadas.JugadaId);

            if (encontrado != null)
            {
                this.jugadas = encontrado;
            }

        }
    }

    void Guardar()
    {

        if (jugadas.Monto > 0 && jugadas.TipoJugadaId !=0  && jugadas.LoteriaId !=0) 
        {
            var guardado = jugadasBLL.Guardar(this.jugadas);
            if (guardado)
            {
                ShowNotification(
                new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Guardado correctamente"
                });
                Nuevo();
            }
            else
            {
                ShowNotification(
                new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Error al guardar"
                });

            }
        }
        else
        {
            ShowNotification(
            new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = "Error al guardar"
            });

        }



    }

    public void Eliminar()
    {
        bool eliminado;
        if (jugadas.Monto > 0 && jugadas.JugadaId > 1)
        {
            eliminado = jugadasBLL.Eliminar(jugadas);
            if (eliminado)
            {
                ShowNotification(
                new NotificationMessage
                {
                    Severity = NotificationSeverity.Success,
                    Summary = "Eliminado correctamente"
                });
                Nuevo();
            }
            else
            {
                ShowNotification(
                new NotificationMessage
                {
                    Severity = NotificationSeverity.Error,
                    Summary = "Error al eliminar"
                });

            }
        }
        else
        {
            ShowNotification(
            new NotificationMessage
            {
                Severity = NotificationSeverity.Error,
                Summary = "Error al eliminar"
            });

        }


    }

    void ShowNotification(NotificationMessage message)
    {
        notificationService.Notify(message);

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService notificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GananciasBLL gananciaBLL { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JugadasBLL jugadasBLL { get; set; }
    }
}
#pragma warning restore 1591