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
#line 3 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Ganacias.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ganancias")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/R_Ganancias/{GananciaId:int}")]
    public partial class R_Ganacias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Ganacias.razor"
       

    [Parameter]
    public int GananciaId { get; set; }
    public List<Jugadas> jugadas { get; set; } = new List<Jugadas>();
    public Ganancias ganancia { get; set; } = new Ganancias();
    public List<Loterias> list { get; set; }
    public List<TipoJugada> lista { get; set; }
    public GananciaDetalle Detalles { get; set; } = new GananciaDetalle();
    public JugadaDetalle detalle { get; set; } = new JugadaDetalle();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        list = jugadasBLL.LoteryList();
        lista = jugadasBLL.TypeGame();
        jugadas = jugadasBLL.GetList();
        ganancia.GananciaId = 0;
        ganancia.Fecha = DateTime.Now;
        ganancia.montoJugado = 0.00;
        ganancia.GananciaId = GananciaId;
        ganancia.Totalganancias = 0;
        Buscar();
    }

    public void AgregarDetalle()
    {
        var jugada = jugadasBLL.BuscarJ(Detalles.JugadaId);
        if (Detalles.MontoGanancia != 0)
        {
            Detalles.JugadaId = jugada.JugadaId;
            Detalles.LoteriaId = jugada.LoteriaId;
            Detalles.TipoJugadaId = jugada.TipoJugadaId;
            Detalles.NombreLoteria = jugada.NombreLoteria;
            Detalles.Nombre = jugada.Nombre;
            Detalles.Montojugado = jugada.Monto;
            jugada.MontoGanancia = Detalles.MontoGanancia;
            ganancia.Detalle.Add(Detalles);
            ganancia.Totalganancias += Detalles.MontoGanancia;
            Detalles = new GananciaDetalle();

            ShowNotification(
            new NotificationMessage
            {
                Severity = NotificationSeverity.Success,
                Summary = "Detalles agregados correctamente"
            });
        }
        else
        {
            ShowNotification(
            new NotificationMessage
            {
                Severity = NotificationSeverity.Warning,
                Summary = "Detalles no agregados"
            });
        }


    }



    public void Nuevo()
    {
        if (ganancia.Totalganancias != 0 || ganancia.Totalganancias < 0)
        {

            ganancia = new Ganancias();
            Detalles = new GananciaDetalle();

        }
    }
    void Buscar()
    {
        if (this.ganancia.GananciaId > 0)
        {
            Ganancias encontrado = gananciaBLL.BuscarJ(this.ganancia.GananciaId);

            if (encontrado != null)
            {
                this.ganancia = encontrado;
            }
        }
    }
    void Guardar()
    {


        if (ganancia.Totalganancias != 0 || ganancia.Totalganancias < 0)
        {
            var guardado = gananciaBLL.Guardar(this.ganancia);
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
        if (ganancia.Totalganancias != 0 || ganancia.Totalganancias < 0)
        {
            eliminado = gananciaBLL.Eliminar(ganancia);
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