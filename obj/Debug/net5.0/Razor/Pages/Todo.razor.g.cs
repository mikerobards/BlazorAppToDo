#pragma checksum "C:\Users\miker\Projects\BlazorAppToDo\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf176f85b46c5f892d9d12fd475eec17d412ed50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppToDo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using BlazorAppToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\miker\Projects\BlazorAppToDo\_Imports.razor"
using BlazorAppToDo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todo</h3>\r\n\r\n");
            __builder.OpenElement(1, "ul");
#nullable restore
#line 6 "C:\Users\miker\Projects\BlazorAppToDo\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.AddContent(3, 
#nullable restore
#line 8 "C:\Users\miker\Projects\BlazorAppToDo\Pages\Todo.razor"
             todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\miker\Projects\BlazorAppToDo\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\miker\Projects\BlazorAppToDo\Pages\Todo.razor"
       
    private List<TodoItem> todos = new();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
