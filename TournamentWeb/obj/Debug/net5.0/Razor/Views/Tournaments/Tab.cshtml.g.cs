#pragma checksum "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Tournaments\Tab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ddc95e7dd226b8e12e24bf015cec66e905da5fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_Tab), @"mvc.1.0.view", @"/Views/Tournaments/Tab.cshtml")]
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
#line 1 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ddc95e7dd226b8e12e24bf015cec66e905da5fe", @"/Views/Tournaments/Tab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournaments_Tab : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.ViewModels.TournamentTabViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"nav nav-tabs\">\r\n    <li role=\"presentation\"");
            BeginWriteAttribute("class", " class=\"", 114, "\"", 204, 3);
#nullable restore
#line 4 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Tournaments\Tab.cshtml"
WriteAttributeValue("", 122, Model.ActiveTab, 122, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 138, "==", 139, 3, true);
            WriteAttributeValue(" ", 141, "MbmStore.Models.ViewModels.TournamentTabViewModel.Tab.OverView", 142, 63, true);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.ViewModels.TournamentTabViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
