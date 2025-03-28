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
    public partial class SuperUserUpdateSchoolRequest : IEquatable<SuperUserUpdateSchoolRequest>
    {
        /// <summary>
        /// Gets or Sets OneRosterId
        /// </summary>
        [DataMember(Name="oneRosterId", EmitDefaultValue=true)]
        public string OneRosterId { get; set; }

        /// <summary>
        /// Gets or Sets InternalCode
        /// </summary>
        [Required]
        [DataMember(Name="internalCode", EmitDefaultValue=false)]
        public string InternalCode { get; set; }

        /// <summary>
        /// Gets or Sets SsoId
        /// </summary>
        [DataMember(Name="ssoId", EmitDefaultValue=true)]
        public string SsoId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperUserUpdateSchoolRequest {\n");
            sb.Append("  OneRosterId: ").Append(OneRosterId).Append("\n");
            sb.Append("  InternalCode: ").Append(InternalCode).Append("\n");
            sb.Append("  SsoId: ").Append(SsoId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SuperUserUpdateSchoolRequest)obj);
        }

        /// <summary>
        /// Returns true if SuperUserUpdateSchoolRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SuperUserUpdateSchoolRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperUserUpdateSchoolRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OneRosterId == other.OneRosterId ||
                    OneRosterId != null &&
                    OneRosterId.Equals(other.OneRosterId)
                ) && 
                (
                    InternalCode == other.InternalCode ||
                    InternalCode != null &&
                    InternalCode.Equals(other.InternalCode)
                ) && 
                (
                    SsoId == other.SsoId ||
                    SsoId != null &&
                    SsoId.Equals(other.SsoId)
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
                    if (OneRosterId != null)
                    hashCode = hashCode * 59 + OneRosterId.GetHashCode();
                    if (InternalCode != null)
                    hashCode = hashCode * 59 + InternalCode.GetHashCode();
                    if (SsoId != null)
                    hashCode = hashCode * 59 + SsoId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SuperUserUpdateSchoolRequest left, SuperUserUpdateSchoolRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SuperUserUpdateSchoolRequest left, SuperUserUpdateSchoolRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
