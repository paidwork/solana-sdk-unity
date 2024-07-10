using System.Net;

namespace worken_sdk_unity
{
    public interface IResponse<ResponseData>
    {
        HttpStatusCode status { get; set; }

        string? message { get; set; }

        ResponseData? data { get; set; }
    }
}
