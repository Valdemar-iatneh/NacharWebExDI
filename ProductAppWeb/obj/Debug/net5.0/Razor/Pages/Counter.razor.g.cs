#pragma checksum "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a06bfb4ad1b907572d908fd26c12a5cad3a794f6"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
#nullable restore
#line 6 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor"
__builder.AddContent(6, text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor"
               text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onfocus", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor"
                                                                    ShowText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\vladi\source\repos\ProductAppWeb\ProductAppWeb\Pages\Counter.razor"
       
    private int currentCount = 0;
    private string text = null;

    private async Task IncrementCount(MouseEventArgs e)
    {
        await Task.Delay(500);
        if (e.CtrlKey == true) currentCount += 10;
        else currentCount++;
    }

    private void ShowText(FocusEventArgs f)
    {
        
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591