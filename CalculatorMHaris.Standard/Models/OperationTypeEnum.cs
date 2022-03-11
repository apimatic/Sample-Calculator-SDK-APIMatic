// <copyright file="OperationTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace CalculatorMHaris.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using CalculatorMHaris.Standard;
    using CalculatorMHaris.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// OperationTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OperationTypeEnum
    {
        /// <summary>
        /// ADD.
        /// </summary>
        [EnumMember(Value = "SUM")]
        ADD,

        /// <summary>
        /// SUBTRACT.
        /// </summary>
        [EnumMember(Value = "SUBTRACT")]
        SUBTRACT,
    }
}