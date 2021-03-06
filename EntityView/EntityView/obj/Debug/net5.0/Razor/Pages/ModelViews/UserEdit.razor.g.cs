#pragma checksum "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d4004ae99aa75e15a3fa6db9978ca334509dd75"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
using EntityView.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
using Data = EntityView.Services.DataService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/{id}")]
    public partial class UserEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-header");
            __builder.AddContent(2, 
#nullable restore
#line 22 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                          PageTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                      _user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 26 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                             SubmitMe

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label for=\"UserName\" class=\"col-sm-2 control-label\">User Name</label>\r\n            ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-sm-10");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "name", "CompanyName");
                __builder2.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                                                                   _user.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.UserName = __value, _user.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label for=\"Company\" class=\"col-sm-2 control-label\">Company</label>\r\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col-sm-10");
                __Blazor.EntityView.Pages.ModelViews.UserEdit.TypeInference.CreateInputSelect_0(__builder2, 30, 31, "department", 32, "min-width:300px; padding:5px;", 33, 
#nullable restore
#line 40 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                                          _user.CompanyId

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _user.CompanyId = __value, _user.CompanyId)), 35, () => _user.CompanyId, 36, (__builder3) => {
#nullable restore
#line 41 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                     if (_companies != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                         foreach (var company in _companies)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(37, "option");
                    __builder3.AddAttribute(38, "value", 
#nullable restore
#line 45 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                            company.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(39, 
#nullable restore
#line 45 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                                         company.CompanyName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 46 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"Factory\" class=\"col-sm-2 control-label\">Factory</label>\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col-sm-10");
                __Blazor.EntityView.Pages.ModelViews.UserEdit.TypeInference.CreateInputSelect_1(__builder2, 46, 47, "factory", 48, "min-width:300px; padding:5px;", 49, 
#nullable restore
#line 55 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                                       _user.FactoryId

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _user.FactoryId = __value, _user.FactoryId)), 51, () => _user.FactoryId, 52, (__builder3) => {
#nullable restore
#line 56 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                     if (_factories != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                         foreach (var factory in _factories)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(53, "option");
                    __builder3.AddAttribute(54, "value", 
#nullable restore
#line 60 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                            factory.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(55, 
#nullable restore
#line 60 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                                                         factory.FactoryName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 61 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
                         
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n\r\n        <input type=\"submit\" style=\"float:left; left:60px; width:80px\" class=\"btn-default\" value=\"Submit\">");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n<br>\r\n<br>\r\n<div id=\"OperationResult\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
 
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
#line 76 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
       

    public object _object;

    private string SaveMessage { get; set; } = "";

    private async void SubmitMe()
    {
        var newUser = System.Text.Json.JsonSerializer.Serialize(_user);
        var content = new StringContent(newUser, System.Text.Encoding.UTF8, "application/json");
        var response = await Http.PutAsync("user", content);

        SetResult(EntityView.Classes.Utils.GetStateString(response.IsSuccessStatusCode, IsNewInstance));
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Workspace\projects\EntityView\EntityView\Pages\ModelViews\UserEdit.razor"
       
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
namespace __Blazor.EntityView.Pages.ModelViews.UserEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
