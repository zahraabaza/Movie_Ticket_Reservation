#pragma checksum "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85073107a020b899ede7b502c05795e77cb569e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_DetailsUser), @"mvc.1.0.view", @"/Views/Category/DetailsUser.cshtml")]
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
#line 1 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.ViewModels;

#line default
#line hidden
#nullable disable
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85073107a020b899ede7b502c05795e77cb569e3", @"/Views/Category/DetailsUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079eb81a01d1a792c4bbac455db6644dedc4b68f", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_DetailsUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
  
Layout="~/Views/Shared/_UserLayout.cshtml";
	ViewData["Title"] = "Details Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""slider sliderv2"">
	<div class=""container"">
		<div class=""row"">
	    	<div class=""slider-single-item"">
	    		<div class=""movie-item"">
	    			<div class=""row"">
	    				<div class=""col-md-8 col-sm-12 col-xs-12"">
	    					<div class=""title-in"">
			    				
			    				<h1>");
#nullable restore
#line 15 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\t\t\t\t\t\t\t\t\n\t\t\t    \t\t\t\t\n\t\t\t    \t\t\t\t\t\t\n\t\t\t    \t\t\t</div>\n\t    \t\t\t\t</div>\n\t    \t\t\t\t<div class=\"col-md-4 col-sm-12 col-xs-12\">\n\t\t    \t\t\t\t<div class=\"mv-img-2\">\n\t\t\t    \t\t\t\t<a href=\"#\"><img src=\"images/uploads/poster1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 616, "\"", 622, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
			    			</div>
		    			</div>
	    			</div>	
	    		</div>
	    		
	    	</div>
	    </div>
	</div>
</div>

<div class=""latestnew full-width"">
		<div class=""row"">
			<div class=""col-md-12"">
				
				<div class=""title-hd"">
					<h2>Latest news</h2>
					<a href=""bloggrid.html"" class=""viewall"">All Movies <i class=""ion-ios-arrow-right""></i></a>
				</div>
				<div class=""latestnewv2"">
");
#nullable restore
#line 43 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
                     foreach(var item in Model.Movies){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"blog-item-style-2\">\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85073107a020b899ede7b502c05795e77cb569e35853", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 1181, "\"", 1198, 1);
#nullable restore
#line 45 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
WriteAttributeValue("", 1187, item.Image, 1187, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1199, "\"", 1205, 0);
                EndWriteAttribute();
                WriteLiteral(">");
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
#line 45 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
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
            WriteLiteral("\n\t\t\t\t\t\t<div class=\"blog-it-infor\">\n\t\t\t\t\t\t\t<h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85073107a020b899ede7b502c05795e77cb569e38803", async() => {
#nullable restore
#line 47 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
                                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
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
#line 47 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
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
            WriteLiteral("</h3>\n\t\t\t\t\t\t\t<span class=\"time\">");
#nullable restore
#line 48 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
                                          Write(item.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t\t\t\t\t\t<p>");
#nullable restore
#line 49 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n");
#nullable restore
#line 52 "D:\MVCProject\Movie_Ticket_Reservation\MovieTickets\Views\Category\DetailsUser.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\n\t\t\t</div>\n\t\t\n\t\t</div>\n\t</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
