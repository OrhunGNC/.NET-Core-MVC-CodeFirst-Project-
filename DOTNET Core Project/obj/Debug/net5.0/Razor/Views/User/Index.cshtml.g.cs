#pragma checksum "C:\Users\pc\Desktop\DOTNET Core Project\DOTNET Core Project\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "eeb96865e92e89c0e3a02aabb8579c7e5754b57a71bd9dbfbc07ab40c83b64c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\DOTNET Core Project\DOTNET Core Project\Views\_ViewImports.cshtml"
using DOTNET_Core_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\DOTNET Core Project\DOTNET Core Project\Views\_ViewImports.cshtml"
using DOTNET_Core_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"eeb96865e92e89c0e3a02aabb8579c7e5754b57a71bd9dbfbc07ab40c83b64c9", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5c9de9856f28950fc4a846e6c3bfd69264c473f65c78d9628285a98f875ca2a4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle flex-shrink-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/20230513_001941.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 40px; height: 40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\pc\Desktop\DOTNET Core Project\DOTNET Core Project\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("alt", async() => {
                WriteLiteral(@"
    <div class=""container-fluid pt-4 px-4"">
        <div class=""row g-4"">
            <div class=""col-sm-12 col-xl-6"">
                <div class=""bg-light text-center rounded p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <h6 class=""mb-0"">Worldwide Sales</h6>
                        <a");
                BeginWriteAttribute("href", " href=\"", 476, "\"", 483, 0);
                EndWriteAttribute();
                WriteLiteral(@">Show All</a>
                    </div>
                    <canvas id=""worldwide-sales""></canvas>
                </div>
            </div>
            <div class=""col-sm-12 col-xl-6"">
                <div class=""bg-light text-center rounded p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <h6 class=""mb-0"">Salse & Revenue</h6>
                        <a");
                BeginWriteAttribute("href", " href=\"", 920, "\"", 927, 0);
                EndWriteAttribute();
                WriteLiteral(@">Show All</a>
                    </div>
                    <canvas id=""salse-revenue""></canvas>
                </div>
            </div>
        </div>
    </div>
    <!-- Sales Chart End -->
    <!-- Recent Sales Start -->
    <div class=""container-fluid pt-4 px-4"">
        <div class=""bg-light text-center rounded p-4"">
            <div class=""d-flex align-items-center justify-content-between mb-4"">
                <h6 class=""mb-0"">Recent Salse</h6>
                <a");
                BeginWriteAttribute("href", " href=\"", 1417, "\"", 1424, 0);
                EndWriteAttribute();
                WriteLiteral(@">Show All</a>
            </div>
            <div class=""table-responsive"">
                <table class=""table text-start align-middle table-bordered table-hover mb-0"">
                    <thead>
                        <tr class=""text-dark"">
                            <th scope=""col""><input class=""form-check-input"" type=""checkbox""></th>
                            <th scope=""col"">Date</th>
                            <th scope=""col"">Invoice</th>
                            <th scope=""col"">Customer</th>
                            <th scope=""col"">Amount</th>
                            <th scope=""col"">Status</th>
                            <th scope=""col"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><input class=""form-check-input"" type=""checkbox""></td>
                            <td>01 Jan 2045</td>
                            <td>INV-0123</td>
                           ");
                WriteLiteral(" <td>Orhun Gença</td>\r\n                            <td>$123</td>\r\n                            <td>Paid</td>\r\n                            <td><a class=\"btn btn-sm btn-primary\"");
                BeginWriteAttribute("href", " href=\"", 2623, "\"", 2630, 0);
                EndWriteAttribute();
                WriteLiteral(@">Detail</a></td>
                        </tr>
                        <tr>
                            <td><input class=""form-check-input"" type=""checkbox""></td>
                            <td>01 Jan 2045</td>
                            <td>INV-0123</td>
                            <td>Orhun Gença</td>
                            <td>$123</td>
                            <td>Paid</td>
                            <td><a class=""btn btn-sm btn-primary""");
                BeginWriteAttribute("href", " href=\"", 3095, "\"", 3102, 0);
                EndWriteAttribute();
                WriteLiteral(@">Detail</a></td>
                        </tr>
                        <tr>
                            <td><input class=""form-check-input"" type=""checkbox""></td>
                            <td>01 Jan 2045</td>
                            <td>INV-0123</td>
                            <td>Orhun Gença</td>
                            <td>$123</td>
                            <td>Paid</td>
                            <td><a class=""btn btn-sm btn-primary""");
                BeginWriteAttribute("href", " href=\"", 3567, "\"", 3574, 0);
                EndWriteAttribute();
                WriteLiteral(@">Detail</a></td>
                        </tr>
                        <tr>
                            <td><input class=""form-check-input"" type=""checkbox""></td>
                            <td>01 Jan 2045</td>
                            <td>INV-0123</td>
                            <td>Orhun Gença</td>
                            <td>$123</td>
                            <td>Paid</td>
                            <td><a class=""btn btn-sm btn-primary""");
                BeginWriteAttribute("href", " href=\"", 4039, "\"", 4046, 0);
                EndWriteAttribute();
                WriteLiteral(@">Detail</a></td>
                        </tr>
                        <tr>
                            <td><input class=""form-check-input"" type=""checkbox""></td>
                            <td>01 Jan 2045</td>
                            <td>INV-0123</td>
                            <td>Orhun Gença</td>
                            <td>$123</td>
                            <td>Paid</td>
                            <td><a class=""btn btn-sm btn-primary""");
                BeginWriteAttribute("href", " href=\"", 4511, "\"", 4518, 0);
                EndWriteAttribute();
                WriteLiteral(@">Detail</a></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <!-- Recent Sales End -->
    <!-- Widgets Start -->
    <div class=""container-fluid pt-4 px-4"">
        <div class=""row g-4"">
            <div class=""col-sm-12 col-md-6 col-xl-4"">
                <div class=""h-100 bg-light rounded p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-2"">
                        <h6 class=""mb-0"">Messages</h6>
                        <a");
                BeginWriteAttribute("href", " href=\"", 5092, "\"", 5099, 0);
                EndWriteAttribute();
                WriteLiteral(">Show All</a>\r\n                    </div>\r\n                    <div class=\"d-flex align-items-center border-bottom py-3\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eeb96865e92e89c0e3a02aabb8579c7e5754b57a71bd9dbfbc07ab40c83b64c911696", async() => {
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
                WriteLiteral(@"
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 justify-content-between"">
                                <h6 class=""mb-0"">Orhun Gença</h6>
                                <small>15 minutes ago</small>
                            </div>
                            <span>Short message goes here...</span>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom py-3"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eeb96865e92e89c0e3a02aabb8579c7e5754b57a71bd9dbfbc07ab40c83b64c913605", async() => {
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
                WriteLiteral(@"
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 justify-content-between"">
                                <h6 class=""mb-0"">Orhun Gença</h6>
                                <small>15 minutes ago</small>
                            </div>
                            <span>Short message goes here...</span>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom py-3"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eeb96865e92e89c0e3a02aabb8579c7e5754b57a71bd9dbfbc07ab40c83b64c915514", async() => {
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
                WriteLiteral(@"
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 justify-content-between"">
                                <h6 class=""mb-0"">Orhun Gença</h6>
                                <small>15 minutes ago</small>
                            </div>
                            <span>Short message goes here...</span>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center pt-3"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "eeb96865e92e89c0e3a02aabb8579c7e5754b57a71bd9dbfbc07ab40c83b64c917409", async() => {
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
                WriteLiteral(@"
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 justify-content-between"">
                                <h6 class=""mb-0"">Orhun Gença</h6>
                                <small>15 minutes ago</small>
                            </div>
                            <span>Short message goes here...</span>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-sm-12 col-md-6 col-xl-4"">
                <div class=""h-100 bg-light rounded p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <h6 class=""mb-0"">Calender</h6>
                        <a");
                BeginWriteAttribute("href", " href=\"", 8046, "\"", 8053, 0);
                EndWriteAttribute();
                WriteLiteral(@">Show All</a>
                    </div>
                    <div id=""calender""></div>
                </div>
            </div>
            <div class=""col-sm-12 col-md-6 col-xl-4"">
                <div class=""h-100 bg-light rounded p-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-4"">
                        <h6 class=""mb-0"">To Do List</h6>
                        <a");
                BeginWriteAttribute("href", " href=\"", 8475, "\"", 8482, 0);
                EndWriteAttribute();
                WriteLiteral(@">Show All</a>
                    </div>
                    <div class=""d-flex mb-2"">
                        <input class=""form-control bg-transparent"" type=""text"" placeholder=""Enter task"">
                        <button type=""button"" class=""btn btn-primary ms-2"">Add</button>
                    </div>
                    <div class=""d-flex align-items-center border-bottom py-2"">
                        <input class=""form-check-input m-0"" type=""checkbox"">
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 align-items-center justify-content-between"">
                                <span>Short task goes here...</span>
                                <button class=""btn btn-sm""><i class=""fa fa-times""></i></button>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom py-2"">
                        <input class=""form-check-input m-0"" t");
                WriteLiteral(@"ype=""checkbox"">
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 align-items-center justify-content-between"">
                                <span>Short task goes here...</span>
                                <button class=""btn btn-sm""><i class=""fa fa-times""></i></button>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center border-bottom py-2"">
                        <input class=""form-check-input m-0"" type=""checkbox"" checked>
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 align-items-center justify-content-between"">
                                <span><del>Short task goes here...</del></span>
                                <button class=""btn btn-sm text-primary""><i class=""fa fa-times""></i></button>
                            </div>
                        </div>
                    <");
                WriteLiteral(@"/div>
                    <div class=""d-flex align-items-center border-bottom py-2"">
                        <input class=""form-check-input m-0"" type=""checkbox"">
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 align-items-center justify-content-between"">
                                <span>Short task goes here...</span>
                                <button class=""btn btn-sm""><i class=""fa fa-times""></i></button>
                            </div>
                        </div>
                    </div>
                    <div class=""d-flex align-items-center pt-2"">
                        <input class=""form-check-input m-0"" type=""checkbox"">
                        <div class=""w-100 ms-3"">
                            <div class=""d-flex w-100 align-items-center justify-content-between"">
                                <span>Short task goes here...</span>
                                <button class=""btn btn-sm""><i class=""fa fa-times""></");
                WriteLiteral("i></button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
