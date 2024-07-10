using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using worken_sdk_unity.Wallet.model.walletObject;

namespace worken_sdk_unity.Wallet.model
{
    public class WalletCreationResponse : IResponse<WalletData>
    {
        public HttpStatusCode status { get; set; }

        public string? message { get; set; }

        public WalletData? data { get; set; }
    }
}
