#pragma checksum "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba555"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/_ViewImports.cshtml"
using ASP_pract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/_ViewImports.cshtml"
using ASP_Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
using ASP_Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba555", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38414ee3d5ca1cff1632620cc58b6a53e38969c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Update Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba5558814", async() => {
                WriteLiteral(@"
    <br />
    <div class=""backgroundWhiteBorder"">
        <div class=""container row"">
            <div class=""col -8"">
                <div class=""card mt-4"">
                    <div class=""card-header bg-dark text-light ml-0 row container"">
                        <div class=""col-6"">
                            <i class=""fa fa-shopping-cart""></i> &nbsp;
                            Shopping Cart
                        </div>
                        <div class=""col-6 text-right"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba5559599", async() => {
                    WriteLiteral("Continue Shopping");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class="" d-none d-lg-block"">
                            <div class=""row"" style=""color:#821f3d"">
                                <div class=""col-lg-2"">
                                </div>
");
#nullable restore
#line 25 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                 if (User.IsInRole(WC.AdminRole))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-12 col-lg-3\">\n                                        Product Details\n                                    </div>\n");
#nullable restore
#line 30 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-12 col-lg-7\">\n                                        Product Details\n                                    </div>\n");
#nullable restore
#line 36 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-12 col-lg-2\">\n                                    Price per SqM\n                                </div>\n");
#nullable restore
#line 40 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                 if (User.IsInRole(WC.AdminRole))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <div class=""col-6 col-lg-2"">
                                        SqM
                                    </div>
                                    <div class=""col-6 col-lg-2"">
                                        Total Price
                                    </div>
");
#nullable restore
#line 48 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"

                                }
                                else
                                {

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-6 col-sm-4 col-lg-1\">\n                                </div>\n                            </div>\n                        </div>\n\n                        <hr />\n\n");
#nullable restore
#line 61 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                         if (Model.Count() == 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <h1> Please add an item to cart</h1>\n");
#nullable restore
#line 64 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                        }
                        else
                        {
                            var orderTotal = 0.0;

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                             for (int i = 0; i < Model.Count(); i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba55514773", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 71 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                <div class=\"row h-100\">\n                                    <div class=\"col-4 col-md-2 text-center py-2\">\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 3107, "\"", 3141, 2);
#nullable restore
#line 74 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
WriteAttributeValue("", 3113, WC.ImagePath, 3113, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
WriteAttributeValue("", 3126, Model[i].Image, 3126, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100%\" />\n                                    </div>\n");
#nullable restore
#line 76 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-8 col-lg-3\">\n                                            <h5>");
#nullable restore
#line 79 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                            <div style=\"font-size:11px;\">");
#nullable restore
#line 80 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                                                    Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                                        </div>\n");
#nullable restore
#line 82 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-8 col-lg-7\">\n                                            <h5>");
#nullable restore
#line 86 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\n                                            <div style=\"font-size:11px;\">");
#nullable restore
#line 87 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                                                    Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n                                        </div>\n");
#nullable restore
#line 89 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                        <span style=\"font-size:17px;\">$ ");
#nullable restore
#line 91 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                                                   Write(Model[i].Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> / SqM\n\n                                    </div>\n\n");
#nullable restore
#line 95 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                     if (User.IsInRole(WC.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-4 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba55520659", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 98 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TempSqm);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba55522457", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 99 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TempSqm);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        </div>\n                                        <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\n                                            <span style=\"font-size:17px;\">$ ");
#nullable restore
#line 102 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                                                        Write(Model[i].Price * Model[i].TempSqm);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n                                        </div>\n");
#nullable restore
#line 104 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    <div class=\"col-2 col-lg-1 p-0 pt-lg-4 text-center\">\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba55525006", async() => {
                    WriteLiteral("\n                                            <i class=\"fas fa-trash\"></i>\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                                                 WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 112 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                orderTotal += Model[i].Price * Model[i].TempSqm;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <hr />\n");
#nullable restore
#line 114 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                              if (User.IsInRole(WC.AdminRole))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row\">\n                                    <div class=\"col-12 text-right pr-4\" style=\"color:darkred\">\n                                        Order Total: $ ");
#nullable restore
#line 118 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                                  Write(orderTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </div>\n                                </div>\n");
#nullable restore
#line 121 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\n                    <div class=\"card-footer\">\n                        <div class=\"row\">\n                            <div class=\"col-6 col-md-3 offset-md-6\">\n");
#nullable restore
#line 127 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                 if (User.IsInRole(WC.AdminRole))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e4c81dae37b8fc8d2141ef1ed4b222a0c4ba55529729", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 130 "/Users/ingaliptn/Desktop/ASP_pract/ASP_pract/Views/Cart/Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>

                            <div class=""col-6 col-md-3 "">

                                <button type=""submit"" class=""btn btn-success form-control "">
                                    <span>Continue</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
