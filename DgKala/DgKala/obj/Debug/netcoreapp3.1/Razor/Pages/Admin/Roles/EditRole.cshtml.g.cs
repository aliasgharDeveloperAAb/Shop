#pragma checksum "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fb4e2e7511518ab6971d26489a81db197e6dfc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_EditRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/EditRole.cshtml")]
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
#line 1 "E:\DgKala\DgKala\DgKala\Pages\_ViewImports.cshtml"
using DgKala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DgKala\DgKala\DgKala\Pages\_ViewImports.cshtml"
using DgKala.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
using DgKala.Models.Entities.Permissions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fb4e2e7511518ab6971d26489a81db197e6dfc8", @"/Pages/Admin/Roles/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cc2295c22569dc751550200b2a7e730c0e55a3", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Admin_Roles_EditRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
  
    ViewData["Title"] = "ویرایش نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">  ویرایش نقش ها   </h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fb4e2e7511518ab6971d26489a81db197e6dfc85859", async() => {
                WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            <div class=\"panel panel-primary\">\r\n                <div class=\"panel-heading\">\r\n                    ویرایش نقش  \"");
#nullable restore
#line 20 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                            Write(Model.Role.RoleTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                </div>\r\n                <!-- /.panel-heading -->\r\n                <div class=\"panel-body\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fb4e2e7511518ab6971d26489a81db197e6dfc86661", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9fb4e2e7511518ab6971d26489a81db197e6dfc88365", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.IsDelete);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <label>عنوان نقش : </label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9fb4e2e7511518ab6971d26489a81db197e6dfc810184", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 29 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>

                    <div class=""form-group"">

                        <input type=""submit"" class=""btn btn-success"" value=""ذخیره اطلاعات "" />
                    </div>
                </div>
            </div>





            <!-- /.panel -->
        </div>
        <div class=""col-md-4"">
            <div class=""panel-primary"">
                <div class=""panel-heading"">
                    دسترسی های نقش ها
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
");
#nullable restore
#line 52 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                      
                        List<int> selectedPermissions = ViewData["SelectedPermission"] as List<int>;
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul>\r\n");
#nullable restore
#line 56 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectPermission\" ");
#nullable restore
#line 59 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                           Write((selectedPermissions.Any(p=>p==permission.PermissionId)?"checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 59 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                          Write(permission.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />");
#nullable restore
#line 59 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                      Write(permission.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                                <ul>\r\n");
#nullable restore
#line 62 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                     if (permissions.Any(p => p.ParentID == permission.ParentID))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"SelectPermission\" ");
#nullable restore
#line 67 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                           Write((selectedPermissions.Any(p=>p==sub.PermissionId)?"checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 67 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                   Write(sub.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />");
#nullable restore
#line 67 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                        Write(sub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 69 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                 if (permissions.Any(p => p.ParentID == sub.ParentID))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <ul>\r\n");
#nullable restore
#line 72 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <li>\r\n                                                                <input type=\"checkbox\" ");
#nullable restore
#line 75 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                   Write((selectedPermissions.Any(p=>p==sub2.PermissionId)?"checked":""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectPermission\" value=\"");
#nullable restore
#line 75 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                    Write(sub2.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" />");
#nullable restore
#line 75 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                          Write(sub2.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </li>\r\n");
#nullable restore
#line 77 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </ul>\r\n");
#nullable restore
#line 79 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </li>\r\n");
#nullable restore
#line 81 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n                            </li>\r\n");
#nullable restore
#line 85 "E:\DgKala\DgKala\DgKala\Pages\Admin\Roles\EditRole.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DgKala.Pages.Admin.Roles.EditRoleModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DgKala.Pages.Admin.Roles.EditRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DgKala.Pages.Admin.Roles.EditRoleModel>)PageContext?.ViewData;
        public DgKala.Pages.Admin.Roles.EditRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
