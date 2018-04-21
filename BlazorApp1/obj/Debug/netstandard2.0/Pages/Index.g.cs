#pragma checksum "E:\Projects\BlazorApp1\BlazorApp1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "719d30be187d453d27af237e4eee4310261944b1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorApp1;
    using BlazorApp1.Shared;
    using BlazorLib1;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddContent(0, "\n");
            builder.OpenElement(1, "h1");
            builder.AddContent(2, "Hello, world!");
            builder.CloseElement();
            builder.AddContent(3, "\n\nWelcome to your new app.bbb\n\n");
            builder.OpenComponent<BlazorApp1.Shared.SurveyPrompt>(4);
            builder.AddAttribute(5, "Title", "How is Blazor working for you?");
            builder.CloseComponent();
            builder.AddContent(6, "\n\n");
            builder.OpenComponent<BlazorApp1.Pages.Counter>(7);
            builder.AddAttribute(8, "Value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(CurrentValue));
            builder.AddAttribute(9, "ValueChanged", new System.Action<System.Int32>(__value => CurrentValue = __value));
            builder.CloseComponent();
            builder.AddContent(10, "\n");
            builder.OpenComponent<BlazorLib1.Component1>(11);
            builder.CloseComponent();
            builder.AddContent(12, "\n\n");
        }
        #pragma warning restore 1998
#line 14 "E:\Projects\BlazorApp1\BlazorApp1\Pages\Index.cshtml"
            
    public int CurrentValue { get; set; } = 11;

#line default
#line hidden
    }
}
#pragma warning restore 1591
