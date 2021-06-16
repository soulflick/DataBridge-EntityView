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
#line 3 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Factories.razor"
using EntityView.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Factories.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Factories.razor"
using Data = EntityView.Services.DataService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factories")]
    public partial class Factories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Factories.razor"
 
    private async Task SetBack()
    {
        JS.InvokeAsync<bool>("setInnnerHTML", "BackButton", "<a href=\"/\">Home</a> /<a href=\"/factory/0\">New</a>");
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Factories.razor"
           

        void SubmitMe()
        {
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\Factories.razor"
           

        [Parameter]
        public string Filter { get; set; }

        [Parameter]
        public string OrderColumn { get; set; }

        string ThisTableText { get; set; }

        public RenderFragment Fragment { get; set; }


        public List<Factory> _factories { get; set; }

        private async void Delete(Guid id)
        {
            bool confirmed = await JS.InvokeAsync<bool>("confirm", "Are you sure  you want to delete this record?");
            if (confirmed)
            {
                var response = await Http.DeleteAsync($"factory/{id}");
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
            _factories = Data.GetAll<Factory>("factories");
            StateHasChanged();

            foreach (Factory _fct in _factories)
            {
                if (_fct.CompanyId != Guid.Empty)
                    _fct.CompanyName = Data.Get<Company>($"company/{_fct.CompanyId}").CompanyName;
            }
        }

        private void  SortTable(string propertyName)
        {
            EntityView.Creations.NetGrid.SortTable<Factory>(_factories, propertyName, SortState);
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
