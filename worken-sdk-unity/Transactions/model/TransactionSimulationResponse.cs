using Solnet.Rpc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace worken_sdk_unity.Transactions.model
{
    internal class TransactionSimulationResponse
    : IResponse<SimulationLogs>
    {
        public HttpStatusCode status { get; set; }

        public string? message { get; set; }

        public SimulationLogs? data { get; set; }
    }
}
