/*
 * Pathwayos API
 *
 * Pathwayos API description
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
        /// <summary>
        /// Gets or Sets InfiniteCampusPluginContextNationalTestCode
        /// </summary>
        [TypeConverter(typeof(CustomEnumConverter<InfiniteCampusPluginContextNationalTestCode>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum InfiniteCampusPluginContextNationalTestCode
        {
            
            /// <summary>
            /// Enum SATEnum for SAT
            /// </summary>
            [EnumMember(Value = "SAT")]
            SATEnum = 1,
            
            /// <summary>
            /// Enum PSATEnum for PSAT
            /// </summary>
            [EnumMember(Value = "PSAT")]
            PSATEnum = 2,
            
            /// <summary>
            /// Enum ACTEnum for ACT
            /// </summary>
            [EnumMember(Value = "ACT")]
            ACTEnum = 3,
            
            /// <summary>
            /// Enum PSAT10Enum for PSAT 10
            /// </summary>
            [EnumMember(Value = "PSAT 10")]
            PSAT10Enum = 4,
            
            /// <summary>
            /// Enum PSAT89Enum for PSAT 8/9
            /// </summary>
            [EnumMember(Value = "PSAT 8/9")]
            PSAT89Enum = 5,
            
            /// <summary>
            /// Enum PSATNMSQTEnum for PSAT/NMSQT
            /// </summary>
            [EnumMember(Value = "PSAT/NMSQT")]
            PSATNMSQTEnum = 6
        }
}
