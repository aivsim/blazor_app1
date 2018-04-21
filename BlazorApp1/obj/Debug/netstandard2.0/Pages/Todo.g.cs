#pragma checksum "E:\Projects\BlazorApp1\BlazorApp1\Pages\Todo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e54cdabae73774e2be8e85a7b1c450d4608e99c5"
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
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/todo")]
    public class Todo : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddContent(0, "\n");
            builder.OpenElement(1, "h1");
            builder.AddContent(2, "Todo (");
            builder.AddContent(3, todos.Where(todo => !todo.IsDone).Count());
            builder.AddContent(4, ")");
            builder.CloseElement();
            builder.AddContent(5, "\n\n");
            builder.OpenElement(6, "ul");
            builder.AddContent(7, "\n");
#line 6 "E:\Projects\BlazorApp1\BlazorApp1\Pages\Todo.cshtml"
     foreach (var todo in todos)
    {

#line default
#line hidden
            builder.AddContent(8, "        ");
            builder.OpenElement(9, "li");
            builder.AddContent(10, "\n            ");
            builder.OpenElement(11, "input");
            builder.AddAttribute(12, "type", "checkbox");
            builder.AddAttribute(13, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(todo.IsDone));
            builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => todo.IsDone = __value, todo.IsDone));
            builder.CloseElement();
            builder.AddContent(15, "\n            ");
            builder.OpenElement(16, "input");
            builder.AddAttribute(17, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(todo.Title));
            builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => todo.Title = __value, todo.Title));
            builder.CloseElement();
            builder.AddContent(19, "\n        ");
            builder.CloseElement();
            builder.AddContent(20, "\n");
#line 12 "E:\Projects\BlazorApp1\BlazorApp1\Pages\Todo.cshtml"
    }

#line default
#line hidden
            builder.CloseElement();
            builder.AddContent(21, "\n\n");
            builder.OpenElement(22, "input");
            builder.AddAttribute(23, "placeholder", "Something todo");
            builder.AddAttribute(24, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(newTodo));
            builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => newTodo = __value, newTodo));
            builder.CloseElement();
            builder.AddContent(26, "\n");
            builder.OpenElement(27, "button");
            builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(AddTodo));
            builder.AddContent(29, "Add todo");
            builder.CloseElement();
            builder.AddContent(30, "\n\n");
        }
        #pragma warning restore 1998
#line 18 "E:\Projects\BlazorApp1\BlazorApp1\Pages\Todo.cshtml"
            
    IList<TodoItem> todos = new List<TodoItem>();
    string newTodo;

    void AddTodo()
    {
        if (!String.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = "";
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
