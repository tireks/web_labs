#pragma checksum "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b542641bc7e7c16fe319b0ad8808c1dbe653c8e7cc0ac749ac015bde80c0790a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_QuizResult), @"mvc.1.0.view", @"/Views/Mockups/QuizResult.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\_ViewImports.cshtml"
using leonov_lab13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
using leonov_lab13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b542641bc7e7c16fe319b0ad8808c1dbe653c8e7cc0ac749ac015bde80c0790a", @"/Views/Mockups/QuizResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"56d588312fa861e41664fc1d6b879750d653b70365443ae59f4785e7c3890ce8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mockups_QuizResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Questions>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
  
    int i = 0;
    ViewData["Title"] = "Quiz Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>Right Answers ");
#nullable restore
#line 8 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
             Write(IdentityMap.rights);

#line default
#line hidden
#nullable disable
            WriteLiteral(" out ");
#nullable restore
#line 8 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
                                     Write(IdentityMap.alls);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 9 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
 foreach (Questions a in Model)
{
    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 12 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 12 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
        Write(a.problem);

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 12 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
                     Write(a.yanswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 13 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab13\leonov_lab13\leonov_lab13\Views\Mockups\QuizResult.cshtml"
  
    IdentityMap.Up();

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Questions>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591