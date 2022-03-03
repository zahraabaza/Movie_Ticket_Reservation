#pragma checksum "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11e3b445c202598654a9bb815945b9025fd0bb4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_DetailsUser), @"mvc.1.0.view", @"/Views/Movie/DetailsUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11e3b445c202598654a9bb815945b9025fd0bb4d", @"/Views/Movie/DetailsUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079eb81a01d1a792c4bbac455db6644dedc4b68f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_DetailsUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-fancybox-group", new global::Microsoft.AspNetCore.Html.HtmlString("gallery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cinema", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Actor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
  
Layout="~/Views/Shared/_UserLayout.cshtml";
	ViewData["Title"] = "Details Movie Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""hero mv-single-hero"">
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
<div class=""page-single movie-single movie_single"">
	<div class=""container"">
		<div class=""row ipad-width2"">
			<div class=""col-md-4 col-sm-12 col-xs-12"">
				<div class=""movie-img sticky-sb"">
");
#nullable restore
#line 24 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                      var base64 = Convert.ToBase64String(@Model.Movie.Image);
      string imgsrc = string.Format("data:images/*;base64,{0}", base64);
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 835, "\"", 848, 1);
#nullable restore
#line 27 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
WriteAttributeValue("", 841, imgsrc, 841, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 849, "\"", 855, 0);
            EndWriteAttribute();
            WriteLiteral(@">
					<div class=""movie-btn"">	
						<div class=""btn-transform transform-vertical red"">
							<div><a href=""#"" class=""item item-1 redbtn""> <i class=""ion-play""></i> Watch Trailer</a></div>
							<div><a href=""https://www.youtube.com/embed/o-0hcF97wy0"" class=""item item-2 redbtn fancybox-media hvr-grow""><i class=""ion-play""></i></a></div>
						</div>
						<div class=""btn-transform transform-vertical"">
							<div><a href=""#"" class=""item item-1 yellowbtn""> <i class=""ion-card""></i> Buy ticket</a></div>
							<div><a href=""#"" class=""item item-2 yellowbtn""><i class=""ion-card""></i></a></div>
						</div>
					</div>
				</div>
			</div>
			<div class=""col-md-8 col-sm-12 col-xs-12"">
				<div class=""movie-single-ct main-content"">
					<h1 class=""bd-hd"">");
#nullable restore
#line 42 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                 Write(Model.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span>2015</span></h1>
					<div class=""social-btn"">
						<a href=""#"" class=""parent-btn""><i class=""ion-heart""></i> Add to Favorite</a>
							
					</div>
					<div class=""hover-bnt"">
							<a  class=""parent-btn""><i class=""fa-solid fa-circle-dollar""></i>Price: ");
#nullable restore
#line 48 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                                                              Write(Model.Movie.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
						
						</div>
					<div class=""movie-rate"">
						<div class=""rate"">
							<i class=""ion-android-star""></i>
							<p><span>8.1</span> /10<br>
								<span class=""rv"">56 Reviews</span>
							</p>
						</div>
						<div class=""rate-star"">
							<p>Rate This Movie:  </p>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star""></i>
							<i class=""ion-ios-star-outline""></i>
						</div>
					</div>
					<div class=""movie-tabs"">
						<div class=""tabs"">
							<ul class=""tab-links tabs-mv"">
								<li class=""active""><a href=""#overview"">Overview</a></li>
								
								<li><a href=""#cast"">  Director & Cast </a></li>
							                    
							</ul>
						    <div class=""tab-content"">
						        <div id=""overview"" class=""tab activ");
            WriteLiteral("e\">\r\n\t\t\t\t\t\t            <div class=\"row\">\r\n\t\t\t\t\t\t            \t<div class=\"col-md-8 col-sm-12 col-xs-12\">\r\n\t\t\t\t\t\t            \t\t<p>");
#nullable restore
#line 83 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                          Write(Model.Movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"title-hd-sm\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<h4>Cinemas</h4>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"mvsingle-item ov-item\">\r\n");
#nullable restore
#line 89 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                 foreach(var item in Model.MoviesInCinemas){
													if(item.Cinema.Image!=null){
														var base1 = Convert.ToBase64String(@item.Cinema.Image);
														 string imgsrc1 = string.Format("data:images/*;base64,{0}", base1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e3b445c202598654a9bb815945b9025fd0bb4d10827", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t<img src=\"imgsrc1\"");
                BeginWriteAttribute("alt", " alt=\"", 3701, "\"", 3724, 1);
#nullable restore
#line 95 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
WriteAttributeValue("", 3707, item.Cinema.Name, 3707, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                                                                                                                      WriteLiteral(item.Cinema.Id);

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
#line 96 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
					
													}}	

#line default
#line hidden
#nullable disable
            WriteLiteral(@"											</div>
										
						            	</div>
						            	
						            </div>
						        </div>
						        
						        <div id=""cast"" class=""tab"">
						        	<div class=""row"">
						            	
					       	 			
										<!-- //== -->
					       	 			<div class=""title-hd-sm"">
											<h4>Director</h4>
										</div>
										<div class=""mvcast-item"">											
											<div class=""cast-it"">
												<div class=""cast-left"" style=""overflow: hidden; position: relative;"">
													<img");
            BeginWriteAttribute("src", " src=\"", 4316, "\"", 4349, 1);
#nullable restore
#line 116 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
WriteAttributeValue("", 4322, Model.Movie.Producer.Image, 4322, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" object-fit: cover;\"/>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e3b445c202598654a9bb815945b9025fd0bb4d15154", async() => {
#nullable restore
#line 118 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                                                       Write(Model.Movie.Producer.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                      WriteLiteral(Model.Movie.Producer.Id);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<!-- //== -->\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"title-hd-sm\">\r\n\t\t\t\t\t\t\t\t\t\t\t<h4>Casts</h4>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"mvcast-item\">\t\r\n");
#nullable restore
#line 128 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                             foreach(var item in Model.MovieActors){
												

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t <div class=\"cast-it\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"cast-left\" style=\"overflow: hidden; position: relative;\">\r\n");
#nullable restore
#line 132 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                      if(item.Actor.Image!=null){
														var base1 = Convert.ToBase64String(@item.Actor.Image);
														 string imgsrc1 = string.Format("data:images/*;base64,{0}", base1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t<img src=\"imgsrc1\" style=\" object-fit: cover;\"/>\r\n");
#nullable restore
#line 136 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
													}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11e3b445c202598654a9bb815945b9025fd0bb4d19336", async() => {
#nullable restore
#line 137 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                                                                                            Write(item.Actor.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
                                                                                                     WriteLiteral(item.Actor.Id);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 141 "D:\MVC Project\Movie_Ticket_Reservation\MovieTickets\Views\Movie\DetailsUser.cshtml"
												
											
											}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<!-- //== -->\r\n\t\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t            </div>\r\n\t\t\t\t\t       \t \t</div>\r\n\t\t\t\t\t       \t \t\r\n\t\t\t\t\t       \t \t\r\n\t\t\t\t\t\t    </div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
