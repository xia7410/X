﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 1 "..\..\Views\Shared\_Form_Action.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Action.cshtml")]
    public partial class _Views_Shared__Form_Action_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Action_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_Form_Action.cshtml"
  
    var entity = Model as IEntity;
    var isNew = entity.IsNullKey;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Shared\_Form_Action.cshtml"
 if (ManageProvider.User.Has(PermissionFlags.Insert, PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"clearfix form-actions col-md-12\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label col-md-4\"");

WriteLiteral("></label>\r\n        <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral("><i");

WriteAttribute("class", Tuple.Create(" class=\"", 356), Tuple.Create("\"", 410)
, Tuple.Create(Tuple.Create("", 364), Tuple.Create("glyphicon", 364), true)
, Tuple.Create(Tuple.Create(" ", 373), Tuple.Create("glyphicon-", 374), true)
            
            #line 10 "..\..\Views\Shared\_Form_Action.cshtml"
             , Tuple.Create(Tuple.Create("", 384), Tuple.Create<System.Object, System.Int32>(isNew ? "plus" : "save"
            
            #line default
            #line hidden
, 384), false)
);

WriteLiteral("></i><strong>");

            
            #line 10 "..\..\Views\Shared\_Form_Action.cshtml"
                                                                                                                               Write(isNew ? "新增" : "保存");

            
            #line default
            #line hidden
WriteLiteral("</strong></button>\r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger btn-sm\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral("></i><strong>取消</strong></button>\r\n    </div>\r\n");

            
            #line 13 "..\..\Views\Shared\_Form_Action.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
