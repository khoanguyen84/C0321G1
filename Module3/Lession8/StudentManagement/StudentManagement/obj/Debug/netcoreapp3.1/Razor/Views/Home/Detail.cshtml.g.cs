#pragma checksum "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6a3039f89ef31f9775c69503d178ad58386d24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6a3039f89ef31f9775c69503d178ad58386d24", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f54a46a44bdbf3bf9f69710451470544d94c8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml"
  
    ViewBag.Title = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>More information of ");
#nullable restore
#line 6 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml"
                   Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"card\">\r\n    <div class=\"card-header bg-success\">\r\n        <h3>");
#nullable restore
#line 9 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml"
       Write(Model.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-4\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 322, "", 353, 1);
#nullable restore
#line 14 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml"
WriteAttributeValue("", 327, Url.Content(Model.Avatar), 327, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\"/>\r\n            </div>\r\n            <div class=\"col-sm-8\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-2\">StudentId</div>\r\n                    <div class=\"col-sm-10\">");
#nullable restore
#line 19 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml"
                                      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-2\">Date of birth</div>\r\n                    <div class=\"col-sm-10\">");
#nullable restore
#line 23 "C:\CodeGym\Class\C0321G1\Module3\Lession8\StudentManagement\StudentManagement\Views\Home\Detail.cshtml"
                                      Write(Model.Dob.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer\">\r\n        <a href=\"/\" class=\"btn btn-warning\">Back</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
