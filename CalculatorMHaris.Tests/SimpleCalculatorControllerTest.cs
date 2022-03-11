// <copyright file="SimpleCalculatorControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace CalculatorMHaris.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using CalculatorMHaris.Standard;
    using CalculatorMHaris.Standard.Controllers;
    using CalculatorMHaris.Standard.Exceptions;
    using CalculatorMHaris.Standard.Http.Client;
    using CalculatorMHaris.Standard.Http.Response;
    using CalculatorMHaris.Standard.Utilities;
    using CalculatorMHaris.Tests.Helpers;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// SimpleCalculatorControllerTest.
    /// </summary>
    [TestFixture]
    public class SimpleCalculatorControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SimpleCalculatorController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SimpleCalculatorController;
        }

        /// <summary>
        /// Check if Endpoint returns the correct sum..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSUM()
        {
            // Parameters for the API call
            double x = 2;
            double y = 4;
            Standard.Models.OperationTypeEnum operation = ApiHelper.JsonDeserialize<Standard.Models.OperationTypeEnum>("\"SUM\"");

            // Perform API call
            double result = 0;
            try
            {
                result = await this.controller.CalculateAsync(x, y, operation);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual("6", TestHelper.ConvertStreamToString(this.HttpCallBackHandler.Response.RawBody), "Response body should match exactly (string literal match)");
        }
    }
}