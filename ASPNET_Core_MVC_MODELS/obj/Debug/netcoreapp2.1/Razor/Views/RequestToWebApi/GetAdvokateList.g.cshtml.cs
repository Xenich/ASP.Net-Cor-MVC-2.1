#pragma checksum "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5206f4a80d12dd7b7ec6c5ce1e86c95c32ce36cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequestToWebApi_GetAdvokateList), @"mvc.1.0.view", @"/Views/RequestToWebApi/GetAdvokateList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RequestToWebApi/GetAdvokateList.cshtml", typeof(AspNetCore.Views_RequestToWebApi_GetAdvokateList))]
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
#line 1 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\_ViewImports.cshtml"
using ASPNET_Core_MVC_MODELS;

#line default
#line hidden
#line 2 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\_ViewImports.cshtml"
using ASPNET_Core_MVC_MODELS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5206f4a80d12dd7b7ec6c5ce1e86c95c32ce36cb", @"/Views/RequestToWebApi/GetAdvokateList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"132d8b637d3b63d02c9724397904fb10c991b27b", @"/Views/_ViewImports.cshtml")]
    public class Views_RequestToWebApi_GetAdvokateList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPNET_Core_MVC_MODELS.ViewModels.AdvokatesViewModel.Advokate>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(112, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(141, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf048db9730486e950d43b120965704", async() => {
                BeginContext(147, 97, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>GetAdvokateList</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(251, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(253, 1142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c19ba89b928f4f96bdd6e84e5af3f208", async() => {
                BeginContext(259, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(270, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81f2f0ee64a04620b897fdcdfbf6dcfb", async() => {
                    BeginContext(293, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(307, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(400, 38, false);
#line 22 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
                EndContext();
                BeginContext(438, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(494, 40, false);
#line 25 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(534, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(590, 39, false);
#line 28 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
                EndContext();
                BeginContext(629, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 34 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(747, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(796, 37, false);
#line 37 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(833, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(889, 39, false);
#line 40 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(928, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(984, 38, false);
#line 43 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
                EndContext();
                BeginContext(1022, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1078, 65, false);
#line 46 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1143, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1164, 71, false);
#line 47 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1235, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(1256, 69, false);
#line 48 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(1325, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 51 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\ASPNET_Core_MVC_MODELS\ASPNET_Core_MVC_MODELS\Views\RequestToWebApi\GetAdvokateList.cshtml"
}

#line default
#line hidden
                BeginContext(1364, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1395, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPNET_Core_MVC_MODELS.ViewModels.AdvokatesViewModel.Advokate>> Html { get; private set; }
    }
}
#pragma warning restore 1591
