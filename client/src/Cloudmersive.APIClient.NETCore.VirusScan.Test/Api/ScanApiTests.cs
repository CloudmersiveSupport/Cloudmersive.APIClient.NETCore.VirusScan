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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.VirusScan.Client;
using Cloudmersive.APIClient.NETCore.VirusScan.Api;
using Cloudmersive.APIClient.NETCore.VirusScan.Model;

namespace Cloudmersive.APIClient.NETCore.VirusScan.Test
{
    /// <summary>
    ///  Class for testing ScanApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ScanApiTests
    {
        private ScanApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScanApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScanApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ScanApi
            //Assert.IsInstanceOfType(typeof(ScanApi), instance, "instance is a ScanApi");
        }

        
        /// <summary>
        /// Test ScanFile
        /// </summary>
        [Test]
        public void ScanFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.ScanFile(inputFile);
            //Assert.IsInstanceOf<VirusScanResult> (response, "response is VirusScanResult");
        }
        
        /// <summary>
        /// Test ScanWebsite
        /// </summary>
        [Test]
        public void ScanWebsiteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //WebsiteScanRequest input = null;
            //var response = instance.ScanWebsite(input);
            //Assert.IsInstanceOf<WebsiteScanResult> (response, "response is WebsiteScanResult");
        }
        
    }

}
