#pragma checksum "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6029571136cfa49441d7fd61ea6a0fdf3c1d4145"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actor_DetailsUser), @"mvc.1.0.view", @"/Views/Actor/DetailsUser.cshtml")]
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
#line 1 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\_ViewImports.cshtml"
using MovieTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6029571136cfa49441d7fd61ea6a0fdf3c1d4145", @"/Views/Actor/DetailsUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079eb81a01d1a792c4bbac455db6644dedc4b68f", @"/Views/_ViewImports.cshtml")]
    public class Views_Actor_DetailsUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Actor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
  
    Layout="~/Views/Shared/_UserLayout.cshtml";
	
		var base64 = "";
		string imgsrc ;
	

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero hero3"">
	<div class=""container"">
		<div class=""row"">
			<div class=""col-md-12"">
				<!-- <h1> movie listing - list</h1>
				<ul class=""breadcumb"">
					<li class=""active""><a href=""#"">Home</a></li>
					<li> <span class=""ion-ios-arrow-right""></span> movie listing</li>
				</ul> -->
			</div>
		</div>
	</div>
</div>
<!-- celebrity single section-->

<div class=""page-single movie-single cebleb-single"">
	<div class=""container"">
		<div class=""row ipad-width"">
			<div class=""col-md-4 col-sm-12 col-xs-12"">
				<div class=""mv-ceb"">
");
#nullable restore
#line 30 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
                      base64=	Convert.ToBase64String(@Model.Image);
                imgsrc= string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img src=\"imgsrc\"");
            BeginWriteAttribute("alt", " alt=\"", 837, "\"", 843, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-md-8 col-sm-12 col-xs-12\">\r\n\t\t\t\t<div class=\"movie-single-ct\">\r\n\t\t\t\t\t<h1 class=\"bd-hd\">");
#nullable restore
#line 37 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
					
					<div class=""movie-tabs"">
						<div class=""tabs"">
							
						    <div class=""tab-content"">
						        <div id=""overviewceb"" class=""tab active"">
						            <div class=""row"">
						            	<div class=""col-md-8 col-sm-12 col-xs-12"">
						            		<p>");
#nullable restore
#line 46 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
                                          Write(Model.Bio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t            \t\t\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"title-hd-sm\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4>filmography</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t<!-- movie cast -->\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"mvcast-item\">\t\r\n");
#nullable restore
#line 56 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
                                                 foreach(var item in Model.MovieActors){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-it\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-left cebleb-film\">\r\n");
#nullable restore
#line 59 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
                                                          base64=	Convert.ToBase64String(@item.Movie.Image);
                                                imgsrc= string.Format("data:images/*;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 1854, "\"", 1867, 1);
#nullable restore
#line 61 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
WriteAttributeValue("", 1860, imgsrc, 1860, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"width:40px \">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\">");
#nullable restore
#line 63 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
                                                                   Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 70 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Actor\DetailsUser.cshtml"
												}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"											</div>
						            	</div>
						            
						            </div>
						            
						            
						        
						        
					       	 	
						    </div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>
	</div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Actor> Html { get; private set; }
    }
}
#pragma warning restore 1591
