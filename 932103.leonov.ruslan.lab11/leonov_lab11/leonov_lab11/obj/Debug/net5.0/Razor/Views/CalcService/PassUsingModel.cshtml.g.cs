#pragma checksum "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74279e3611d96c8677c4e0e5375bf81e267ed3b99e038e8bb4fe235ff369c518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_PassUsingModel), @"mvc.1.0.view", @"/Views/CalcService/PassUsingModel.cshtml")]
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
#line 1 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\_ViewImports.cshtml"
using leonov_lab11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\_ViewImports.cshtml"
using leonov_lab11.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"74279e3611d96c8677c4e0e5375bf81e267ed3b99e038e8bb4fe235ff369c518", @"/Views/CalcService/PassUsingModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f0628eea70a9e9d94db1e4c20c222fd9118df61e3225e17d0095a04e66b10650", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CalcService_PassUsingModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<leonov_lab11.Models.Actions>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
  
    ViewData["Title"] = "PassUsingModel - Backend1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<b>Rand first value: </b> ");
#nullable restore
#line 7 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                     Write(Model.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<b>Rand second value: </b> ");
#nullable restore
#line 9 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                      Write(Model.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<b>Add: </b>\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" +  ");
#nullable restore
#line 15 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
            Write(Model.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 15 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                            Write(Model.sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<b>Sub: </b>\r\n<br />\r\n");
#nullable restore
#line 21 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -  ");
#nullable restore
#line 21 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
            Write(Model.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" =  ");
#nullable restore
#line 21 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                             Write(Model.subtraction);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<b>Mult: </b>\r\n");
#nullable restore
#line 26 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" *  ");
#nullable restore
#line 26 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
            Write(Model.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" =  ");
#nullable restore
#line 26 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                             Write(Model.multiply);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n<b>Div:</b>\r\n<br />\r\n");
#nullable restore
#line 32 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.value1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /  ");
#nullable restore
#line 32 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
            Write(Model.value2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" =  ");
#nullable restore
#line 32 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                                   if (Model.value2 != 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
Write(Model.divide);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
                 
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span>Division by zero!</span>\r\n");
#nullable restore
#line 39 "C:\Users\tire_\Documents\LEARN\веба\repos_hub\web_labs\932103.leonov.ruslan.lab11\leonov_lab11\leonov_lab11\Views\CalcService\PassUsingModel.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<leonov_lab11.Models.Actions> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591