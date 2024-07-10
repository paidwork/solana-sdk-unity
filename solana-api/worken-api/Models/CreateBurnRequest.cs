using System.ComponentModel.DataAnnotations;

namespace worken_api.Models
{
    public class CreateBurnRequest
    {
        [Required(ErrorMessage = $"{nameof(FromAccountPublicKey)} must be provided")]
        public string FromAccountPublicKey { get; set; }

        [Required(ErrorMessage = $"{nameof(FromAccountPrivateKey)} must be provided")]
        public string FromAccountPrivateKey { get; set; }

        [Required(ErrorMessage = $"{nameof(FromAccountPrivateKey)} must be provided")]
        public ulong Amount { get; set; }

        public string Memo { get; set; } = string.Empty;
    }
}