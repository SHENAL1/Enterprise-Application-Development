#pragma checksum "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0d21214afb8bde48159c863a7fcfafa20bb2af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todos_Index), @"mvc.1.0.view", @"/Views/Todos/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0d21214afb8bde48159c863a7fcfafa20bb2af", @"/Views/Todos/Index.cshtml")]
    public class Views_Todos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tutorial07.Shared.Todo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 772, "\"", 795, 1);
#nullable restore
#line 34 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
WriteAttributeValue("", 787, item.Id, 787, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 848, "\"", 871, 1);
#nullable restore
#line 35 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
WriteAttributeValue("", 863, item.Id, 863, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 926, "\"", 949, 1);
#nullable restore
#line 36 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
WriteAttributeValue("", 941, item.Id, 941, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "F:\Documents\Level-6\Enterprise Application\Week 7\Tutorial07\Server\Views\Todos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tutorial07.Shared.Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591