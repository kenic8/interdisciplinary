#pragma checksum "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0141e76492acc5486d662b6fb61d6ccd489cec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tournaments_Details), @"mvc.1.0.view", @"/Views/Tournaments/Details.cshtml")]
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
#line 1 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\_ViewImports.cshtml"
using TournamentWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0141e76492acc5486d662b6fb61d6ccd489cec", @"/Views/Tournaments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
    public class Views_Tournaments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TournamentWeb.Models.Tournament>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemovePlayer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dadatest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div id=\"myTag\"></div>\r\n\r\n<h1>\r\n    ");
#nullable restore
#line 10 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
Write(Model.TournamentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
  
    if (ViewBag.error != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"errorLoader\"></div>\r\n");
#nullable restore
#line 17 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"Tcontainer\"");
            BeginWriteAttribute("style", " style=\"", 360, "\"", 427, 4);
            WriteAttributeValue("", 368, "background:", 368, 11, true);
            WriteAttributeValue(" ", 379, "url(/images/tournaments/", 380, 25, true);
#nullable restore
#line 22 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
WriteAttributeValue("", 404, Model.TournamentImage, 404, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 426, ")", 426, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n<div class=\"bg-primary m-1 p-1 text-white\">\r\n    Participants\r\n</div>\r\n\r\n\r\n<div class=\"Pcontainer\">\r\n");
#nullable restore
#line 31 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
     foreach (var team in Model.Teams)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"teamwrap\">\r\n            <div class=\"teamName\">\r\n                <p>");
#nullable restore
#line 35 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
              Write(Html.DisplayFor(modelItem => team.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                 foreach (var Attendee in team.Attendees)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                     if (UserManager.GetUserId(User) == Attendee.UserID && Attendee.UserStatus == "TeamLeader")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0141e76492acc5486d662b6fb61d6ccd489cec7238", async() => {
                WriteLiteral("\r\n                            <div class=\"btn btn-outline-danger btn-sm\">Delete</div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                 WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                                                        WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
             foreach (var Attendee in team.Attendees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"AttendeeName\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 51 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => Attendee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                         if (Attendee.UserStatus == "TeamLeader")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>(TL)</span>\r\n");
#nullable restore
#line 55 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 58 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                     if (UserManager.GetUserId(User) == Attendee.UserID)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0141e76492acc5486d662b6fb61d6ccd489cec12428", async() => {
                WriteLiteral("\r\n                            <div class=\"btn btn-outline-danger btn-sm\">Leave</div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                       WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                                                              WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                    }
                    //WRONG
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                         foreach (var AttendeeN in team.Attendees)
                        {
                            if (AttendeeN.UserStatus == "TeamLeader" && UserManager.GetUserId(User) == AttendeeN.UserID)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0141e76492acc5486d662b6fb61d6ccd489cec16319", async() => {
                WriteLiteral("\r\n                                    <div class=\"btn btn-outline-danger btn-sm\">Remove</div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                                             WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                                                                                    WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                                                                                                                                    WriteLiteral(Attendee.UserID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 78 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
             for (int i = 0; i < 3 - team.Attendees.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"AttendeeName\">\r\n                    <div id=\"UseShipAddr\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2922, "\"", 2991, 7);
            WriteAttributeValue("", 2932, "testfuck(", 2932, 9, true);
#nullable restore
#line 82 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
WriteAttributeValue("", 2941, Model.TournamentId, 2941, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2960, ",", 2960, 1, true);
#nullable restore
#line 82 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
WriteAttributeValue(" ", 2961, team.TeamId, 2962, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2974, ",", 2974, 1, true);
            WriteAttributeValue(" ", 2975, "0,", 2976, 3, true);
            WriteAttributeValue(" ", 2978, "\'AddPlayer\')", 2979, 13, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Add</div>\r\n                </div>\r\n");
#nullable restore
#line 84 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 86 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<button class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3148, "\"", 3207, 6);
            WriteAttributeValue("", 3158, "testfuck(", 3158, 9, true);
#nullable restore
#line 90 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
WriteAttributeValue("", 3167, Model.TournamentId, 3167, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3186, ",", 3186, 1, true);
            WriteAttributeValue(" ", 3187, "0,", 3188, 3, true);
            WriteAttributeValue(" ", 3190, "0,", 3191, 3, true);
            WriteAttributeValue(" ", 3193, "\'CreateTeam\')", 3194, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    Join Tournament\r\n</button>\r\n\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js\"></script>\r\n<script>\r\n    if ($(\'#errorLoader\').length) {\r\n        $(\"#errorLoader\").ready(function () {\r\n            testfuck(");
#nullable restore
#line 99 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                Write(Model.TournamentId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", 0, 0, \"");
#nullable restore
#line 99 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Tournaments\Details.cshtml"
                                            Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""");
        })
    }
</script>

<style>
    .Tcontainer {
        background: grey;
        height: 40vh;
        width: 100%;
    }


    .Pcontainer {
        height: auto;
        width: 100%;
        display: flex;
        flex-wrap: wrap;
    }

    .teamwrap {
        width: 200px;
        border: 1px solid lightblue;
        height: max-content;
        margin: 12px;
    }

    .AttendeeName:nth-child(even) {
        background: #add8e642;
    }

    .teamName {
        color: white;
        background: lightblue;
        padding: 8px;
    }

        .teamName p {
            margin: 0 0 8px 0;
        }

    .AttendeeName {
        color: grey;
        display: flex;
        justify-content: space-between
    }

        .AttendeeName p {
            margin: 0 0 0 4px;
        }
</style>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TournamentWeb.Models.Tournament> Html { get; private set; }
    }
}
#pragma warning restore 1591
