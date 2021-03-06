#pragma checksum "E:\Projects\BlazorApp1\BlazorApp1\Pages\Todo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e54cdabae73774e2be8e85a7b1c450d4608e99c5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
