#pragma checksum "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9307124dd3d987399cfc4da4f7e5dc8558853d96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Delete), @"mvc.1.0.view", @"/Views/User/Delete.cshtml")]
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
#line 1 "D:\Nam3\framework\test\LapTop\LapTop\Views\_ViewImports.cshtml"
using LapTop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam3\framework\test\LapTop\LapTop\Views\_ViewImports.cshtml"
using LapTop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9307124dd3d987399cfc4da4f7e5dc8558853d96", @"/Views/User/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a53b268c9cb016cea4365a2cfa183cf5e714c88", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LapTop.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Delete</h4>\r\n        <hr />\r\n       \r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
       Write(Html.LabelFor(model => model.Tentaikhoan, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
           Write(Html.EditorFor(model => model.Tentaikhoan, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 25 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
       Write(Html.LabelFor(model => model.Matkhau, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 27 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
           Write(Html.EditorFor(model => model.Matkhau, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <button type=\"submit\" class=\"btn btn-danger\">Xóa</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 40 "D:\Nam3\framework\test\LapTop\LapTop\Views\User\Delete.cshtml"
Write(Html.ActionLink("Trở về trang chủ", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LapTop.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
