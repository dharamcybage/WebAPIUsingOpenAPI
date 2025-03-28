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
    public partial class LoginResponse : IEquatable<LoginResponse>
    {
        /// <summary>
        /// Gets or Sets SchoolId
        /// </summary>
        [DataMember(Name="school_id", EmitDefaultValue=true)]
        public long? SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [Required]
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets DistrictId
        /// </summary>
        [Required]
        [DataMember(Name="district_id", EmitDefaultValue=true)]
        public long DistrictId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoginResponse {\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  DistrictId: ").Append(DistrictId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LoginResponse)obj);
        }

        /// <summary>
        /// Returns true if LoginResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of LoginResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoginResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    SchoolId == other.SchoolId ||
                    SchoolId != null &&
                    SchoolId.Equals(other.SchoolId)
                ) && 
                (
                    Token == other.Token ||
                    Token != null &&
                    Token.Equals(other.Token)
                ) && 
                (
                    DistrictId == other.DistrictId ||
                    
                    DistrictId.Equals(other.DistrictId)
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
                    if (SchoolId != null)
                    hashCode = hashCode * 59 + SchoolId.GetHashCode();
                    if (Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();
                    
                    hashCode = hashCode * 59 + DistrictId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LoginResponse left, LoginResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LoginResponse left, LoginResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
