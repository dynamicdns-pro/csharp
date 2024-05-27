# dynamicdns.api - the C# library for the Dynamicdns.pro

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.1
- SDK version: 1.0.0
- Generator version: 7.6.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using dynamicdns.api.Api;
using dynamicdns.api.Client;
using dynamicdns.api.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out dynamicdns.api.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using dynamicdns.api.Api;
using dynamicdns.api.Client;
using dynamicdns.api.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://dynamicdns.pro/api";
            // Configure Bearer token for authorization: http
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SubdomainApi(config);
            var subdomain = "subdomain_example";  // string | 
            var updateRequest = new UpdateRequest?(); // UpdateRequest? |  (optional) 

            try
            {
                Update200Response result = apiInstance.Update(subdomain, updateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SubdomainApi.Update: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dynamicdns.pro/api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*SubdomainApi* | [**Update**](docs/SubdomainApi.md#update) | **POST** /update/{subdomain}/record | 
*SubdomainApi* | [**Updateip**](docs/SubdomainApi.md#updateip) | **POST** /update/{subdomain} | update the ip address with the connecting ip address


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.Update200Response](docs/Update200Response.md)
 - [Model.Update200ResponseAnyOf](docs/Update200ResponseAnyOf.md)
 - [Model.Update400Response](docs/Update400Response.md)
 - [Model.Update403Response](docs/Update403Response.md)
 - [Model.UpdateRequest](docs/UpdateRequest.md)
 - [Model.Updateip200Response](docs/Updateip200Response.md)
 - [Model.Updateip200ResponseAnyOf](docs/Updateip200ResponseAnyOf.md)
 - [Model.Updateip400Response](docs/Updateip400Response.md)
 - [Model.Updateip403Response](docs/Updateip403Response.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="http"></a>
### http

- **Type**: Bearer Authentication

