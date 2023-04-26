/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Api;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

// uncomment below to import models
//using AlipaySDKNet.OpenAPI.Model;
//using AlipaySDKNet.OpenAPI.Util;
//using AlipaySDKNet.OpenAPI.Util.Model;
//using Newtonsoft.Json;

namespace AlipaySDKNet.OpenAPI.Test.Api
{
    /// <summary>
    ///  Class for testing AlipayOpenFileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AlipayOpenFileApiTests : IDisposable
    {
        // private AlipayOpenFileApi instance;

        public AlipayOpenFileApiTests()
        {
            // instance = new AlipayOpenFileApi();
            AlipayConfig alipayConfig = new AlipayConfig();
            // alipayConfig.ServerUrl = "http://ptsv2.com";
            // alipayConfig.AppId = "2021003126691367";
            // alipayConfig.PrivateKey = "";
            // alipayConfig.AlipayPublicKey = "";
            // // alipayConfig.EncryptKey = "";
            alipayConfig.AppId = "2021003126677278";
            alipayConfig.PrivateKey = "MIIEowIBAAKCAQEArz0i/o5bWlbUdHvZ5uHN2CrPa/tuh21+kOWS/ayjBTz+ZS7KVsbNsIC0vz7qqsEq/ep+Qwy76k6sEBkAj/FxgXsSmnJqc6MxDSo2HsbFYjXhnGYnDtvlXiZV3pmyJPmkNKZ6SI/UQPGKKY/leeK7AO2aFVN6PP4Is7Mocm/D2wZBmxa+Ifz5HjjTg+hfUNWZLYvZt1dZqerysBppLXIlQ9Lzg+JAd7he2jcPugJnZxWv8/SvuW+VKAUY6inQT/A1lMpqpxXZ/887CT5P5ov1w1H5reQgYfqDAvXJaLNuW/jkzYylYn9rcJLPkvFYqTnPxTf2SX2We5X4sztaAIfNtwIDAQABAoIBAAWr29sTLl+xGbUfYQD449mQISBkhcI6R/NWirhNAwWjYLRTnFbMnlGNCMx7s8qM7+BB24499kLyAt2OgZcnAD5phkObWlidunOrnw7F7hNsnP2bzL3NXhH6+aJ3pO1PawINNT3t8becWZVYw9t6/ARerDLufbFFo3B1ZuS1O0h2UKl3BYP4UJOgSRzOnCoz/iGSUF8MLjI9Qffj9HUUoaTEL0Hhv1Tc92U8LMfN2EYR1okoM7BMQLBJJxasRZs4S0eGMj4Reyi+U2xxaiD1j13ZTyHJWOAyVP7o7B/T7rYM1TJQRUUlPie+IeHJ37EjbQbkcIILvnDpp2IGnrPbaCkCgYEA1XkRj2OyTwrOXHfmlN/LVK7ww0+lB3141k8JWEwD8NVij0syIi/KuQt7Y3Fv14GhgPD/K+4dfG14b5/S+sqRlEA1xdiVTFHDa4ImBCgTY3faIA6KlKVgLVAJNBrtplhFSqZ6kRVT+68BqoiLokP3JNioH8iwt0mw9KmwxgatACsCgYEA0iYpg9YW8JILYv/4gB1Bv4nG6GAljtV9Eb1o5Fa87tyJQJuJ87i+qj/CEW5Gg1qjTatdNnzA5hdinQARCXt8BStdg1doJSDkUoNAijhpzpgmgIk0Sn6KBHCrw66QutxJ11QnvAVpzQ6ofBLBQ5xIzaWJB89YGSvZJtY+kjqJFqUCgYEAzuPTXQDmoyx566xY0RhEXAJgXSonaybzoeBf0i958kMcjnv2TqO6+bRjFXGvT1HXULxA0jaoZRtDigt/0ofYp7HDa8gIijsEBoHQjl64y8IwqLjvHjlZCRF0mgcvI/SQ01SdnVbqWha2qqxDiDQOpqtD5en/OuQ0mCqNpJ57tJkCgYByLSfLKEuIY2DqZfaG7N5nCZ1Xbb2aMCXmuIk/3lyCTrIHtzopgAufhkqTm92Vym4FagCX9Qn9OWFrubiH9V55lIkXLis4WPmUVxl+v43FIGdy2JjfjIbCSNEZ3UNnMv6vjlqUTkCgl8E0wB/e8w+fI7wi0SWlb2xpLGgMnN8UvQKBgHz+S0xccDPbV+2sQMjDIGQgKtdPDheBIjOSVVrrS5dtt33Nfs0jcM2CnK7TSiEF0oCgk/JC9RE4RE5T22R6QREL+LNNp1brMTDTuHAH5sCRcM79o5n19GIymLjB7S3pEj1LIRT2fzTK0mONRvNlJuQ2PqYc7oekEfIoGl6N2AhO";
            alipayConfig.AlipayPublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAlr+2Mir816Ye8ybsC8QgIigrG2oqVTwYeCjiJQPGP0x7iRVVwQuuM54rO+OyyfJcvI5UWFtfcpy+si+3JyaInKP69DA0AS4XkVPV/81xcIHMZP/CJAYOtLFLhhyEwp1CMoN45BtJes5lG65UXz/7QzVjcF+6AC+qVKx66HKSsT9b5HyWRxfDkOYixy1gZt39w+sgxaAPVt6pf7UZHX+ENE/gYpTCHHflVPzPfl8TIXTZmEMGqjBLY8GFXVJkvATX3h12VX3AwUlIndY4gJND9l1isFV9BfpmZYyv864z14UH6Kq9u8WVWdF5bsJevo4oU0Q0UB8EmyOdlxBPTDiOzwIDAQAB";
            // alipayConfig.EncryptKey = "wEA0iV4eLSTV+o5/T9RKjg==";
            AlipayConfigUtil alipayConfigUtil = new AlipayConfigUtil(alipayConfig);
            // instance.Client.SetAlipayConfigUtil(alipayConfigUtil);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AlipayOpenFileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AlipayOpenFileApi
            //Assert.IsType<AlipayOpenFileApi>(instance);
        }

        /// <summary>
        /// Test Upload
        /// </summary>
        [Fact]
        public void UploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            // string returnUrl = "111";
            // string notifyUrl = "222";
            // AlipayOpenFileUploadModel data = new AlipayOpenFileUploadModel();
            // data.BizCode = "content_creation";
            // System.IO.Stream fileContent =
            //     new FileStream(
            //         "AlipaySDKNet.OpenAPI.Test/Cert/pic.jpg",
            //         FileMode.Open, FileAccess.Read);
            // var response = instance.Upload(returnUrl, notifyUrl, data, fileContent);
            // Assert.IsType<AlipayOpenFileUploadResponseModel>(response);
        }
    }
}
