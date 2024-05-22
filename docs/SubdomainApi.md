# dynamicdns.api.Api.SubdomainApi

All URIs are relative to *http://dynamicdns.pro/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Updateip**](SubdomainApi.md#updateip) | **POST** /update/{subdomain} | update the ip address with the connecting ip address |

<a id="updateip"></a>
# **Updateip**
> Updateip200Response Updateip (string subdomain, Object? body = null)

update the ip address with the connecting ip address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dynamicdns.api.Api;
using dynamicdns.api.Client;
using dynamicdns.api.Model;

namespace Example
{
    public class UpdateipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://dynamicdns.pro/api";
            // Configure Bearer token for authorization: http
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubdomainApi(config);
            var subdomain = "subdomain_example";  // string | 
            var body = null;  // Object? |  (optional) 

            try
            {
                // update the ip address with the connecting ip address
                Updateip200Response result = apiInstance.Updateip(subdomain, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubdomainApi.Updateip: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update the ip address with the connecting ip address
    ApiResponse<Updateip200Response> response = apiInstance.UpdateipWithHttpInfo(subdomain, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubdomainApi.UpdateipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subdomain** | **string** |  |  |
| **body** | **Object?** |  | [optional]  |

### Return type

[**Updateip200Response**](Updateip200Response.md)

### Authorization

[http](../README.md#http)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **403** | An error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

