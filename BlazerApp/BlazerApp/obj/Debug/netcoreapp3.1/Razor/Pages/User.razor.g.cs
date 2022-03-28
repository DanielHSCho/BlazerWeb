#pragma checksum "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1d66fef688fef715facdb7df63196428e68a32"
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
#nullable restore
#line 3 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
using BlazerApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class User : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Online Users</h3>\r\n\r\n");
            __builder.OpenComponent<BlazerApp.Pages.ShowUser>(1);
            __builder.AddAttribute(2, "Users", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazerApp.Data.UserData>>(
#nullable restore
#line 7 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
                 _users

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n<br>\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "placeholder", "Add User");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
                                                                            _inputName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _inputName = __value, _inputName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", 
#nullable restore
#line 17 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
                            _btnClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
                                                               AddUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 17 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
                                                                                    _users.Count() >= 5

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, "Add a User");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\helle\Projects\2_WebServer\BlazerApp\BlazerApp\BlazerApp\Pages\User.razor"
       
    List<UserData> _users = new List<UserData>();

    string _inputName;
    string _btnClass = "btn btn-primary";

    protected override void OnInitialized()
    {
        _users.Add(new UserData() { Name = "Daniel" });
        _users.Add(new UserData() { Name = "Hellena" });
        _users.Add(new UserData() { Name = "Arsene" });
        RefreshButton();
    }

    void AddUser()
    {
        _users.Add(new UserData() { Name = _inputName });
        _inputName = string.Empty;
        RefreshButton();
    }

    void KickUser(UserData user)
    {
        _users.Remove(user);
        RefreshButton();
    }

    void RefreshButton()
    {
        if(_users.Count() % 2 == 0) {
            _btnClass = "btn btn-primary";
        } else {
            _btnClass = "btn btn-secondary";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
