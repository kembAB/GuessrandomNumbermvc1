#pragma checksum "C:\Users\haile\source\repos\MVCBasicsGussingGameAssignment3Try3\MVCBasicsGussingGameAssignment3Try3\Views\Guesskuprvw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e7e467cf37fa30a632eaa63b836b78ffb84775a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guesskuprvw), @"mvc.1.0.view", @"/Views/Guesskuprvw.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e7e467cf37fa30a632eaa63b836b78ffb84775a", @"/Views/Guesskuprvw.cshtml")]
    public class Views_Guesskuprvw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\haile\source\repos\MVCBasicsGussingGameAssignment3Try3\MVCBasicsGussingGameAssignment3Try3\Views\Guesskuprvw.cshtml"
  
    ViewData["Title"] = "Guessing Game";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\haile\source\repos\MVCBasicsGussingGameAssignment3Try3\MVCBasicsGussingGameAssignment3Try3\Views\Guesskuprvw.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 6 "C:\Users\haile\source\repos\MVCBasicsGussingGameAssignment3Try3\MVCBasicsGussingGameAssignment3Try3\Views\Guesskuprvw.cshtml"
  Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\haile\source\repos\MVCBasicsGussingGameAssignment3Try3\MVCBasicsGussingGameAssignment3Try3\Views\Guesskuprvw.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<form asp-controller=\"GuessingGame\" asp-action=\"Guessnumber\" method=\"post\">\r\n    <label>Your guess:</label>\r\n    <input type=\"number\" name=\"guess\" min=\"1\" />\r\n    <input type=\"submit\" value=\"Guess!\" />\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591