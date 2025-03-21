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
    public partial class ParchmentListResponse : IEquatable<ParchmentListResponse>
    {
        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [Required]
        [DataMember(Name="request", EmitDefaultValue=false)]
        public ParchmentRequestDTO Request { get; set; }

        /// <summary>
        /// Gets or Sets Receivers
        /// </summary>
        [Required]
        [DataMember(Name="receivers", EmitDefaultValue=false)]
        public List<ParchmentReceiverDTO> Receivers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParchmentListResponse {\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  Receivers: ").Append(Receivers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ParchmentListResponse)obj);
        }

        /// <summary>
        /// Returns true if ParchmentListResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ParchmentListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParchmentListResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Request == other.Request ||
                    Request != null &&
                    Request.Equals(other.Request)
                ) && 
                (
                    Receivers == other.Receivers ||
                    Receivers != null &&
                    other.Receivers != null &&
                    Receivers.SequenceEqual(other.Receivers)
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
                    if (Request != null)
                    hashCode = hashCode * 59 + Request.GetHashCode();
                    if (Receivers != null)
                    hashCode = hashCode * 59 + Receivers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ParchmentListResponse left, ParchmentListResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ParchmentListResponse left, ParchmentListResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
