using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace worken_api.Controllers
{
    public class CreateTransactionRequest
    {
        [Required(ErrorMessage = $"{nameof(FromAccountPublicKey)} must be provided")]
        public string FromAccountPublicKey { get; set; }

        [Required(ErrorMessage = $"{nameof(FromAccountPrivateKey)} must be provided")]
        public string FromAccountPrivateKey { get; set; }

        [Required(ErrorMessage = $"{nameof(AssociatedAccountPublicKey)} must be provided")]
        public string AssociatedAccountPublicKey { get; set; }

        [Required(ErrorMessage = $"{nameof(LamPorts)} must be provided")]
        public ulong LamPorts {  get; set; }

        public string Memo { get; set; } = string.Empty;

        public ulong SolAmount { get; set; } = 0;

    }
}