#pragma checksum "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53635e5e5765748bce9ab2ed7cb050d760e498b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Secimikibinonyedi_Bilgi), @"mvc.1.0.view", @"/Views/Secimikibinonyedi/Bilgi.cshtml")]
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
#line 1 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\_ViewImports.cshtml"
using Secimler;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\_ViewImports.cshtml"
using Secimler.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53635e5e5765748bce9ab2ed7cb050d760e498b8", @"/Views/Secimikibinonyedi/Bilgi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5727b158805816c9844db9a6c7061bdc847cfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Secimikibinonyedi_Bilgi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.ikibinonyedisecim>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Referandum/css/genel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Referandum/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml"
  
    Layout = "~/Views/Shared/_NavbarLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53635e5e5765748bce9ab2ed7cb050d760e498b84845", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>D3.js ile Referandum Oy Dağılımı</title>\r\n    <script src=\"https://d3js.org/d3.v7.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "53635e5e5765748bce9ab2ed7cb050d760e498b85343", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "53635e5e5765748bce9ab2ed7cb050d760e498b86521", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53635e5e5765748bce9ab2ed7cb050d760e498b88408", async() => {
                WriteLiteral(@"
    <header style=""background-color: #022032; color: white; padding: 20px; text-align: center;"">
        <h1>Referandum 2017</h1>
    </header>
    <div class=""content-wrapper"">
        <div class=""section"">
            <div class=""section-header"" style=""background-color: #022032; color: white;"">
                <h2>Oy Yüzde Grafikleri</h2>
            </div>
            <div class=""section-content"" style=""background-color: white; padding: 20px;"">

                <div style="" text-align: center;"" id=""grafik""></div>
                <div style=""display: flex; flex-direction: row; "">
                    <p style=""margin-left: 40%;""><b>Evet</b></p>
                    <p style=""margin-left: 13%;""><b>Hayır</b></p>
                </div>
            </div>
        </div>
        <div class=""section"">
            <div class=""section-header"" style=""background-color: #022032; color: white;"">
                <h2>Seçim Sonuçları</h2>
            </div>
            <div class=""section-content"" sty");
                WriteLiteral(@"le=""background-color: white; padding: 20px; text-align: center;"">
                <table>
                    <tr>

                        <th>Evet Oy Oranı</th>
                        <th>Hayır Oy Oranı</th>
                        <th>Kullanılan Toplam Oy Sayısı</th>
                    </tr>
                    <tr>
                     
                        <td>");
#nullable restore
#line 50 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml"
                       Write(Model.evetoyorani);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml"
                       Write(Model.hayiroyorani);

#line default
#line hidden
#nullable disable
                WriteLiteral(" %</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml"
                       Write(Model.oylayaninsansayisi);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                    </tr>
                </table>

            </div>
            <div class=""loader""></div>
        </div>
    </div>
    <footer style=""background-color: #022032; color: white; padding: 20px; text-align: center;"">
        <p>Tüm Hakları Saklıdır &copy; 2024</p>
    </footer>

    <script>
        // Veri setini JSON formatında tanımlama (örnek veri)
       var veri = [
            {
               oy_turu: ""Evet"",
               oy_orani: parseFloat(""");
#nullable restore
#line 69 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml"
                                Write(Model.evetoyorani);

#line default
#line hidden
#nullable disable
                WriteLiteral("\".replace(\',\', \'.\')), // Virgül yerine nokta kullanılarak float\'a dönüştürülüyor\r\n\r\n            },\r\n            {\r\n                oy_turu: \"Hayır\",\r\n                oy_orani: parseFloat(\"");
#nullable restore
#line 74 "C:\Users\Berke\Desktop\PROJELER\Aktif\Secimler\Secimler\Views\Secimikibinonyedi\Bilgi.cshtml"
                                 Write(Model.hayiroyorani);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""".replace(',', '.')), // Virgül yerine nokta kullanılarak float'a dönüştürülüyor
            },
        ];



        // SVG öğesi oluşturma
        var genislik = 400,
            yukseklik = 300;

        var svg = d3
            .select(""#grafik"")
            .append(""svg"")
            .attr(""width"", genislik)
            .attr(""height"", yukseklik);

        // Çubuk grafik oluşturma
        var x = d3
            .scaleBand()
            .domain(
                veri.map(function (d) {
                    return d.oy_turu;
                })
            )
            .range([0, genislik])
            .padding(0.1);

        var y = d3.scaleLinear().domain([0, 100]).range([yukseklik, 0]);

        svg
            .selectAll("".bar"")
            .data(veri)
            .enter()
            .append(""rect"")
            .attr(""class"", ""bar"")
            .attr(""x"", function (d) {
                return x(d.oy_turu);
            })
            .attr(""width"", x.bandwidth())
 ");
                WriteLiteral(@"           .attr(""y"", y(0))
            .attr(""height"", 0)
            .attr(""fill"", function (d) {
                if (d.oy_turu === ""Evet"") {
                    return ""blue"";
                } else {
                    return ""red"";
                }
            })
            .transition()
            .duration(1500) // Animasyon süresi
            .attr(""y"", function (d) {
                return y(d.oy_orani);
            })
            .attr(""height"", function (d) {
                return y(0) - y(d.oy_orani);
            });

        // Blokların altında oy oranlarının yazılması
        svg
            .selectAll(""text"")
            .data(veri)
            .enter()
            .append(""text"")
            .attr(""x"", function (d) {
                return x(d.oy_turu) + x.bandwidth() / 2;
            })
            .attr(""y"", function (d) {
                return y(0) + 20;
            }) // Blokların altında yer alacak şekilde 20 birim aşağı kaydırıyoruz
            .attr(");
                WriteLiteral(@"""text-anchor"", ""middle"")
            .text(function (d) {
                return d.oy_orani + ""%"";
            });

        // Eksenlerin oluşturulması
        svg
            .append(""g"")
            .attr(""transform"", ""translate(0,"" + y(0) + "")"")
            .call(d3.axisBottom(x))
            .append(""text"")
            .attr(""x"", genislik / 2)
            .attr(""y"", 40)
            .attr(""fill"", ""#000"")
            .attr(""text-anchor"", ""middle"")
            .text(""Oy Türü"");

        svg
            .append(""g"")
            .call(d3.axisLeft(y))
            .append(""text"")
            .attr(""transform"", ""rotate(-90)"")
            .attr(""y"", 6)
            .attr(""dy"", ""-3em"")
            .attr(""fill"", ""#000"")
            .attr(""text-anchor"", ""end"")
            .text(""Oy Oranı (%)"");

        // Grafik başlığının eklenmesi
        svg
            .append(""text"")
            .attr(""x"", genislik / 2)
            .attr(""y"", 20)
            .attr(""text-anchor"", ""middle"")
      ");
                WriteLiteral("      .style(\"font-size\", \"16px\")\r\n            .text(\"Referandum Oy Dağılımı\");\r\n    </script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.ikibinonyedisecim> Html { get; private set; }
    }
}
#pragma warning restore 1591
