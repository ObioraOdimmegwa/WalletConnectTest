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
        public bool awaitingConnection = false;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            wcService.wc.OnDisconnect += OnWalletSessionDisconnect;
            wcService.wc.Transport.MessageReceived += OnMessageReceived;
        }

        [Inject]
        public WalletConnectService wcService { get; set; }

        private Task<WCSessionData> sessionTask;
        public async Task ConnectAsync()
        {
            instructions = "Scan QR code with your wallet to complete connection";
            awaitingConnection = true;
            qrCodeImage = $"https://chart.googleapis.com/chart?chs=500x500&cht=qr&chl={HttpUtility.UrlEncode(wcService.wc.URI)}";
            Console.WriteLine($"QR Code :: {wcService.wc.URI}");
            var data = await wcService.wc.Connect();
            await wcService.wc.Transport.SendMessage(new NetworkMessage{

            });
            await wcService.wc.SendRequest<JsonRpcRequest>(new JsonRpcRequest(){
            },"new Message topic",false);
        //    client.SendRequestAsync(
            // await wcService.wc
            // wcService.wc.Transport.Open(wcService.wc)
        }

        public async Task DisconnectAsync()
        {
            qrCodeImage = "images/qrcode.jpg";
            instructions = "Click button to generate connection code";
            awaitingConnection = false;
            await wcService.wc.Disconnect();
        }

        private void OnWalletSessionConnect(object sender, WalletConnect wc)
        {
            Console.WriteLine("Connected");
        }
        private void OnWalletSessionDisconnect(object sender, WalletConnect wc)
        {
            Console.WriteLine("Disconnected");
        }
        protected void OnMessageReceived(object sender, MessageReceivedEventArgs args)
        {
            Console.WriteLine($"{args.Source} : {args.Message.Type} : {args.Message.Topic} : {args.Message.Payload}");
        }
    }
}