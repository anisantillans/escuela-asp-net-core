#pragma checksum "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab888008361a90abdccd3be8e6135141e881773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Asignatura_MultiAsignatura), @"mvc.1.0.view", @"/Views/Asignatura/MultiAsignatura.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Asignatura/MultiAsignatura.cshtml", typeof(AspNetCore.Views_Asignatura_MultiAsignatura))]
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
#line 1 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/_ViewImports.cshtml"
using Facturacion;

#line default
#line hidden
#line 2 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/_ViewImports.cshtml"
using Facturacion.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ab888008361a90abdccd3be8e6135141e881773", @"/Views/Asignatura/MultiAsignatura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153ee7efab221d60c64a3540c1ed58e66c8c7ba0", @"/Views/_ViewImports.cshtml")]
    public class Views_Asignatura_MultiAsignatura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asignatura>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ListaObjetoEscuela", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
  
    ViewData["Title"] = "Información Asignatura";
    Layout = "Simple";

#line default
#line hidden
            BeginContext(114, 8, true);
            WriteLiteral("\r\n\r\n<h1>");
            EndContext();
            BeginContext(123, 17, false);
#line 8 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(140, 54, true);
            WriteLiteral(" </h1>\r\n\r\n<strong> Desde la vista parcial</strong>\r\n\r\n");
            EndContext();
            BeginContext(194, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ab888008361a90abdccd3be8e6135141e8817734290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(230, 20, true);
            WriteLiteral("</partial>\r\n\r\n<p><i>");
            EndContext();
            BeginContext(251, 13, false);
#line 14 "/Users/anapaula/Documents/Repositories/Escuela_asp_net_core/escuela-asp-net-core/Views/Asignatura/MultiAsignatura.cshtml"
 Write(ViewBag.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(264, 9, true);
            WriteLiteral(" </i></p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asignatura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
