// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace CalculatorMHaris.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CalculatorMHaris.Standard;
    using CalculatorMHaris.Standard.Http.Client;
    using CalculatorMHaris.Standard.Models;
    using CalculatorMHaris.Tests.Helpers;
    using NUnit.Framework;

    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallBack HttpCallBackHandler { get; private set; }

        /// <summary>
        /// Gets CalculatorMHarisClient Client.
        /// </summary>
        protected CalculatorMHarisClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            this.HttpCallBackHandler = new HttpCallBack();
            this.Client = CalculatorMHarisClient.CreateFromEnvironment().ToBuilder()
                .HttpCallBack(this.HttpCallBackHandler)
                .Build();
        }
    }
}