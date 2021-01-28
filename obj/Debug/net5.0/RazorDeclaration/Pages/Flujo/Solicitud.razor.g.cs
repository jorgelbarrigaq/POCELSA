// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Solicitud.razor"
using Elsa.Activities.Workflows.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Solicitud.razor"
using Elsa.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Solicitud : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Trabajo\Kibernum\ISP Motor Procesos\Repo\POCELSA\Pages\Flujo\Solicitud.razor"
       
    private SolicitudGenerica SolicitudGenerica { get; set; } = new SolicitudGenerica();
    private bool ShowConfirmation { get; set; } = false;


    private async Task HandleFormSubmission()
    {
        var input = new Variables();
        input.SetVariable("SolicitudGenericaModel", SolicitudGenerica);

        await WorkflowInvoker.TriggerSignalAsync("AprobacionSolicitud", input, correlationId: SolicitudGenerica.Rut);

        ShowConfirmation = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbContext context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWorkflowInvoker WorkflowInvoker { get; set; }
    }
}
#pragma warning restore 1591
