#pragma checksum "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8bd1deb5ef63ce24486dfbe8c6e9292270db983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Index), @"mvc.1.0.view", @"/Views/Questions/Index.cshtml")]
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
#line 1 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\_ViewImports.cshtml"
using DevBuildLab14_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\_ViewImports.cshtml"
using DevBuildLab14_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8bd1deb5ef63ce24486dfbe8c6e9292270db983", @"/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1717e011f27642c44c36bae7da4769aa65a58e82", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Questions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Questions Posted By Users</h1>

<table style=""width:75%"">
    <tr>
        <th>ID</th>
        <th>Username</th>
        <th>Title</th>
        <th>Details</th>
        <th>Category</th>
        <th>Posted</th>
        <th>Tags</th>
        <th>Status</th>
    </tr>
    <tbody>

");
#nullable restore
#line 21 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
         foreach (Questions ques in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 27 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 28 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 29 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 30 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.tags);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>");
#nullable restore
#line 31 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
           Write(ques.status);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 754, "\"", 797, 2);
            WriteAttributeValue("", 761, "/questions/editquestionform/", 761, 28, true);
#nullable restore
#line 33 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
WriteAttributeValue("", 789, ques.id, 789, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size:x-small\" class=\"btn btn-info\"> Edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 916, 2);
            WriteAttributeValue("", 882, "/questions/deletequestion/", 882, 26, true);
#nullable restore
#line 34 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"
WriteAttributeValue("", 908, ques.id, 908, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size:x-small\" class=\"btn btn-danger\"> Delete</a>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Workgroup\StackOverFlow\DevBuildLab14_2\Views\Questions\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table><br />\r\n\r\n<h3><a href=\"questions/AskQuestionForm\">Please submit a question</a></h3>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
