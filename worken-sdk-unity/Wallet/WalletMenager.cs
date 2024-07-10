
using worken_sdk_unity.Communication;
using worken_sdk_unity.Wallet.model;
using worken_sdk_unity.Wallet.model.walletObject;

namespace worken_sdk_unity.Wallet
{
    public static class WalletManager
    {
        public static async Task<WalletData> CreateWallet()
        {
            const string Endpoint = "/api/Wallet/CreateWallet";

            var walletResponse = await HttpService.Send<WalletCreationResponse, WalletData>(Endpoint);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<WalletData> CreateWallet(WordCountType wordCount)
        {
            const string Endpoint = "/api/Wallet/CreateWalletWordCount";

            var walletResponse = await HttpService.Send<WalletCreationResponse, WalletData>(Endpoint);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<WalletData> CreateWallet(WordListType wordList)
        {
            const string Endpoint = "/api/Wallet/CreateWalletWordList";

            var walletResponse = await HttpService.Send<WalletCreationResponse, WalletData>(Endpoint);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<WalletData> CreateWallet(WordListType wordList, WordCountType wordCount)
        {
            const string Endpoint = "/api/Wallet/CreateWalletFull";

            var walletResponse = await HttpService.Send<WalletCreationResponse, WalletData>(Endpoint);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }
    }
}
