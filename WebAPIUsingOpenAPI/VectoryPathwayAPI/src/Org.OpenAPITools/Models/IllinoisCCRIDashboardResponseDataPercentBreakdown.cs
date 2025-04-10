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
    public partial class IllinoisCCRIDashboardResponseDataPercentBreakdown : IEquatable<IllinoisCCRIDashboardResponseDataPercentBreakdown>
    {
        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [Required]
        [DataMember(Name="percent", EmitDefaultValue=true)]
        public double Percent { get; set; }

        /// <summary>
        /// Gets or Sets HaveNotUsers
        /// </summary>
        [Required]
        [DataMember(Name="haveNotUsers", EmitDefaultValue=false)]
        public List<UserBadgeProgressData> HaveNotUsers { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [Required]
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<UserBadgeProgressData> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IllinoisCCRIDashboardResponseDataPercentBreakdown {\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  HaveNotUsers: ").Append(HaveNotUsers).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IllinoisCCRIDashboardResponseDataPercentBreakdown)obj);
        }

        /// <summary>
        /// Returns true if IllinoisCCRIDashboardResponseDataPercentBreakdown instances are equal
        /// </summary>
        /// <param name="other">Instance of IllinoisCCRIDashboardResponseDataPercentBreakdown to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IllinoisCCRIDashboardResponseDataPercentBreakdown other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Percent == other.Percent ||
                    
                    Percent.Equals(other.Percent)
                ) && 
                (
                    HaveNotUsers == other.HaveNotUsers ||
                    HaveNotUsers != null &&
                    other.HaveNotUsers != null &&
                    HaveNotUsers.SequenceEqual(other.HaveNotUsers)
                ) && 
                (
                    Users == other.Users ||
                    Users != null &&
                    other.Users != null &&
                    Users.SequenceEqual(other.Users)
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
                    
                    hashCode = hashCode * 59 + Percent.GetHashCode();
                    if (HaveNotUsers != null)
                    hashCode = hashCode * 59 + HaveNotUsers.GetHashCode();
                    if (Users != null)
                    hashCode = hashCode * 59 + Users.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IllinoisCCRIDashboardResponseDataPercentBreakdown left, IllinoisCCRIDashboardResponseDataPercentBreakdown right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IllinoisCCRIDashboardResponseDataPercentBreakdown left, IllinoisCCRIDashboardResponseDataPercentBreakdown right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
