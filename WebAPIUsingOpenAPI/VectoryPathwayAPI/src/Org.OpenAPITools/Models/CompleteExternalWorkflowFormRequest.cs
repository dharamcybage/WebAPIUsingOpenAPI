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
    public partial class CompleteExternalWorkflowFormRequest : IEquatable<CompleteExternalWorkflowFormRequest>
    {
        /// <summary>
        /// Gets or Sets FormRequest
        /// </summary>
        [Required]
        [DataMember(Name="formRequest", EmitDefaultValue=false)]
        public CompleteFormRequest FormRequest { get; set; }

        /// <summary>
        /// Gets or Sets SignatureData
        /// </summary>
        [Required]
        [DataMember(Name="signatureData", EmitDefaultValue=false)]
        public string SignatureData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteExternalWorkflowFormRequest {\n");
            sb.Append("  FormRequest: ").Append(FormRequest).Append("\n");
            sb.Append("  SignatureData: ").Append(SignatureData).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CompleteExternalWorkflowFormRequest)obj);
        }

        /// <summary>
        /// Returns true if CompleteExternalWorkflowFormRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CompleteExternalWorkflowFormRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteExternalWorkflowFormRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    FormRequest == other.FormRequest ||
                    FormRequest != null &&
                    FormRequest.Equals(other.FormRequest)
                ) && 
                (
                    SignatureData == other.SignatureData ||
                    SignatureData != null &&
                    SignatureData.Equals(other.SignatureData)
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
                    if (FormRequest != null)
                    hashCode = hashCode * 59 + FormRequest.GetHashCode();
                    if (SignatureData != null)
                    hashCode = hashCode * 59 + SignatureData.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CompleteExternalWorkflowFormRequest left, CompleteExternalWorkflowFormRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CompleteExternalWorkflowFormRequest left, CompleteExternalWorkflowFormRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
