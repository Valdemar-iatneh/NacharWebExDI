#pragma checksum "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Registration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac97cddb11e317254ae17e265bf0ed40d79f526"
// <auto-generated/>
#pragma warning disable 1591
namespace ProductAppWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using ProductAppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\_Imports.razor"
using ProductAppWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Registration.razor"
using ProductAppWeb.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Registration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "Registration");
            __builder.AddMarkupContent(2, "<p><b>??????:</b></p>\r\n    ");
            __builder.OpenElement(3, "p");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Registration.razor"
                                       user.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Name = __value, user.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.AddMarkupContent(9, "<p><b>??????????:</b></p>\r\n    ");
            __builder.OpenElement(10, "p");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Registration.razor"
                                       user.Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Login = __value, user.Login));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.AddMarkupContent(16, "<p><b>????????????:</b></p>\r\n    ");
            __builder.OpenElement(17, "p");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Registration.razor"
                                       user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Registration.razor"
       
    public static List<User> userList;
    private string Name;
    private string Login;
    private string Password;

    public void Registr ()
    {
        user = new User(Name, Login, Password);
        NavigationManager.NavigateTo("/fetchdata");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private User user { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
