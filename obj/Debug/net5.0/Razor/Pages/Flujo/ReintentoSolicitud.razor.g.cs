#pragma checksum "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab28b884ef39878171277b9d2166ba2445de5168"
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
#line 2 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
using Elsa.Activities.Workflows.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
using Elsa.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Flujo/ReintentoSolicitud/{IdSolicitud:int}")]
    public partial class ReintentoSolicitud : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-signup");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                      SolicitudGenerica

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                         HandleFormSubmission

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "hidden", 
#nullable restore
#line 9 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                                                        ShowConfirmation

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "<h1 class=\"h3 mb-3 font-weight-normal\">Reintento de Solicitud</h1>\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "id", "nombre");
                __builder2.AddAttribute(15, "placeholder", "Nombre");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
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
                __builder2.AddAttribute(22, "type", "email");
                __builder2.AddAttribute(23, "id", "email");
                __builder2.AddAttribute(24, "placeholder", "Email");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                         SolicitudGenerica.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Email = __value, SolicitudGenerica.Email))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "id", "telefono");
                __builder2.AddAttribute(33, "placeholder", "Telefono");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                           SolicitudGenerica.Telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Telefono = __value, SolicitudGenerica.Telefono))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Telefono));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "type", "text");
                __builder2.AddAttribute(41, "disabled", "true");
                __builder2.AddAttribute(42, "id", "rut");
                __builder2.AddAttribute(43, "placeholder", "Rut");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                                      SolicitudGenerica.Rut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Rut = __value, SolicitudGenerica.Rut))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Rut));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(49);
                __builder2.AddAttribute(50, "type", "text");
                __builder2.AddAttribute(51, "id", "producto");
                __builder2.AddAttribute(52, "placeholder", "Producto");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                           SolicitudGenerica.Producto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Producto = __value, SolicitudGenerica.Producto))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Producto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "type", "text");
                __builder2.AddAttribute(60, "id", "origen");
                __builder2.AddAttribute(61, "placeholder", "Origen del Producto");
                __builder2.AddAttribute(62, "class", "form-control");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                         SolicitudGenerica.Origen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.Origen = __value, SolicitudGenerica.Origen))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.Origen));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "type", "text");
                __builder2.AddAttribute(69, "id", "nombreQuimico");
                __builder2.AddAttribute(70, "placeholder", "Nombre del Quimico");
                __builder2.AddAttribute(71, "class", "form-control");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                                                SolicitudGenerica.NombreQuimico

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SolicitudGenerica.NombreQuimico = __value, SolicitudGenerica.NombreQuimico))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => SolicitudGenerica.NombreQuimico));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n\r\n        ");
                __builder2.AddMarkupContent(76, "<button type=\"submit\" class=\"btn btn-lg btn-primary btn-block\">Enviar</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n\r\n    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "hidden", 
#nullable restore
#line 28 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                   !ShowConfirmation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(80, "\r\n        Solicitud enviada, Te estaremos informando!!\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "form-signup");
            __builder.AddAttribute(84, "hidden", 
#nullable restore
#line 32 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                                   ShowConfirmation

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "<h1 class=\"h3 mb-3 font-weight-normal\">Logs</h1>\r\n    ");
            __builder.OpenElement(86, "table");
            __builder.AddAttribute(87, "class", "table");
            __builder.AddMarkupContent(88, "<thead><tr><th></th>\r\n                <th>Descripción</th></tr></thead>\r\n        ");
            __builder.OpenElement(89, "tbody");
#nullable restore
#line 42 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
             foreach (var item in SolicitudGenerica.Logs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "tr");
            __builder.OpenElement(91, "td");
            __builder.AddContent(92, 
#nullable restore
#line 45 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
                         item.Log

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\ReintentoSolicitud.razor"
       
    [Parameter] public int IdSolicitud { get; set; }

    private SolicitudGenerica SolicitudGenerica { get; set; } = new SolicitudGenerica();
    private bool ShowConfirmation { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        SolicitudGenerica = await context.SolicitudesGenericas.Include(x => x.Logs).FirstOrDefaultAsync(x => x.Id == IdSolicitud);
    }

    private async Task HandleFormSubmission()
    {
        var input = new Variables();
        input.SetVariable("SolicitudGenericaModel", SolicitudGenerica);

        await WorkflowInvoker.TriggerSignalAsync("Reingreso", input, correlationId: SolicitudGenerica.Rut);

        ShowConfirmation = true;
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
