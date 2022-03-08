#pragma checksum "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e194d4343d5fceb9594bfc23eb73822e07f4e335"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_IndexUser), @"mvc.1.0.view", @"/Views/Movie/IndexUser.cshtml")]
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
#line 2 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
using MovieTickets.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e194d4343d5fceb9594bfc23eb73822e07f4e335", @"/Views/Movie/IndexUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf7c47bfdc3aac9156c693582efef788effc3d7", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_IndexUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
  
Layout="~/Views/Shared/_UserLayout.cshtml";
	ViewData["Title"] = " Movie Page";
	SelectList ActorList = new SelectList(@Model.Actors,"Id","Name");
	SelectList CinemaList = new SelectList(@Model.Cinemas,"Id","Name");
	SelectList ProducerList = new SelectList(@Model.Producers,"Id","Name");
	SelectList CategoryList = new SelectList(@Model.Categories,"Id","Name");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero common-hero"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-md-12"">
				<div class=""hero-ct"">
					
				</div>
			</div>
		</div>
	</div>
</div>

<div class=""page-single movie_list"">
	<div class=""container"">
		<div class=""row ipad-width2"">
			<div class=""col-md-8 col-sm-12 col-xs-12"">
				
");
#nullable restore
#line 29 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                 foreach(var item in Model.Movies){
					
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"movie-item-style-2\">\r\n");
#nullable restore
#line 33 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                     if(item.Image!=null){
						var base64 = Convert.ToBase64String(@item.Image);
      var imgsrc = string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1038, "\"", 1051, 1);
#nullable restore
#line 36 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
WriteAttributeValue("", 1044, imgsrc, 1044, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1052, "\"", 1058, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:350px; height:500px; object-fit:cover\">\r\n");
#nullable restore
#line 37 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"mv-item-infor\">\r\n\t\t\t\t\t\t<h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e194d4343d5fceb9594bfc23eb73822e07f4e3356898", async() => {
#nullable restore
#line 39 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t<p class=\"rate\"><i class=\"ion-android-star\"></i><span>8.1</span> /10</p>\r\n\t\t\t\t\t\t<p class=\"describe\">");
#nullable restore
#line 41 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t<p class=\"run-time\"> <span>Release: ");
#nullable restore
#line 42 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                           Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n\t\t\t\t\t\t<p>Director: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e194d4343d5fceb9594bfc23eb73822e07f4e33510327", async() => {
#nullable restore
#line 43 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                                                                           Write(item.Producer.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\t\t\t\t\t\t<p>Stars:");
#nullable restore
#line 44 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                  foreach(var act in item.MovieActors){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e194d4343d5fceb9594bfc23eb73822e07f4e33513295", async() => {
#nullable restore
#line 45 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                                                                Write(act.Actor.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
                                                                          WriteLiteral(act.Actor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 50 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Movie\IndexUser.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\r\n\t\t </div>\r\n");
            WriteLiteral("\t </div>\r\n   </div>\r\n \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
