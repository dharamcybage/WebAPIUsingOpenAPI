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
    /// 
    /// </summary>
    [DataContract]
    public partial class StudentProfileResponseUserTestingData : IEquatable<StudentProfileResponseUserTestingData>
    {
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [Required]
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<StudentProfileResponseUserTestingDataResult> Results { get; set; }

        /// <summary>
        /// Gets or Sets TestName
        /// </summary>
        [Required]
        [DataMember(Name="testName", EmitDefaultValue=false)]
        public string TestName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentProfileResponseUserTestingData {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  TestName: ").Append(TestName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((StudentProfileResponseUserTestingData)obj);
        }

        /// <summary>
        /// Returns true if StudentProfileResponseUserTestingData instances are equal
        /// </summary>
        /// <param name="other">Instance of StudentProfileResponseUserTestingData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentProfileResponseUserTestingData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Results == other.Results ||
                    Results != null &&
                    other.Results != null &&
                    Results.SequenceEqual(other.Results)
                ) && 
                (
                    TestName == other.TestName ||
                    TestName != null &&
                    TestName.Equals(other.TestName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Results != null)
                    hashCode = hashCode * 59 + Results.GetHashCode();
                    if (TestName != null)
                    hashCode = hashCode * 59 + TestName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StudentProfileResponseUserTestingData left, StudentProfileResponseUserTestingData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StudentProfileResponseUserTestingData left, StudentProfileResponseUserTestingData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
