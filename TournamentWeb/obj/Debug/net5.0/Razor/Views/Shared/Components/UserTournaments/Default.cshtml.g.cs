#pragma checksum "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b54f3a773117a125cc7f111d6d9b10843dbb717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserTournaments_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserTournaments/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b54f3a773117a125cc7f111d6d9b10843dbb717", @"/Views/Shared/Components/UserTournaments/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd30be310ed5315e55eb7435d275890d09ecdbc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserTournaments_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
  
    if (ViewBag.CreatedTournaments.Count != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Your Tournaments created</p>\n");
#nullable restore
#line 10 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
             foreach (var T in ViewBag.CreatedTournaments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"flex-inner\" href=\"#\" style=\"text-decoration:none\">\n                    <div class=\"side1\">\n");
#nullable restore
#line 14 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                         if (T.TournamentImage != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 447, "\"", 491, 2);
            WriteAttributeValue("", 453, "/images/tournaments/", 453, 20, true);
#nullable restore
#line 16 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
WriteAttributeValue("", 473, T.TournamentImage, 473, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 17 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\n                    <div class=\"side2\">\n                        <h2>");
#nullable restore
#line 20 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                       Write(T.TournamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                        <p>");
#nullable restore
#line 21 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                      Write(T.TimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </a>\n");
#nullable restore
#line 24 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
             
        }

    if (ViewBag.joinedTournaments.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Your joined tournaments</p>\n");
#nullable restore
#line 30 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
         foreach (var f in ViewBag.joinedTournaments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"flex-inner\" href=\"#\" style=\"text-decoration:none\">\n                <div class=\"side1\">\n");
#nullable restore
#line 34 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                     if (f.TournamentImage != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1121, "\"", 1165, 2);
            WriteAttributeValue("", 1127, "/images/tournaments/", 1127, 20, true);
#nullable restore
#line 36 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
WriteAttributeValue("", 1147, f.TournamentImage, 1147, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 37 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <div class=\"side2\">\n                    <h2>");
#nullable restore
#line 40 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                   Write(f.TournamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <p>");
#nullable restore
#line 41 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
                  Write(f.TimeFrame);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </a>\n");
#nullable restore
#line 44 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
             
        }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p> No active tournaments</p>\n");
#nullable restore
#line 49 "C:\Users\marti\Documents\Github\Group project\interdisciplinary\TournamentWeb\Views\Shared\Components\UserTournaments\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<style>
    .flex-inner {
        width: 100%;
        height: 20vh;
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
        box-sizing: border-box;
    }

        .flex-inner > h1, h2 {
            font-size: 1em;
        }


        .flex-inner > a {
            text-decoration: none;
        }


        .flex-inner > h2 {
            font-size: 0.5em;
        }

        .flex-inner > .side1 {
            width: 45%;
        }


            .flex-inner > .side1 > img {
                width: 100%;
                height: auto;
                padding: 5%;
            }

        .flex-inner > .side2 {
            width: 45%;
            height: auto;
        }

            .flex-inner > .side2 > p {
                font-size: 1em;
            }




</style>

");
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
