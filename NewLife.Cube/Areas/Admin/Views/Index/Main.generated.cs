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
    
    #line 2 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 1 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Diagnostics;
    
    #line default
    #line hidden
    using System.IO;
    using System.Linq;
    using System.Net;
    
    #line 3 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Reflection;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using System.Runtime.Versioning;
    
    #line default
    #line hidden
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
    
    #line 5 "..\..\Areas\Admin\Views\Index\Main.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/Main.cshtml")]
    public partial class _Areas_Admin_Views_Index_Main_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index_Main_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Areas\Admin\Views\Index\Main.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    ViewBag.Title = "服务器信息";
    var Act = ViewBag.Act;

    var asm = Assembly.GetExecutingAssembly();
    var att = asm.GetCustomAttribute<TargetFrameworkAttribute>();
    var ver = att.FrameworkDisplayName ?? att.FrameworkName;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Areas\Admin\Views\Index\Main.cshtml"
 if (String.IsNullOrEmpty(Act))
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th");

WriteLiteral(" colspan=\"4\"");

WriteLiteral(">\r\n                    服务器信息\r\n                </th>\r\n            </tr>\r\n        <" +
"/thead>\r\n        <tbody>\r\n            <tr>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    应用系统：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 32 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(HttpRuntime.AppDomainAppVirtualPath);

            
            #line default
            #line hidden
WriteLiteral("&nbsp;<a");

WriteAttribute("href", Tuple.Create(" href=\"", 935), Tuple.Create("\"", 969)
            
            #line 32 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 942), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Restart")
            
            #line default
            #line hidden
, 942), false)
);

WriteLiteral(" onclick=\"return confirm(\'仅重启ASP.Net应用程序域，而不是操作系统！\\n确认重启？\')\"");

WriteLiteral(">重启应用系统</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    目录：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 38 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(HttpRuntime.AppDomainAppPath);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    域名地址：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" title=\"SERVER_NAME\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                         Write(Request.ServerVariables["SERVER_NAME"]);

            
            #line default
            #line hidden
WriteLiteral("</span>，\r\n                    <span");

WriteLiteral(" title=\"LOCAl_ADDR\"");

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                        Write(Request.ServerVariables["LOCAl_ADDR"]);

            
            #line default
            #line hidden
WriteLiteral(":");

            
            #line 47 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                               Write(Request.ServerVariables["Server_Port"]);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    &nbsp;<span");

WriteLiteral(" title=\"REMOTE_HOST\"");

WriteLiteral(">[");

            
            #line 48 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                Write(Request.ServerVariables["REMOTE_HOST"]);

            
            #line default
            #line hidden
WriteLiteral("]</span>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1768), Tuple.Create("\"", 1804)
            
            #line 49 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/ServerVar")
            
            #line default
            #line hidden
, 1775), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开服务器变量列表\"");

WriteLiteral(">服务器变量列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    计算机用户：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 55 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Environment.UserName);

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 55 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                     Write(Environment.MachineName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    应用程序域：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 63 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(AppDomain.CurrentDomain.FriendlyName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2331), Tuple.Create("\"", 2366)
            
            #line 64 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 2338), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Assembly")
            
            #line default
            #line hidden
, 2338), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开进程程序集列表\"");

WriteLiteral(">程序集列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    .Net 版本：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 70 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Environment.Version);

            
            #line default
            #line hidden
WriteLiteral(" &nbsp;");

            
            #line 70 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                          Write(ver);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    操作系统：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 78 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Runtime.OSName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Web服务器：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 84 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(ViewBag.WebServerName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    处理器：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 92 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Environment.ProcessorCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    核心\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    时间：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(" title=\"这里使用了服务器默认的时间格式！后面是开机时间。\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 99 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(DateTime.Now);

            
            #line default
            #line hidden
WriteLiteral("，开机");

            
            #line 99 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                Write(new TimeSpan(0, 0, 0, 0, Environment.TickCount));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n");

            
            #line 103 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                
            
            #line default
            #line hidden
            
            #line 103 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   var process = Process.GetCurrentProcess();
            
            #line default
            #line hidden
WriteLiteral("\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    内存：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n                    物理内存：");

            
            #line 108 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                     Write(Runtime.AvailableMemory.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M / ");

            
            #line 108 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                  Write(Runtime.PhysicalMemory.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                    工作集: ");

            
            #line 109 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                     Write((process.WorkingSet64 / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                    提交: ");

            
            #line 110 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    Write((process.PrivateMemorySize64 / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                    GC: ");

            
            #line 111 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    Write((GC.GetTotalMemory(false) / 1024 / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("M\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4172), Tuple.Create("\"", 4213)
            
            #line 112 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 4179), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/ProcessModules")
            
            #line default
            #line hidden
, 4179), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开进程模块列表\"");

