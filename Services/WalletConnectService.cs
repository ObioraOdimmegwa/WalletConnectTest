using System.Threading.Tasks;
using WalletConnectSharp.Core;
using WalletConnectSharp.Core.Models;

namespace walletConnect
{
    public class WalletConnectService
    {
        public WalletConnect wc;

        ClientMeta metaData = new ClientMeta
        {
            Description = "This is a test of the wallet connect feature",
            Icons = new[] { "https://wctest.azurewebsites.net/images/connect.png" },
            Name = "WalletConnect Test",
            URL = "https://wctest.azurewebsites.net"
        };
        const string bridgeUrl = "https://g.bridge.walletconnect.org";
        public WalletConnectService()
        {

            wc = new WalletConnect(clientMeta: metaData, bridgeUrl: bridgeUrl);
        }

        public Task Connect()
        {
            return wc.Connect();
        }

        public void Reset()
        {
            wc = new WalletConnect(clientMeta: metaData,bridgeUrl: bridgeUrl);
        }

        public Task Disconnect()
        {
            return wc.Disconnect();
        }
    }
}