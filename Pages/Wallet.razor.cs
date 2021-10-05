using System;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Components;
using Nethereum.JsonRpc.Client;
using WalletConnectSharp.Core;
using WalletConnectSharp.Core.Models;
using WalletConnectSharp.Core.Network;
using static WalletConnectSharp.Core.Models.WcSessionRequestRequest;

namespace walletConnect
{
    public class WalletComponent : ComponentBase
    {
        public string qrCodeImage = "images/qrcode.jpg";
        public string instructions = "Click button to generate connection code";
        public string state = "idle";


        [Inject]
        public WalletConnectService wcService { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        private Task<WCSessionData> sessionTask;

        protected override void OnInitialized()
        {
            wcService.wc.OnDisconnect += OnWalletSessionDisconnect;    
        }

        public async Task ConnectAsync()
        {
            instructions = "Scan QR code with your wallet to complete connection";
            state = "awaiting";
            qrCodeImage = $"https://chart.googleapis.com/chart?chs=500x500&cht=qr&chl={HttpUtility.UrlEncode(wcService.wc.URI)}";
            Console.WriteLine($"QR Code :: {wcService.wc.URI}");
            await wcService.wc.Connect();
            state = "connected";
            qrCodeImage = "images/check.png";
        }

        public async Task DisconnectAsync()
        {
            await wcService.wc.Disconnect();
            navigationManager.NavigateTo("/wallet",true);
        }
        public async Task Cancel()
        {
           navigationManager.NavigateTo("/wallet",true);
            state = "idle";
        }
        private void OnWalletSessionConnect(object sender, WalletConnect wc)
        {
            state = "connected";
        }
        private void OnWalletSessionDisconnect(object sender, WalletConnect wc)
        {
            navigationManager.NavigateTo("/wallet",true);
        }
        
    }
}