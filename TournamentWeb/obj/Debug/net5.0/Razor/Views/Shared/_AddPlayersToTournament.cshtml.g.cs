#pragma checksum "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30cba5dc99990acfdf37e725a3da00b049a731fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AddPlayersToTournament), @"mvc.1.0.view", @"/Views/Shared/_AddPlayersToTournament.cshtml")]
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
#line 1 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30cba5dc99990acfdf37e725a3da00b049a731fe", @"/Views/Shared/_AddPlayersToTournament.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8cbd7db290a5ed2a2e70301dadeeaf346ef9804", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AddPlayersToTournament : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TournamentWeb.Models.Tournament>
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"Pcontainer\">\r\n");
#nullable restore
#line 9 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
     foreach (var team in Model.Teams)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"teamwrap\">\r\n            <div class=\"teamName\">\r\n                <p>");
#nullable restore
#line 13 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
              Write(Html.DisplayFor(modelItem => team.TeamName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                 foreach (var Attendee in team.Attendees)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                     if (UserManager.GetUserId(User) == Attendee.UserID && Attendee.UserStatus == "TeamLeader")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30cba5dc99990acfdf37e725a3da00b049a731fe6034", async() => {
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
#line 18 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                                                 WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
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
#line 21 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
             foreach (var Attendee in team.Attendees)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"AttendeeName\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 29 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                   Write(Html.DisplayFor(modelItem => Attendee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                         if (Attendee.UserStatus == "TeamLeader")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>(TL)</span>\r\n");
#nullable restore
#line 33 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 36 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                     if (UserManager.GetUserId(User) == Attendee.UserID)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30cba5dc99990acfdf37e725a3da00b049a731fe11323", async() => {
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
#line 38 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                                                       WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
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
#line 41 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                    }
                    //WRONG
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                         foreach (var AttendeeN in team.Attendees)
                        {
                            if (AttendeeN.UserStatus == "TeamLeader" && UserManager.GetUserId(User) == AttendeeN.UserID)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30cba5dc99990acfdf37e725a3da00b049a731fe15258", async() => {
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
#line 49 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                                                                             WriteLiteral(Model.TournamentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                                                                                                                    WriteLiteral(team.TeamId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TeamId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TeamId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
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
#line 52 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 56 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
             for (int i = 0; i < 3 - team.Attendees.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"AttendeeName\">\r\n                    <div id=\"UseShipAddr\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2615, "\"", 2684, 7);
            WriteAttributeValue("", 2625, "testfuck(", 2625, 9, true);
#nullable restore
#line 60 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
WriteAttributeValue("", 2634, Model.TournamentId, 2634, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2653, ",", 2653, 1, true);
#nullable restore
#line 60 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
WriteAttributeValue(" ", 2654, team.TeamId, 2655, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2667, ",", 2667, 1, true);
            WriteAttributeValue(" ", 2668, "0,", 2669, 3, true);
            WriteAttributeValue(" ", 2671, "\'AddPlayer\')", 2672, 13, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Add</div>\r\n                </div>\r\n");
#nullable restore
#line 62 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 64 "C:\Users\lille\Desktop\skole repo\interdisciplinary\TournamentWeb\Views\Shared\_AddPlayersToTournament.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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