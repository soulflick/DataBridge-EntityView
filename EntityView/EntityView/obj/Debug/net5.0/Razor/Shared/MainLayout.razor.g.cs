#pragma checksum "C:\Workspace\projects\EntityView\EntityView\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "096346bbb52abe54dc7d32ae90de632661b43c98"
// <auto-generated/>
#pragma warning disable 1591
namespace EntityView.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using EntityView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Workspace\projects\EntityView\EntityView\_Imports.razor"
using EntityView.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page vertically-stretched");
            __builder.AddAttribute(2, "b-uv86nwb7x0");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar vertically-stretched");
            __builder.AddAttribute(5, "style", "background:#333333");
            __builder.AddAttribute(6, "b-uv86nwb7x0");
            __builder.OpenComponent<EntityView.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main vertically-stretched");
            __builder.AddAttribute(11, "b-uv86nwb7x0");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "top-row px-4");
            __builder.AddAttribute(14, "style", "text-align:left");
            __builder.AddAttribute(15, "b-uv86nwb7x0");
            __builder.AddMarkupContent(16, "<div id=\"BackButton\" style=\"left:0px; width:100%; float:left\" b-uv86nwb7x0></div>\r\n\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "b-uv86nwb7x0");
            __builder.OpenElement(19, "nobr");
            __builder.AddAttribute(20, "b-uv86nwb7x0");
            __builder.AddContent(21, 
#nullable restore
#line 16 "C:\Workspace\projects\EntityView\EntityView\Shared\MainLayout.razor"
                     Now.DayOfWeek

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, ", ");
            __builder.AddContent(23, 
#nullable restore
#line 16 "C:\Workspace\projects\EntityView\EntityView\Shared\MainLayout.razor"
                                     Now.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "content px-4 vertically-stretched");
            __builder.AddAttribute(27, "b-uv86nwb7x0");
            __builder.AddContent(28, 
#nullable restore
#line 22 "C:\Workspace\projects\EntityView\EntityView\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Workspace\projects\EntityView\EntityView\Shared\MainLayout.razor"
       
    private DateTime Now = DateTime.Now;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591