WriteLiteral(">模块列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    进程时间：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 118 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(process.TotalProcessorTime.TotalSeconds.ToString("N2"));

            
            #line default
            #line hidden
WriteLiteral("秒 启动于 ");

            
            #line 118 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                            Write(process.StartTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td" +
"");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Session：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 126 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Session.Contents.Count);

            
            #line default
            #line hidden
WriteLiteral(" 个，");

            
            #line 126 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                         Write(Session.Timeout);

            
            #line default
            #line hidden
WriteLiteral(" 分钟，SessionID：");

            
            #line 126 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                                                       Write(Session.Contents.SessionID);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4831), Tuple.Create("\"", 4865)
            
            #line 127 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 4838), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Session")
            
            #line default
            #line hidden
, 4838), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开Session列表\"");

WriteLiteral(">Session列表</a>\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                    Cache：\r\n                </td>\r\n                <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 133 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Cache.Count);

            
            #line default
            #line hidden
WriteLiteral(" 个，可用：");

            
            #line 133 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                  Write((Cache.EffectivePrivateBytesLimit / 1024).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("KB\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 5188), Tuple.Create("\"", 5220)
            
            #line 134 "..\..\Areas\Admin\Views\Index\Main.cshtml"
, Tuple.Create(Tuple.Create("", 5195), Tuple.Create<System.Object, System.Int32>(Url.Action("Main/Cache")
            
            #line default
            #line hidden
, 5195), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" title=\"点击打开Cache列表\"");

WriteLiteral(">Cache列表</a>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </t" +
"able>\r\n");

WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(@">
        <thead>
            <tr>
                <th>名称</th>
                <th>标题</th>
                <th>文件版本</th>
                <th>内部版本</th>
                <th>编译时间</th>
                <th>描述</th>
            </tr>
        </thead>
        <tbody>
");

            
            #line 151 "..\..\Areas\Admin\Views\Index\Main.cshtml"
            
            
            #line default
            #line hidden
            
            #line 151 "..\..\Areas\Admin\Views\Index\Main.cshtml"
             foreach (AssemblyX item in ViewBag.MyAsms)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>");

            
            #line 154 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 155 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 156 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.FileVersion);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 157 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Version);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 158 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Compile.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 159 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(item.Description);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n");

            
            #line 161 "..\..\Areas\Admin\Views\Index\Main.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");

            
            #line 164 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    }

            
            #line default
            #line hidden
            
            #line 165 "..\..\Areas\Admin\Views\Index\Main.cshtml"
 if (Act == "ProcessModules")
{
    var isAll = String.Equals("All", Request["Mode"], StringComparison.OrdinalIgnoreCase);

    var process = Process.GetCurrentProcess();
    var list = new List<ProcessModule>();
    foreach (ProcessModule item in process.Modules)
    {
        if (isAll || item.FileVersionInfo.CompanyName != "Microsoft Corporation") { list.Add(item); }
    }


            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <tr>\r\n            <th");

WriteLiteral(" colspan=\"7\"");

WriteLiteral(">\r\n                进程模块(");

            
            #line 179 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                Write(process.ProcessName);

            
            #line default
            #line hidden
WriteLiteral(" , PID=");

            
            #line 179 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                                           Write(process.Id);

            
            #line default
            #line hidden
WriteLiteral(" )\r\n");

            
            #line 180 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                
            
            #line default
            #line hidden
            
            #line 180 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                 if (!isAll)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("（<a");

WriteLiteral(" href=\"?Mode=All\"");

WriteLiteral(">完整</a>，仅用户）：");

WriteLiteral("\r\n");

            
            #line 183 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("（完整，<a");

WriteLiteral(" href=\"?Mode=OnlyUser\"");

WriteLiteral(">仅用户</a>）：");

WriteLiteral("\r\n");

            
            #line 187 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral(@"            </th>
        </tr>
        <tr>
            <th>
                模块名称
            </th>
            <th>
                公司名称
            </th>
            <th>
                产品名称
            </th>
            <th>
                描述
            </th>
            <th>
                版本
            </th>
            <th>
                大小
            </th>
            <th>
                路径
            </th>
        </tr>
");

            
            #line 213 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        
            
            #line default
            #line hidden
            
            #line 213 "..\..\Areas\Admin\Views\Index\Main.cshtml"
         foreach (ProcessModule item in list)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 217 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.ModuleName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 220 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.FileVersionInfo.CompanyName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 223 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.FileVersionInfo.ProductName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 226 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.FileVersionInfo.FileDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 229 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.FileVersionInfo.FileVersion);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 232 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.ModuleMemorySize);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 235 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.FileName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 238 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 240 "..\..\Areas\Admin\Views\Index\Main.cshtml"
}

            
            #line default
            #line hidden
            
            #line 241 "..\..\Areas\Admin\Views\Index\Main.cshtml"
 if (Act == "Assembly")
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <tr>\r\n            <th");

