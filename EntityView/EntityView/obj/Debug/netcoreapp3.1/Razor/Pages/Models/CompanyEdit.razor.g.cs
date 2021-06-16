#pragma checksum "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6143980c13d277b723715b6c73c8a4f337215c1b"
// <auto-generated/>
#pragma warning disable 1591
namespace EntityView.Pages.Models
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 3 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
using EntityView.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/company/{id}")]
    public partial class CompanyEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 22 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
     PageTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n");
            __builder.OpenElement(3, "p");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
                      _company

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 26 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
                                                SubmitMe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<label for=\"CompanyName\" class=\"col-sm-2 control-label\">Name</label>\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-sm-10");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "text");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "name", "CompanyName");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
                                                                                   _company.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _company.CompanyName = __value, _company.CompanyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.AddMarkupContent(33, "<label for=\"InternalName\" class=\"col-sm-2 control-label\">Internal Name</label>\r\n            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "col-sm-10");
                __builder2.AddMarkupContent(36, "\r\n                ");
                __builder2.OpenElement(37, "input");
                __builder2.AddAttribute(38, "type", "text");
                __builder2.AddAttribute(39, "class", "form-control");
                __builder2.AddAttribute(40, "name", "InternalName");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
                                                                                    _company.InternalName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _company.InternalName = __value, _company.InternalName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.AddMarkupContent(49, "<label for=\"Address\" class=\"col-sm-2 control-label\">Address</label>\r\n            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-sm-10");
                __builder2.AddMarkupContent(52, "\r\n                ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "name", "Address");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
                                                                               _company.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _company.Address = __value, _company.Address));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n        <input type=\"submit\" style=\"float:left; left:60px; width:80px\" class=\"btn-default\" value=\"Submit\">\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n<br><br>\r\n<div id=\"OperationResult\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
 
    private async Task SetBack()
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "BackButton", "<a href=\"/companies\">Back</a>");
    }

    private async Task SetResult(string text)
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "OperationResult", text);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
       

    private string SaveMessage { get; set; } = "";

    private async void SubmitMe()
    {
        var newCompany = System.Text.Json.JsonSerializer.Serialize(_company);
        var content = new StringContent(newCompany, System.Text.Encoding.UTF8, "application/json");
        var response = await Http.PutAsync("company", content);

        if (response.IsSuccessStatusCode)
        {
            if (IsNewInstance)
                SetResult("Successfully created on " + DateTime.Now.ToString());
            else
                SetResult("Successfully updated on " + DateTime.Now.ToString());
        }
        else
        {
            if (IsNewInstance)
                SetResult("Create failed");
            else
                SetResult("Update failed");
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Workspace\projects\EntityView\EntityView\Pages\Models\CompanyEdit.razor"
       
    [Parameter]
    public string id { get; set; }
    private string companyName { get; set; }
    private Company _company { get; set; }
    private string PageTitle { get; set; }
    private bool IsNewInstance { get; set; } = true;

    protected override async Task OnInitializedAsync()
    {
        SetBack();

        var response = Http.GetAsync($"company/{id}").Result;

        if (string.IsNullOrEmpty(id) || id == "0")
        {
            IsNewInstance = true;
            PageTitle = "New Company";

            _company = new Company();
        }
        else
        {
            IsNewInstance = false;
            PageTitle = "Edit " + companyName;

            if (response.IsSuccessStatusCode)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                _company = JsonConvert.DeserializeObject<Company>(jsonContent);
                companyName = _company.CompanyName;
            }
            else
            {
                SetResult("Object not found");
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
