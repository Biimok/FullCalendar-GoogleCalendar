#pragma checksum "C:\Labs\CalendarioComGoogle\CalendarioComGoogle2\CalendarioComGoogle2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24c8532e6dc607e863ef4d20908d8337b71cae55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Labs\CalendarioComGoogle\CalendarioComGoogle2\CalendarioComGoogle2\Views\_ViewImports.cshtml"
using CalendarioComGoogle2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Labs\CalendarioComGoogle\CalendarioComGoogle2\CalendarioComGoogle2\Views\_ViewImports.cshtml"
using CalendarioComGoogle2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24c8532e6dc607e863ef4d20908d8337b71cae55", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b324586bac19c074d517702791c888295048c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<!-- template from http://getbootstrap.com/getting-started -->\r\n\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24c8532e6dc607e863ef4d20908d8337b71cae553384", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Bootstrap 101 Template</title>

    <!-- CSS Includes -->
    <link rel=""stylesheet"" href=""//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.0.1/fullcalendar.min.css"">

    <style type=""text/css"">
        .field-validation-error {
            color: #ff0000;
        }

        .spinner {
            position: absolute;
            left:50%;
            top:50%;
            width:100px;
            height:100px;
            border-radius:50%;
            background:conic-gradient(#0000 10%,#25b09b);
            -webkit-mask:radial-gradient(farthest-side,#0000 calc(100% - 15px),#000 0);
            animation:s3 1s infinite linear;
            }
            ");
                WriteLiteral("@keyframes s3 {to{transform: rotate(1turn)}}\r\n    </style>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24c8532e6dc607e863ef4d20908d8337b71cae555432", async() => {
                WriteLiteral("\r\n    <div id=\"pai\" class=\"container\">\r\n        <div id=\'calendar\' data-url-get=\'");
#nullable restore
#line 37 "C:\Labs\CalendarioComGoogle\CalendarioComGoogle2\CalendarioComGoogle2\Views\Home\Index.cshtml"
                                    Write(Url.RouteUrl(new{ action= "ConsultarAgendamentos", controller="Home"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            data-url-create=\'");
#nullable restore
#line 38 "C:\Labs\CalendarioComGoogle\CalendarioComGoogle2\CalendarioComGoogle2\Views\Home\Index.cshtml"
                        Write(Url.RouteUrl(new{ action= "CriarAgendamentos", controller="Home"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            data-url-delete=\'");
#nullable restore
#line 39 "C:\Labs\CalendarioComGoogle\CalendarioComGoogle2\CalendarioComGoogle2\Views\Home\Index.cshtml"
                        Write(Url.RouteUrl(new{ action= "DeletarAgendamentos", controller="Home"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'>
        </div>
    </div>

    <!-- JS includes -->
    <script src=""//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js""></script>
    <script src=""//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js""></script>

    <script src=""//ajax.aspnetcdn.com/ajax/jquery.validate/1.11.1/jquery.validate.min.js""></script>
    <script src=""//ajax.aspnetcdn.com/ajax/mvc/4.0/jquery.validate.unobtrusive.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.16.0/moment.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.0.1/fullcalendar.min.js""></script>

    <script type=""text/javascript"">
        var calendar = document.getElementById(""calendar"");
        var spinner = document.createElement('div');
        var container = document.getElementById(""pai"");
        spinner.setAttribute('class', 'spinner');

	    $(document).ready(function () {
		    $(calendar).fullCalendar({
        	    header: {
            	    ");
                WriteLiteral(@"left: 'prev,next today',
            	    center: 'title',
            	    right: 'month,agendaWeek,agendaDay'
                },
                

                firstDay: 1, //The day that each week begins (Monday=1)
                slotMinutes: 60,
                events: calendar.getAttribute(""data-url-get""),
                dayClick: function(date, jsEvent, view) {
                    let dataFormatada = date.format(""YYYY/MM/DD HH:mm:ss"");
                    $.ajax({
                        url:calendar.getAttribute(""data-url-create""),
                        type:'post', 
                        data:'data=' + dataFormatada,
                        beforeSend:function(){
                            $(calendar).css(""opacity"", 0.4);
                            container.appendChild(spinner);
                        }, 
                        complete:function(){
                            location.reload();
                        },
                        success:function(data");
                WriteLiteral(@"){
                            console.log(data);
                        }, 
                        error:function(error){
                            console.log(error);
                        }
                    });

                },
                eventClick: function(calEvent, jsEvent, view) {
                    let idEvento = calEvent.id;
                    $.ajax({
                        url:calendar.getAttribute(""data-url-delete""),
                        type:'delete', 
                        data: 'data=' + idEvento,
                        beforeSend:function(){
                            $(calendar).css(""opacity"", 0.4);
                            container.appendChild(spinner);
                        }, 
                        complete:function(){
                            location.reload();
                        },
                        success:function(data){
                            console.log(data);
                        }, 
                 ");
                WriteLiteral("       error:function(error){\r\n                            console.log(error);\r\n                        }\r\n                    });\r\n\r\n                }\r\n            });\r\n        });\r\n\r\n            \r\n    </script>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591