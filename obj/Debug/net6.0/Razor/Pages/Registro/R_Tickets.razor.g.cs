#pragma checksum "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a5ddb518915d333e012213ff00d675883d5037f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                 jugadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                         Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "card text-dark bg-light shadow-lg text-primary");
                __builder2.AddMarkupContent(8, "<div class=\"card-header text-center\"><h4 class=\" text-center text-primary\">Registro de Jugada</h4></div>\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "card-body opacity-75");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "row justify-content-between");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-3");
                __builder2.AddMarkupContent(17, "<label>Ticker Id</label>\n                        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "input-group mb-3");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateInputNumber_0(__builder2, 20, 21, "form-control", 22, 
#nullable restore
#line 24 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                           jugadas.JugadaId

#line default
#line hidden
#nullable disable
                , 23, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jugadas.JugadaId = __value, jugadas.JugadaId)), 24, () => jugadas.JugadaId);
                __builder2.AddMarkupContent(25, "\n                            ");
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                              Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(29, "type", "button");
                __builder2.AddMarkupContent(30, "<i class=\"oi oi-magnifying-glass\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n\n                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "col-3");
                __builder2.AddMarkupContent(34, "<label>Fecha</label>\n                        ");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateInputDate_1(__builder2, 35, 36, "form-control", 37, 
#nullable restore
#line 33 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                     jugadas.Fecha

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jugadas.Fecha = __value, jugadas.Fecha)), 39, () => jugadas.Fecha);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n\n\n\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-12");
                __builder2.AddMarkupContent(43, "<label>Loteria</label>\n                    ");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateInputSelect_2(__builder2, 44, 45, "form-select", 46, 
#nullable restore
#line 42 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                  jugadas.LoteriaId

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jugadas.LoteriaId = __value, jugadas.LoteriaId)), 48, () => jugadas.LoteriaId, 49, (__builder3) => {
                    __builder3.AddMarkupContent(50, "<option value=\"0\" disabled> Seleccione </option>");
#nullable restore
#line 44 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                         foreach (var loteria in list)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", 
#nullable restore
#line 46 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                            loteria.LoteriaId

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (46,66)-(46,80) 26 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
__builder3.AddContent(53, loteria.Nombre);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 47 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(54, "\n                       ");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateValidationMessage_3(__builder2, 55, 56, 
#nullable restore
#line 49 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                 () => jugadas.LoteriaId

#line default
#line hidden
#nullable disable
                , 57, "form-control");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\n\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-12");
                __builder2.AddMarkupContent(61, "<label>Tipo de Jugada</label>\n                    ");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateInputSelect_4(__builder2, 62, 63, "form-select", 64, 
#nullable restore
#line 55 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                  jugadas.TipoJugadaId

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jugadas.TipoJugadaId = __value, jugadas.TipoJugadaId)), 66, () => jugadas.TipoJugadaId, 67, (__builder3) => {
                    __builder3.AddMarkupContent(68, "<option value=\"0\" disabled> Seleccione </option>");
#nullable restore
#line 57 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                         foreach (var tipoJugada in lista)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(69, "option");
                    __builder3.AddAttribute(70, "value", 
#nullable restore
#line 59 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                            tipoJugada.TipoJugadaId

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (59,72)-(59,95) 26 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
__builder3.AddContent(71, tipoJugada.NombreJugada);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 60 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(72, "\n                      ");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateValidationMessage_5(__builder2, 73, 74, 
#nullable restore
#line 62 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                () => jugadas.TipoJugadaId

#line default
#line hidden
#nullable disable
                , 75, "form-control");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-12");
                __builder2.AddMarkupContent(79, "<label>Monto Jugado</label>\n                    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "input-group mb-3");
                __Blazor.ProyectoFinal.Pages.Registro.R_Tickets.TypeInference.CreateInputNumber_6(__builder2, 82, 83, "form-control", 84, 
#nullable restore
#line 69 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                       jugadas.Monto

#line default
#line hidden
#nullable disable
                , 85, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => jugadas.Monto = __value, jugadas.Monto)), 86, () => jugadas.Monto);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\n    ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "card-footer d-flex justify-content-center mb-4");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "btn-group");
                __builder2.AddAttribute(92, "role", "group");
                __builder2.OpenElement(93, "button");
                __builder2.AddAttribute(94, "type", "button");
                __builder2.AddAttribute(95, "class", "btn btn-primary");
                __builder2.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                    Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(97, "<i class=\"oi oi-file\"> Nuevo\n                </i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\n            ");
                __builder2.AddMarkupContent(99, "<button type=\"submit\" class=\"btn btn-success\"><i class=\"oi oi-document\"> Guardar </i></button>\n            ");
                __builder2.OpenElement(100, "button");
                __builder2.AddAttribute(101, "type", "button");
                __builder2.AddAttribute(102, "class", "btn btn-danger");
                __builder2.AddAttribute(103, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
                                                                   Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(104, "<i class=\"oi oi-trash\"> Eliminar\n                </i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "row  d-flex justify-content-end mb-3");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-3");
                __builder2.AddMarkupContent(110, "<label>Monto Jugado</label>\n            ");
                __builder2.OpenElement(111, "span");
                __builder2.AddAttribute(112, "class", "form-control");
#nullable restore
#line (90,42)-(90,55) 27 "C:\Users\Lora\OneDrive\Escritorio\Proyecto Final AP1\ProyectoFinal\Pages\Registro\R_Tickets.razor"
__builder2.AddContent(113, jugadas.Monto);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.ProyectoFinal.Pages.Registro.R_Tickets
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
