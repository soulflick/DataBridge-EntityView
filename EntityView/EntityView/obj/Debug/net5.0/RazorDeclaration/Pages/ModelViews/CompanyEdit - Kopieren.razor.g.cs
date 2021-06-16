// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EntityView.Pages.ModelViews
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
#line 3 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\CompanyEdit - Kopieren.razor"
using EntityView.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\CompanyEdit - Kopieren.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\CompanyEdit - Kopieren.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/company/{id}")]
    public partial class CompanyEdit___Kopieren : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\CompanyEdit - Kopieren.razor"
 
    private async Task SetBack()
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "BackButton", "<a href=\"/companies\">Back</a> / <a href=\"company/0\">New</a>");
    }

    private async Task SetResult(string text)
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "OperationResult", text);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\CompanyEdit - Kopieren.razor"
       

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
#line 86 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\CompanyEdit - Kopieren.razor"
       
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

            PageTitle = "Edit " + companyName;
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