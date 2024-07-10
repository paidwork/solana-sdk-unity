namespace worken_sdk_unity.Wallet.model.walletObject
{
    public class Mnemonic
    {
        public bool IsValidChecksum { get; set; }
        public WordList WordList { get; set; }
        public int[] Indices { get; set; }
        public string[] Words { get; set; }
    }
}
