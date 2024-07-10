using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worken_sdk_unity.Wallet.model.walletObject
{
    public class Wallet
    {
        public Account Account { get; set; }
        public Mnemonic Mnemonic { get; set; }
    }
}
