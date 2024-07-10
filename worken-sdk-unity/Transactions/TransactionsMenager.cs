
using worken_sdk_unity.Communication;
using worken_sdk_unity.Transactions.model;
using Solnet.Rpc.Models;
using worken_api.Controllers;
using worken_api.Models;

namespace worken_sdk_unity.Transactions
{
    public static class TransactionsManager
    {
        public static async Task<string> CreateTransaction(CreateTransactionRequest request)
        {
            const string Endpoint = "/api/Transactions/CreateTransactionToAssociatedAccount";

            var walletResponse = await HttpService.SendWithBody<CreateTransactionRequest, TransactionCreationResponse, string>(Endpoint, request);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<SimulationLogs> SimulateTransaction(CreateTransactionRequest request)
        {
            const string Endpoint = "/api/Transactions/SimulateTransactionToAssociatedAccount";

            var walletResponse = await HttpService.SendWithBody<CreateTransactionRequest, TransactionSimulationResponse, SimulationLogs>(Endpoint, request);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<string> CreateTransactionWithBurn(CreateTransactionBurnRequest request)
        {
            const string Endpoint = "/api/Transactions/CreateTransactionWithBurnToAssociatedAccount";

            var walletResponse = await HttpService.SendWithBody<CreateTransactionBurnRequest, TransactionCreationResponse, string>(Endpoint, request);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<SimulationLogs> SimulateTransactionWithBurn(CreateTransactionBurnRequest request)
        {
            const string Endpoint = "/api/Transactions/SimulateTransactionWithBurnToAssociatedAccount";

            var walletResponse = await HttpService.SendWithBody<CreateTransactionBurnRequest, TransactionSimulationResponse, SimulationLogs>(Endpoint,request);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<string> Burn(CreateBurnRequest request)
        {
            const string Endpoint = "/api/Transactions/Burn";

            var walletResponse = await HttpService.SendWithBody<CreateBurnRequest, TransactionCreationResponse, string>(Endpoint, request);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }

        public static async Task<SimulationLogs> SimulateBurn(CreateBurnRequest request)
        {
            const string Endpoint = "/api/Transactions/SimulateBurn";

            var walletResponse = await HttpService.SendWithBody<CreateBurnRequest, TransactionSimulationResponse, SimulationLogs>(Endpoint, request);

            if (walletResponse.status != System.Net.HttpStatusCode.OK)
                throw new Exception(walletResponse.message);

            return walletResponse.data;
        }
    }
}
