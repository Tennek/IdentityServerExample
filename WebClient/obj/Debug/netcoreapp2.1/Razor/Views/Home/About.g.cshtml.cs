#pragma checksum "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bacd42e26260e6782dc1f708270fe868ef65f774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#line 2 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#line 1 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacd42e26260e6782dc1f708270fe868ef65f774", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 27, true);
            WriteLiteral("\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 6 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(119, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(132, 10, false);
#line 8 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(142, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(162, 11, false);
#line 9 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(173, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 10 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(187, 38, true);
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 16 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(313, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(326, 8, false);
#line 18 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(334, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(354, 10, false);
#line 19 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(364, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 20 "C:\Users\dev.eetvek\Practice\quickstart\quickstart\WebClient\Views\Home\About.cshtml"
    }

#line default
#line hidden
            BeginContext(378, 5, true);
            WriteLiteral("</dl>");
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