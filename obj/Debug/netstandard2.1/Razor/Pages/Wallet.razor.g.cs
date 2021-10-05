#pragma checksum "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2d26be7e2431e3041ffc7cb82b9f7e3103b20e"
// <auto-generated/>
#pragma warning disable 1591
namespace walletConnect.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using walletConnect;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Expl0it90\Desktop\walletConnect\_Imports.razor"
using walletConnect.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/wallet")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Wallet : WalletComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"/css/styles.css\">\r\n<link rel=\"stylesheet\" href=\"/css/vendor.css\">\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-table w-100 h-100 pt-5");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-table-cell align-middle");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<div class=""card__topbar"">
                <div class=""d-flex justify-content-between align-items-center"">
                    <div class=""card__logo"">
                        <span style=""font-size: 1.05rem; font-weight:bold;"">Wallet Connect Test</span>
                    </div>
                </div>
            </div>
            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card__body");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, @"<div class=""card__branding text-center"">
                    <img src=""https://www.filehosting.org/file/download/963553/NuNVTTl6EppFBxPa"" alt=""connect"" title=""Logo"" style=""width: 150px; max-height: 150px !important; height:150px;"">
                </div>
                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group text-center");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "style", "color: gray;font-size: 1.1rem;font-weight:600;");
            __builder.AddContent(20, 
#nullable restore
#line 25 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                                                                               instructions

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "style", "width: 100%;height: 20rem;border-radius: 10px;outline: 2px solid #30D5DB;");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "img");
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 29 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                                   qrCodeImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "class", "background-image");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group text-center pt-2");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 33 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                     if (!awaitingConnection)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                                          ConnectAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-success");
            __builder.AddAttribute(42, "style", "padding: 1rem; width: 50%;");
            __builder.AddMarkupContent(43, "\r\n                            Connect\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 38 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                     if (awaitingConnection)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                        ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                                          DisconnectAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "btn btn-danger");
            __builder.AddAttribute(49, "style", "padding: 1rem; width: 50%;");
            __builder.AddMarkupContent(50, "\r\n                            Disconnect\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 44 "C:\Users\Expl0it90\Desktop\walletConnect\Pages\Wallet.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n");
            __builder.AddMarkupContent(58, @"<style>
    .background-image {
        background-color: #ffffff;
        height: 100%;
        width: 100%;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        position: relative;
    }
</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591