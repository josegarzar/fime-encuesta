#pragma checksum "C:\Users\Cursos-FSW\SimpleApp\Views\Shared\_ValidationScriptsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78c1f938057b2e8b1ce3cb27408e59eb68197935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ValidationScriptsPartial), @"mvc.1.0.view", @"/Views/Shared/_ValidationScriptsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ValidationScriptsPartial.cshtml", typeof(AspNetCore.Views_Shared__ValidationScriptsPartial))]
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
#line 1 "C:\Users\Cursos-FSW\SimpleApp\Views\_ViewImports.cshtml"
using SimpleApp;

#line default
#line hidden
#line 2 "C:\Users\Cursos-FSW\SimpleApp\Views\_ViewImports.cshtml"
using SimpleApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78c1f938057b2e8b1ce3cb27408e59eb68197935", @"/Views/Shared/_ValidationScriptsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d72a62fb88dfd66b0040ca2073acca6ef36c73f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ValidationScriptsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1181, true);
            WriteLiteral(@"<!-- <environment include=""Development"">
    <script src=""~/lib/jquery-validation/dist/jquery.validate.js""></script>
    <script src=""~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js""></script>
</environment>
<environment exclude=""Development"">
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validate/1.17.0/jquery.validate.min.js""
            asp-fallback-src=""~/lib/jquery-validation/dist/jquery.validate.min.js""
            asp-fallback-test=""window.jQuery && window.jQuery.validator""
            crossorigin=""anonymous""
            integrity=""sha384-rZfj/ogBloos6wzLGpPkkOr/gpkBNLZ6b6yLy4o+ok+t/SAKlL5mvXLr0OXNi1Hp"">
    </script>
    <script src=""https://ajax.aspnetcdn.com/ajax/jquery.validation.unobtrusive/3.2.9/jquery.validate.unobtrusive.min.js""
            asp-fallback-src=""~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js""
            asp-fallback-test=""window.jQuery && window.jQuery.validator && window.jQuery.validator.unobtrusive""
            c");
            WriteLiteral("rossorigin=\"anonymous\"\r\n            integrity=\"sha384-ifv0TYDWxBHzvAk2Z0n8R434FL1Rlv/Av18DXE43N/1rvHyOG4izKst0f2iSLdds\">\r\n    </script>\r\n</environment> -->\r\n");
            EndContext();
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
