#pragma checksum "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d04ec6579f56a0e2cc4f3515f8457df119ea579b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
using WebBookshelf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d04ec6579f56a0e2cc4f3515f8457df119ea579b", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a67e1bc04bd13950d2576b6c5ab68b6edae8296", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kitap Adı</th>\r\n        <th>Yazar</th>\r\n        <th>Tür</th>\r\n        <th></th>\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
           Write(item.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
           Write(item.BookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
           Write(item.BookWriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 589, "\"", 628, 2);
            WriteAttributeValue("", 596, "/Default/UpdateBook/", 596, 20, true);
#nullable restore
#line 27 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
WriteAttributeValue("", 616, item.BookId, 616, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-block\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 740, 2);
            WriteAttributeValue("", 708, "/Default/DeleteBook/", 708, 20, true);
#nullable restore
#line 28 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
WriteAttributeValue("", 728, item.BookId, 728, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-block\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Emre\OneDrive\Masaüstü\WebBookshelf\WebBookshelf\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Default/AddBook/\" class=\"btn btn-primary\">Kitap Ekle</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591