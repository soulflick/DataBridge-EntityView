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
#line 3 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
using EntityView.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
using Data = EntityView.Services.DataService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies")]
    public partial class Companies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
 
    private async Task SetBack()
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "BackButton", "<a href=\"/\">Home</a> /<a href=\"/company/0\">New</a>");
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
           

        void SubmitMe()
        {
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Companies.razor"
           

        [Parameter]
        public string Filter { get; set; }

        [Parameter]
        public string OrderColumn { get; set; }

        string ThisTableText { get; set; }

        public RenderFragment Fragment { get; set; }


        public List<Company> _companies { get; set; }

        private async void Delete(Guid id)
        {
            bool confirmed = await JS.InvokeAsync<bool>("confirm", "Are you sure  you want to delete this record?");
            if (confirmed)
            {
                var response = await Http.DeleteAsync($"company/{id}");
            }

            Refresh();
        }

        protected override async Task OnInitializedAsync()
        {
            SetBack();

            Refresh();
        }

        void Refresh()
        {
            //var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
            //if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("ordercolumn", out var column))
            //{
            //    OrderColumn = column.ToString();
            //}

            _companies = Data.GetAll<Company>("companies");
            StateHasChanged();

        }

        private void SortTable(string propertyName)
        {
            EntityView.Creations.NetGrid.SortTable<Company>(_companies, propertyName, SortState);
        }

        private EntityView.Creations.SortState SortState = new EntityView.Creations.SortState();
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591