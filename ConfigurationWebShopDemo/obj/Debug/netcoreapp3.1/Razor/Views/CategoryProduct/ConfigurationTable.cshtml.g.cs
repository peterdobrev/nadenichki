#pragma checksum "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3432237999732be24d0c88acbf6c0c70347e2334"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoryProduct_ConfigurationTable), @"mvc.1.0.view", @"/Views/CategoryProduct/ConfigurationTable.cshtml")]
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
#line 1 "D:\nadenichki\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nadenichki\ConfigurationWebShopDemo\Views\_ViewImports.cshtml"
using ConfigurationWebShopDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3432237999732be24d0c88acbf6c0c70347e2334", @"/Views/CategoryProduct/ConfigurationTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e28934afb9c5553adf875fd893f1370f13ccc87", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_CategoryProduct_ConfigurationTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConfigurationWebShopDemo.Models.Configurations>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mx-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
  
    ViewData["Title"] = "ConfigurationsView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container p-3\">\r\n");
#nullable restore
#line 7 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
     if( Model.Count() >0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-bordered table-striped"" style=""width:100%"">
                    <thead style=""color: white; text-align:center"">
                        <tr>
                            <th>
                                Motherboard Name
                            </th>
                            <th>
                                SSD
                            </th>
                            <th>
                                HDD
                            </th>
                            <th>
                                RAM
                            </th>
                            <th>
                                CPU
                            </th>
                            <th>
                                GPU
                            </th>
                            <th>
                                Sound Card
                            </th>
                            <th>
                                WWAN Card");
            WriteLiteral("\n                            </th>\r\n                            <th>\r\n                                Computer Case\r\n                            </th>\r\n                            <th>\r\n                                Price\r\n                    <tbody>\r\n");
#nullable restore
#line 43 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                         foreach(var obj in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td width=\"10%\" style=\"color: white\">");
#nullable restore
#line 47 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.Mother_Board);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"10%\" style=\"color: white\">");
#nullable restore
#line 48 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.SSD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"10%\" style=\"color: white\">");
#nullable restore
#line 49 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.HDD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"10%\" style=\"color: white\">");
#nullable restore
#line 50 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.RAM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"15%\" style=\"color: white\">");
#nullable restore
#line 51 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.CPU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"15%\" style=\"color: white\">");
#nullable restore
#line 52 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.GPU);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"20%\" style=\"color: white\">");
#nullable restore
#line 53 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.Sound_Card);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"15%\" style=\"color: white\">");
#nullable restore
#line 54 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.WWAN_Card);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"20%\" style=\"color: white\">");
#nullable restore
#line 55 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.Computer_Case);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td width=\"10%\" style=\"color: white\">");
#nullable restore
#line 56 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                            Write(obj.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                             if(Logged.IsAdmin == true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            <div class=\"w-75 btn-group\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3432237999732be24d0c88acbf6c0c70347e233411013", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-edit\"></i>\r\n                                    Edit\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                               WriteLiteral(obj.Configuration_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3432237999732be24d0c88acbf6c0c70347e233413671", async() => {
                WriteLiteral("\r\n                                    <i class=\"far fa-trash-alt\"></i>\r\n                                    Create\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                                                               WriteLiteral(obj.Configuration_Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n");
#nullable restore
#line 71 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 74 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 77 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>Изчерпани са количествата</p>\r\n");
#nullable restore
#line 81 "D:\nadenichki\ConfigurationWebShopDemo\Views\CategoryProduct\ConfigurationTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConfigurationWebShopDemo.Models.Configurations>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
