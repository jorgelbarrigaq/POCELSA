#pragma checksum "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1664556e548f885c5a7c2983216fabd17088bc3c"
// <auto-generated/>
#pragma warning disable 1591
namespace Elsa.Samples.UserRegistration.Web.Pages.Flujo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Elsa.Samples.UserRegistration.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Elsa.Samples.UserRegistration.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Elsa.Samples.UserRegistration.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Elsa.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Elsa.Services.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Elsa.Samples.UserRegistration.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
using Elsa.Activities.Workflows.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
using Elsa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
using Elsa.Activities.Workflows.Activities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Flujo/Gestionar/{IdSolicitud:int}")]
    public partial class Gestionar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-signup");
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "h3 mb-3 font-weight-normal");
            __builder.AddContent(4, "Solicitud de ");
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                         SolicitudGenerica.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                      SolicitudGenerica

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                         HandleFormSubmission

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "disabled", "true");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "id", "nombre");
                __builder2.AddAttribute(15, "placeholder", "Nombre");
                __builder2.AddAttribute(16, "class", "form-control-plaintext");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                         SolicitudGenerica.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Nombre = __value, SolicitudGenerica.Nombre))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "disabled", "true");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "id", "email");
                __builder2.AddAttribute(25, "placeholder", "Email");
                __builder2.AddAttribute(26, "class", "form-control-plaintext");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                        SolicitudGenerica.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Email = __value, SolicitudGenerica.Email))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "disabled", "true");
                __builder2.AddAttribute(33, "type", "text");
                __builder2.AddAttribute(34, "id", "telefono");
                __builder2.AddAttribute(35, "placeholder", "Telefono");
                __builder2.AddAttribute(36, "class", "form-control-plaintext");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                           SolicitudGenerica.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Telefono = __value, SolicitudGenerica.Telefono))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Telefono));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "disabled", "true");
                __builder2.AddAttribute(43, "type", "text");
                __builder2.AddAttribute(44, "id", "rut");
                __builder2.AddAttribute(45, "placeholder", "Rut");
                __builder2.AddAttribute(46, "class", "form-control-plaintext");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                      SolicitudGenerica.Rut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Rut = __value, SolicitudGenerica.Rut))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Rut));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(51);
                __builder2.AddAttribute(52, "disabled", "true");
                __builder2.AddAttribute(53, "type", "text");
                __builder2.AddAttribute(54, "id", "producto");
                __builder2.AddAttribute(55, "placeholder", "Producto");
                __builder2.AddAttribute(56, "class", "form-control-plaintext");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                           SolicitudGenerica.Producto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Producto = __value, SolicitudGenerica.Producto))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Producto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "disabled", "true");
                __builder2.AddAttribute(63, "type", "text");
                __builder2.AddAttribute(64, "id", "origen");
                __builder2.AddAttribute(65, "placeholder", "Origen del Producto");
                __builder2.AddAttribute(66, "class", "form-control-plaintext");
                __builder2.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                         SolicitudGenerica.Origen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Origen = __value, SolicitudGenerica.Origen))));
                __builder2.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Origen));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "disabled", "true");
                __builder2.AddAttribute(73, "type", "text");
                __builder2.AddAttribute(74, "id", "nombreQuimico");
                __builder2.AddAttribute(75, "placeholder", "Nombre del Quimico");
                __builder2.AddAttribute(76, "class", "form-control-plaintext");
                __builder2.AddAttribute(77, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                                SolicitudGenerica.NombreQuimico

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.NombreQuimico = __value, SolicitudGenerica.NombreQuimico))));
                __builder2.AddAttribute(79, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.NombreQuimico));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(81);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(83);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "form-signup");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(87);
            __builder.AddAttribute(88, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                      SolicitudGenericaLog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 32 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                            HandleFormSubmission

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(90, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 32 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                                                EC

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(92);
                __builder2.AddAttribute(93, "id", "log");
                __builder2.AddAttribute(94, "placeholder", "Log de Aprobacion");
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                              SolicitudGenericaLog.Log

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenericaLog.Log = __value, SolicitudGenericaLog.Log))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenericaLog.Log));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(100);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(102);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n        ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "display-1");
                __builder2.OpenElement(106, "p");
                __builder2.OpenElement(107, "button");
                __builder2.AddAttribute(108, "type", "button");
                __builder2.AddAttribute(109, "class", "btn btn-success");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                        () => Aprobar(true)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(111, "Aprobar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "button");
                __builder2.AddAttribute(114, "type", "button");
                __builder2.AddAttribute(115, "class", "btn btn-danger");
                __builder2.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                                                                       () => Aprobar(false)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(117, "Rechazar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "form-signup");
            __builder.AddMarkupContent(121, "<h1 class=\"h3 mb-3 font-weight-normal\">Logs</h1>\r\n    ");
            __builder.OpenElement(122, "table");
            __builder.AddAttribute(123, "class", "table");
            __builder.AddMarkupContent(124, "<thead><tr><th></th>\r\n                <th>Descripción</th></tr></thead>\r\n        ");
            __builder.OpenElement(125, "tbody");
#nullable restore
#line 58 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
             foreach (var item in SolicitudGenerica.Logs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(126, "tr");
            __builder.OpenElement(127, "td");
            __builder.AddContent(128, 
#nullable restore
#line 61 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                         item.Log

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "hidden", 
#nullable restore
#line 69 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
                   !ShowConfirmation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(132, "\r\n        Respuesta enviada!!!\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Gestionar.razor"
       
    [Parameter] public int IdSolicitud { get; set; }
    private EditContext EC { get; set; }
    private SolicitudGenerica SolicitudGenerica { get; set; } = new SolicitudGenerica();
    private SolicitudGenericaLog SolicitudGenericaLog { get; set; } = new SolicitudGenericaLog();
    private bool ShowConfirmation { get; set; } = false;


    protected override async Task OnInitializedAsync()
    {
        SolicitudGenerica = await context.SolicitudesGenericas.Include(x => x.Logs).FirstOrDefaultAsync(x => x.Id == IdSolicitud);
        
    }

    private async Task Aprobar(bool aprobado)
    {
        var input = new Variables();
        input.SetVariable("IdSolicitud", IdSolicitud);
        input.SetVariable("Log", SolicitudGenericaLog.Log);
        input.SetVariable("Aprobado", aprobado);


        await WorkflowInvoker.TriggerSignalAsync("Aprobacion", input, correlationId: SolicitudGenerica.Rut);

        ShowConfirmation = true;
        NavigationManager.NavigateTo("/Flujo/Aprobacion");

    }

    private async Task HandleFormSubmission()
    {
        await Aprobar(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkflowInvoker WorkflowInvoker { get; set; }
    }
}
#pragma warning restore 1591
