#pragma checksum "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43494bb189178385b34ea66992c156cae8ed5859"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryGroupComponent_CategoryGroups), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryGroupComponent/CategoryGroups.cshtml")]
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
#line 1 "E:\DgKala\DgKala\DgKala\Views\_ViewImports.cshtml"
using DgKala;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DgKala\DgKala\DgKala\Views\_ViewImports.cshtml"
using DgKala.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43494bb189178385b34ea66992c156cae8ed5859", @"/Views/Shared/Components/CategoryGroupComponent/CategoryGroups.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66cc2295c22569dc751550200b2a7e730c0e55a3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryGroupComponent_CategoryGroups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DgKala.Models.Entities.Category.CategoryGroups>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<nav class=\"main-menu\">\r\n    <div class=\"container\">\r\n        <ul class=\"list float-right\">\r\n");
#nullable restore
#line 7 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
             foreach (var group in Model.Where(p => p.ParentID == null))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-item list-item-has-children mega-menu mega-menu-col-5\">\r\n                    <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 382, "\"", 428, 2);
            WriteAttributeValue("", 389, "/Category?selectedGroups=", 389, 25, true);
#nullable restore
#line 10 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
WriteAttributeValue("", 414, group.GroupId, 414, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 10 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
                                                                                  Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <ul class=\"sub-menu nav\">\r\n\r\n\r\n                        <li class=\"list-item list-item-has-children\">\r\n                            <i class=\"now-ui-icons arrows-1_minimal-left\"></i>\r\n");
            WriteLiteral("                            <ul class=\"sub-menu nav\">\r\n                                <ul>\r\n");
#nullable restore
#line 22 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
                                     if (Model.Any(p => p.ParentID == group.GroupId))
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
                                         foreach (var group2 in Model.Where(p => p.ParentID == group.GroupId))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"list-item\">\r\n                                                <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1338, "\"", 1385, 2);
            WriteAttributeValue("", 1345, "/Category?selectedGroups=", 1345, 25, true);
#nullable restore
#line 28 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
WriteAttributeValue("", 1370, group2.GroupId, 1370, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
                                                                                                               Write(group2.GroupTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 30 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n\r\n                            </ul>\r\n                        </li>\r\n\r\n                    </ul>\r\n                </li>\r\n");
#nullable restore
#line 39 "E:\DgKala\DgKala\DgKala\Views\Shared\Components\CategoryGroupComponent\CategoryGroups.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n\r\n\r\n    </div>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DgKala.Models.Entities.Category.CategoryGroups>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
