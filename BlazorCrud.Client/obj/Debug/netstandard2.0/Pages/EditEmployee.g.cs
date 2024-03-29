#pragma checksum "C:\Users\bins\Desktop\BlazorCrud\BlazorCrud\BlazorCrud.Client\Pages\EditEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd2fb547d19f30ad7cc647e5971d5137d5ddf5e1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using BlazorCrud.Client;
    using BlazorCrud.Client.Shared;
    using BlazorCrud.Shared.Models;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/editemployee/{empID}")]
    public class EditEmployee : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<h2>Edit</h2>\n");
            builder.AddMarkupContent(1, "<h4>Employees</h4>\n<hr>\n");
            builder.OpenElement(2, "div");
            builder.AddAttribute(3, "class", "row");
            builder.AddContent(4, "\n    ");
            builder.OpenElement(5, "div");
            builder.AddAttribute(6, "class", "col-md-4");
            builder.AddContent(7, "\n        ");
            builder.OpenElement(8, "form");
            builder.AddContent(9, "\n            ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "form-group");
            builder.AddContent(12, "\n                ");
            builder.AddMarkupContent(13, "<label for=\"Name\" class=\"control-label\">Name</label>\n                ");
            builder.OpenElement(14, "input");
            builder.AddAttribute(15, "for", "Name");
            builder.AddAttribute(16, "class", "form-control");
            builder.AddAttribute(17, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(emp.Name));
            builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => emp.Name = __value, emp.Name));
            builder.CloseElement();
            builder.AddContent(19, "\n            ");
            builder.CloseElement();
            builder.AddContent(20, "\n            ");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "class", "form-group");
            builder.AddContent(23, "\n                ");
            builder.AddMarkupContent(24, "<label asp-for=\"Gender\" class=\"control-label\">Gender</label>\n                ");
            builder.OpenElement(25, "select");
            builder.AddAttribute(26, "asp-for", "Gender");
            builder.AddAttribute(27, "class", "form-control");
            builder.AddAttribute(28, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(emp.Gender));
            builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => emp.Gender = __value, emp.Gender));
            builder.AddContent(30, "\n                    ");
            builder.AddMarkupContent(31, "<option value=\"\">-- Select Gender --</option>\n                    ");
            builder.AddMarkupContent(32, "<option value=\"Male\">Male</option>\n                    ");
            builder.AddMarkupContent(33, "<option value=\"Female\">Female</option>\n                ");
            builder.CloseElement();
            builder.AddContent(34, "\n            ");
            builder.CloseElement();
            builder.AddContent(35, "\n            ");
            builder.OpenElement(36, "div");
            builder.AddAttribute(37, "class", "form-group");
            builder.AddContent(38, "\n                ");
            builder.AddMarkupContent(39, "<label asp-for=\"Department\" class=\"control-label\">Department</label>\n                ");
            builder.OpenElement(40, "input");
            builder.AddAttribute(41, "asp-for", "Department");
            builder.AddAttribute(42, "class", "form-control");
            builder.AddAttribute(43, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(emp.Department));
            builder.AddAttribute(44, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => emp.Department = __value, emp.Department));
            builder.CloseElement();
            builder.AddContent(45, "\n            ");
            builder.CloseElement();
            builder.AddContent(46, "\n            ");
            builder.OpenElement(47, "div");
            builder.AddAttribute(48, "class", " form-group");
            builder.AddContent(49, "\n                ");
            builder.AddMarkupContent(50, "<label asp-for=\"City\" class=\"control-label\">City</label>\n                ");
            builder.OpenElement(51, "input");
            builder.AddAttribute(52, "asp-for", "City");
            builder.AddAttribute(53, "class", "form-control");
            builder.AddAttribute(54, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(emp.City));
            builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => emp.City = __value, emp.City));
            builder.CloseElement();
            builder.AddContent(56, "\n            ");
            builder.CloseElement();
            builder.AddContent(57, "\n            ");
            builder.OpenElement(58, "div");
            builder.AddAttribute(59, "class", "form-group");
            builder.AddContent(60, "\n                ");
            builder.OpenElement(61, "input");
            builder.AddAttribute(62, "type", "submit");
            builder.AddAttribute(63, "value", "Save");
            builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(async () => await UpdateEmployee()));
            builder.AddAttribute(65, "class", "btn btn-default");
            builder.CloseElement();
            builder.AddContent(66, "\n                ");
            builder.OpenElement(67, "input");
            builder.AddAttribute(68, "type", "submit");
            builder.AddAttribute(69, "value", "Cancel");
            builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(cancel));
            builder.AddAttribute(71, "class", "btn");
            builder.CloseElement();
            builder.AddContent(72, "\n            ");
            builder.CloseElement();
            builder.AddContent(73, "\n        ");
            builder.CloseElement();
            builder.AddContent(74, "\n    ");
            builder.CloseElement();
            builder.AddContent(75, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 40 "C:\Users\bins\Desktop\BlazorCrud\BlazorCrud\BlazorCrud.Client\Pages\EditEmployee.cshtml"
            

[Parameter]
string empID { get; set; }

Employee emp = new Employee();

protected override async Task OnInitAsync()
{
    emp = await Http.GetJsonAsync<Employee>("/api/Employee/Details/" + Convert.ToInt32(empID));
}

protected async Task UpdateEmployee()
{
    await Http.SendJsonAsync(HttpMethod.Put, "api/Employee/Edit", emp);
    UriHelper.NavigateTo("/fetchemployee");

}

void cancel()
{
    UriHelper.NavigateTo("/fetchemployee");

}


#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private Microsoft.AspNetCore.Blazor.Services.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
