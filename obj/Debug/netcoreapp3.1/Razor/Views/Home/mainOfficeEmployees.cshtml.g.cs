#pragma checksum "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd271d2522a4874928bde11063d18cda96549a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_mainOfficeEmployees), @"mvc.1.0.view", @"/Views/Home/mainOfficeEmployees.cshtml")]
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
#line 1 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\_ViewImports.cshtml"
using DetectiveAgency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\_ViewImports.cshtml"
using DetectiveAgency.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd271d2522a4874928bde11063d18cda96549a5a", @"/Views/Home/mainOfficeEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f531fe828c6d2bc445180e3a8905a2c8101b7f2f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_mainOfficeEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/detectives.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("xyz detectives"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right rounded-circle mt-0 img-fluid col-sm-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("box-shadow:1px 1px black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
  
    ViewData["Title"] = "ABC Corporation Staff";
    string[] staff = { "Freddie Flintstone", "Barney Rubble", "Betty Rubble", "Wilma Flintstone" };
    int staffLen = staff.Length;
    string[] managers = { "Pebbles Flintstone", "Johnny Quest", "Shaggy Rogers" };
    int managerLen = managers.Length;
    string[] officers = { "Scooby Doo", "Astro Jetson", "Scrappy Doo" };
    int officerLen = officers.Length;
    var x = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<div class=\"jumbotron bg-success text-white row\">\r\n    <i class=\"fa fa-users col-sm-1\" style=\"font-size:450%;color:antiquewhite\"></i>\r\n    <h1 class=\"col-sm-7 text-white\">Meet the Team!</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd271d2522a4874928bde11063d18cda96549a5a5466", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<table class=\"table table-hover table-light\">\r\n    <tr><th><h2>XYZ Detective Agency Staff</h2></th></tr>\r\n");
#nullable restore
#line 19 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
     for (x = 0; x < staffLen; x++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 21 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
           Write(staff[x]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 22 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<hr />\r\n\r\n<table class=\"table table-hover table-info\">\r\n    <tr><th><h2>XYZ Detective Agency Managers</h2></th></tr>\r\n");
#nullable restore
#line 28 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
     foreach (var person in managers)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr><td>");
#nullable restore
#line 30 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
           Write(person);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 31 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<hr />\r\n<table class=\"table table-hover table-primary\">\r\n    <tr><td><h2>XYZ Detective Agency Corporate Office</h2></td></tr>\r\n");
#nullable restore
#line 36 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
      
        x = 0;
        while (x < officerLen)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr><td>");
#nullable restore
#line 40 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
                   Write(officers[x]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
#nullable restore
#line 41 "C:\Users\Owner\Desktop\218\DetectiveAgency\Views\Home\mainOfficeEmployees.cshtml"
            x += 1;
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<hr />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