WriteLiteral(" colspan=\"6\"");

WriteLiteral(">\r\n                程序集列表(");

            
            #line 246 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                 Write(AppDomain.CurrentDomain.FriendlyName);

            
            #line default
            #line hidden
WriteLiteral(" )\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n            <th>名称</th>\r\n    " +
"        <th>标题</th>\r\n            <th>文件版本</th>\r\n            <th>内部版本</th>\r\n     " +
"       <th>编译时间</th>\r\n            <th>路径</th>\r\n        </tr>\r\n");

            
            #line 257 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        
            
            #line default
            #line hidden
            
            #line 257 "..\..\Areas\Admin\Views\Index\Main.cshtml"
         foreach (AssemblyX item in ViewBag.Asms)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 261 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 264 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 267 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.FileVersion);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>");

            
            #line 269 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Version);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 270 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Compile.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>\r\n");

            
            #line 272 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 272 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                      
                        var location = String.Empty;
                        try
                        {
                            location = item.Asm.Location;
                        }
                        catch { }
                    
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                    ");

            
            #line 280 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(location);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 283 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 285 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                        }

            
            #line default
            #line hidden
            
            #line 286 "..\..\Areas\Admin\Views\Index\Main.cshtml"
 if (Act == "Session")
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <tr>\r\n            <th");

WriteLiteral(" colspan=\"6\"");

WriteLiteral(">\r\n                Session列表(");

            
            #line 291 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                     Write(Session.Contents.Count);

            
            #line default
            #line hidden
WriteLiteral(" )\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n            <th>名称</th>\r\n    " +
"        <th>类型</th>\r\n            <th>数值</th>\r\n        </tr>\r\n");

            
            #line 299 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        
            
            #line default
            #line hidden
            
            #line 299 "..\..\Areas\Admin\Views\Index\Main.cshtml"
         foreach (String item in Session.Keys)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 302 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 303 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Session[item].GetType().FullName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 304 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Session[item]);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 306 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 308 "..\..\Areas\Admin\Views\Index\Main.cshtml"
}

            
            #line default
            #line hidden
            
            #line 309 "..\..\Areas\Admin\Views\Index\Main.cshtml"
 if (Act == "Cache")
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <tr>\r\n            <th");

WriteLiteral(" colspan=\"6\"");

WriteLiteral(">\r\n                Cache列表(");

            
            #line 314 "..\..\Areas\Admin\Views\Index\Main.cshtml"
                   Write(Cache.Count);

            
            #line default
            #line hidden
WriteLiteral(" )\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n            <th>名称</th>\r\n    " +
"        <th>类型</th>\r\n            <th>数值</th>\r\n        </tr>\r\n");

            
            #line 322 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        
            
            #line default
            #line hidden
            
            #line 322 "..\..\Areas\Admin\Views\Index\Main.cshtml"
         foreach (DictionaryEntry item in Cache)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 325 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 326 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Value.GetType().FullName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 327 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 329 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 331 "..\..\Areas\Admin\Views\Index\Main.cshtml"
}

            
            #line default
            #line hidden
            
            #line 332 "..\..\Areas\Admin\Views\Index\Main.cshtml"
 if (Act == "ServerVar")
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n        <tr>\r\n            <th");

WriteLiteral(" colspan=\"6\"");

WriteLiteral(">\r\n                服务器变量列表\r\n            </th>\r\n        </tr>\r\n        <tr>\r\n     " +
"       <th>名称</th>\r\n            <th>数值</th>\r\n        </tr>\r\n");

            
            #line 344 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        
            
            #line default
            #line hidden
            
            #line 344 "..\..\Areas\Admin\Views\Index\Main.cshtml"
         foreach (var key in Request.ServerVariables.AllKeys)
        {
            var v = Request.ServerVariables[key];
            v = v.Replace("\r\n", "</br>");
            if (key.EqualIgnoreCase("HTTP_COOKIE")) { v = v.Replace(";", "</br>"); }

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>");

            
            #line 350 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(key);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 351 "..\..\Areas\Admin\Views\Index\Main.cshtml"
               Write(Html.Raw(v));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n            </tr>\r\n");

            
            #line 353 "..\..\Areas\Admin\Views\Index\Main.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 355 "..\..\Areas\Admin\Views\Index\Main.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
