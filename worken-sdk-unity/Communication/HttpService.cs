using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace worken_sdk_unity.Communication
{
    internal class HttpService
    {
        private const string ApiUrl = "";

        public HttpService() { }

        public static async Task<TResponse> SendWithBody<TRequest, TResponse, TEndpointData>(string endpoint, TRequest body) 
            where TResponse : IResponse<TEndpointData>, new()
        {
            if (string.IsNullOrEmpty(endpoint))
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            // Construct the full URL
            string fullUrl = ApiUrl + endpoint;

            // Create the JSON string from the body object
            string jsonBody = JsonConvert.SerializeObject(body);

            // Create an HttpClient instance
            using (var client = new HttpClient())
            {
                // Set Http content type for this request
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Send the POST request asynchronously and get the response
                HttpResponseMessage response = await client.PostAsync(fullUrl, new StringContent(jsonBody, Encoding.UTF8, "application/json"));

                // Check for successful response
                if(!response.IsSuccessStatusCode)
                    return new TResponse() { status = response.StatusCode, message = response.ReasonPhrase };

                // Read the response content as a string
                string responseJson = await response.Content.ReadAsStringAsync();

                // Deserialize the response JSON into the specified type
                TEndpointData responseObject = JsonConvert.DeserializeObject<TEndpointData>(responseJson);

                return new TResponse() { status = response.StatusCode, data = responseObject };
            }
        }

        public static async Task<TResponse> Send<TResponse, TEndpointData>(string endpoint)
            where TResponse : IResponse<TEndpointData>, new()
        {
            if (string.IsNullOrEmpty(endpoint))
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
          
            // Construct the full URL
            string fullUrl = ApiUrl + endpoint;

            // Create an HttpClient instance
            using (var client = new HttpClient())
            {
                // Set Http content type for this request
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Send the POST request asynchronously and get the response
                HttpResponseMessage response = await client.PostAsync(fullUrl, null);

                // Check for successful response
                if (!response.IsSuccessStatusCode)
                    return new TResponse() { status = response.StatusCode, message = response.ReasonPhrase };

                // Read the response content as a string
                string responseJson = await response.Content.ReadAsStringAsync();

                // Deserialize the response JSON into the specified type
                TEndpointData responseObject = JsonConvert.DeserializeObject<TEndpointData>(responseJson);

                return new TResponse() { status = response.StatusCode, data = responseObject };
            }
        }
    }
}
