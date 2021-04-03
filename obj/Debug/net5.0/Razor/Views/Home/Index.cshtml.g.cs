#pragma checksum "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de991ccc09f1366569c8e9192171a27d0a48262"
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
#line 1 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\_ViewImports.cshtml"
using BridgeMonitor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de991ccc09f1366569c8e9192171a27d0a48262", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f76db85423d1966422131999df760b0ec79fa9c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Closing>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Prochaine Fermeture</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Cause / Bateau</th>
            <th>Date de la fermeture</th>
            <th>Heure de réouverture</th>
            <th>Durée de la prochaine fermeture</th>
            <th>Décompte</th>
            <th>Risque de bouchons</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
         foreach (var nextBoat in Model)
        {
            var Closed = nextBoat.ReopeningDate - nextBoat.ClosingDate;

            if (DateTime.Now < nextBoat.ClosingDate)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                   Write(nextBoat.BoatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                   Write(nextBoat.ClosingDate.ToString("F", new System.Globalization.CultureInfo("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                   Write(nextBoat.ReopeningDate.ToString("F", new System.Globalization.CultureInfo("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                   Write(Closed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <div id=\"countdown\"></div>\r\n                        <p id=\"nextclose\" style=\"display: none;\">");
#nullable restore
#line 33 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                                                            Write(nextBoat.ClosingDate.ToString("o"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <script>
                            var countDownDate = new Date(document.getElementById(""nextclose"").innerHTML).getTime()
                            var x = setInterval(function () {
                                var now = new Date().getTime();
                                var distance = countDownDate - now;
                                var days = Math.floor(distance / (1000 * 60 * 60 * 24));
                                var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
                                var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
                                var seconds = Math.floor((distance % (1000 * 60)) / 1000);
                                document.getElementById(""countdown"").innerHTML = ""Encore "" + days + "" jour(s), "" + hours + "" heure(s) ""
                                    + minutes + "" minutes et "" + seconds + "" secondes avant la prochaine fermeture"";
                  ");
            WriteLiteral("          }, 1000);\r\n                        </script>\r\n                    </td>\r\n");
#nullable restore
#line 48 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                     if ((7 <= nextBoat.ClosingDate.Hour & nextBoat.ClosingDate.Hour <= 9) | (17 <= nextBoat.ClosingDate.Hour &
            nextBoat.ClosingDate.Hour <= 19))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Elevé</td>\r\n");
#nullable restore
#line 52 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>Faible</td>\r\n");
#nullable restore
#line 56 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\admin\Desktop\ynov\B2\c#\BridgeMonitor\BridgeMonitor\Views\Home\Index.cshtml"
                break;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Closing>> Html { get; private set; }
    }
}
#pragma warning restore 1591
