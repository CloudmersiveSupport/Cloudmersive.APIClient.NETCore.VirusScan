/* 
 * virusapi
 *
 * Virus API lets you scan files and content for viruses and identify security issues with content.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Cloudmersive.APIClient.NETCore.VirusScan.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScanApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Scan a file for viruses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>VirusScanResult</returns>
        VirusScanResult ScanFile (System.IO.Stream inputFile);

        /// <summary>
        /// Scan a file for viruses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of VirusScanResult</returns>
        ApiResponse<VirusScanResult> ScanFileWithHttpInfo (System.IO.Stream inputFile);
        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>WebsiteScanResult</returns>
        WebsiteScanResult ScanWebsite (WebsiteScanRequest input);

        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>ApiResponse of WebsiteScanResult</returns>
        ApiResponse<WebsiteScanResult> ScanWebsiteWithHttpInfo (WebsiteScanRequest input);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Scan a file for viruses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of VirusScanResult</returns>
        System.Threading.Tasks.Task<VirusScanResult> ScanFileAsync (System.IO.Stream inputFile);

        /// <summary>
        /// Scan a file for viruses
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (VirusScanResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<VirusScanResult>> ScanFileAsyncWithHttpInfo (System.IO.Stream inputFile);
        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>Task of WebsiteScanResult</returns>
        System.Threading.Tasks.Task<WebsiteScanResult> ScanWebsiteAsync (WebsiteScanRequest input);

        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>Task of ApiResponse (WebsiteScanResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<WebsiteScanResult>> ScanWebsiteAsyncWithHttpInfo (WebsiteScanRequest input);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScanApi : IScanApi
    {
        private Cloudmersive.APIClient.NETCore.VirusScan.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScanApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.VirusScan.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScanApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.VirusScan.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NETCore.VirusScan.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Scan a file for viruses 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>VirusScanResult</returns>
        public VirusScanResult ScanFile (System.IO.Stream inputFile)
        {
             ApiResponse<VirusScanResult> localVarResponse = ScanFileWithHttpInfo(inputFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scan a file for viruses 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of VirusScanResult</returns>
        public ApiResponse< VirusScanResult > ScanFileWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling ScanApi->ScanFile");

            var localVarPath = "/virus/scan/file";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScanFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VirusScanResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VirusScanResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VirusScanResult)));
        }

        /// <summary>
        /// Scan a file for viruses 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of VirusScanResult</returns>
        public async System.Threading.Tasks.Task<VirusScanResult> ScanFileAsync (System.IO.Stream inputFile)
        {
             ApiResponse<VirusScanResult> localVarResponse = await ScanFileAsyncWithHttpInfo(inputFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scan a file for viruses 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (VirusScanResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VirusScanResult>> ScanFileAsyncWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling ScanApi->ScanFile");

            var localVarPath = "/virus/scan/file";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScanFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VirusScanResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VirusScanResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VirusScanResult)));
        }

        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing) 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>WebsiteScanResult</returns>
        public WebsiteScanResult ScanWebsite (WebsiteScanRequest input)
        {
             ApiResponse<WebsiteScanResult> localVarResponse = ScanWebsiteWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing) 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>ApiResponse of WebsiteScanResult</returns>
        public ApiResponse< WebsiteScanResult > ScanWebsiteWithHttpInfo (WebsiteScanRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ScanApi->ScanWebsite");

            var localVarPath = "/virus/scan/website";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScanWebsite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WebsiteScanResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebsiteScanResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebsiteScanResult)));
        }

        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing) 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>Task of WebsiteScanResult</returns>
        public async System.Threading.Tasks.Task<WebsiteScanResult> ScanWebsiteAsync (WebsiteScanRequest input)
        {
             ApiResponse<WebsiteScanResult> localVarResponse = await ScanWebsiteAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scan a website for malicious content including viruses and threats (including Phishing) 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.VirusScan.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input"></param>
        /// <returns>Task of ApiResponse (WebsiteScanResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WebsiteScanResult>> ScanWebsiteAsyncWithHttpInfo (WebsiteScanRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ScanApi->ScanWebsite");

            var localVarPath = "/virus/scan/website";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ScanWebsite", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WebsiteScanResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WebsiteScanResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(WebsiteScanResult)));
        }

    }
}
