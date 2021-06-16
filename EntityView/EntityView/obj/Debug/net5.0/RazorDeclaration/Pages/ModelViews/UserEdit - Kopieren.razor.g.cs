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
#line 3 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit - Kopieren.razor"
using EntityView.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit - Kopieren.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit - Kopieren.razor"
using Data = EntityView.Services.DataService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/{id}")]
    public partial class UserEdit___Kopieren : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit - Kopieren.razor"
 
    private async Task SetBack()
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "BackButton", "<a href=\"/users\">Back</a> / <a href=\"user/0\">New</a>");
    }

    private async Task SetResult(string text)
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "OperationResult", text);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit - Kopieren.razor"
       

    public object _object;

    private string SaveMessage { get; set; } = "";

    private async void SubmitMe()
    {
        var newUser = System.Text.Json.JsonSerializer.Serialize(_user);
        var content = new StringContent(newUser, System.Text.Encoding.UTF8, "application/json");
        var response = await Http.PutAsync("user", content);

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
#line 105 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit - Kopieren.razor"
       
    [Parameter]
    public string id { get; set; }

    private User _user { get; set; }
    public string _companyName;

    private string userName { get; set; }

    private string PageTitle { get; set; }
    private bool IsNewInstance { get; set; } = true;

    private List<Company> _companies { get; set; }
    private List<Factory> _factories { get; set; }

    protected override async Task OnInitializedAsync()
    {
        SetBack();

        if (string.IsNullOrEmpty(id) || id == "0")
        {
            IsNewInstance = true;
            PageTitle = "New User";
            _user = new User();
        }
        else
        {
            IsNewInstance = false;
            _user = Data.Get<User>($"user/{id}");

            if (_user != null)
            {
                userName = _user.UserName;
            }
            else
            {
                SetResult("Object not found");
            }

            PageTitle = "Edit " + userName;
        }

        _companies = Data.GetAll<Company>("companies");
        _factories = Data.GetAll<Factory>("factories");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
