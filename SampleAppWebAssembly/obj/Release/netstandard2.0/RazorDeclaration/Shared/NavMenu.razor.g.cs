#pragma checksum "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563a2f2e76fc67aac244e849bf90f37879b202fc"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SampleAppWebAssembly.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using SampleAppWebAssembly;

#line default
#line hidden
#line 7 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\_Imports.razor"
using SampleAppWebAssembly.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "C:\Dev\BlazorScopedCss\SampleAppWebAssembly\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
