#pragma checksum "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\TableTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1f8aa03cc5ccbe95644a0aa150e955b9f403342"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using BlazerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\_Imports.razor"
using BlazerApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class TableTemplate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TableTemplate</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "thead");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\TableTemplate.razor"
             Header

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.AddMarkupContent(12, "<tbody>\r\n    </tbody>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\TableTemplate.razor"
       
    [Parameter]
    public RenderFragment Header { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
