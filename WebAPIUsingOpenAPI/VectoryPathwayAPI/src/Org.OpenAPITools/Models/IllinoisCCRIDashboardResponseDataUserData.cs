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
    public partial class IllinoisCCRIDashboardResponseDataUserData : IEquatable<IllinoisCCRIDashboardResponseDataUserData>
    {
        /// <summary>
        /// Gets or Sets CompletedItems
        /// </summary>
        [Required]
        [DataMember(Name="completedItems", EmitDefaultValue=false)]
        public List<string> CompletedItems { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [Required]
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserBadgeProgressData User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IllinoisCCRIDashboardResponseDataUserData {\n");
            sb.Append("  CompletedItems: ").Append(CompletedItems).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IllinoisCCRIDashboardResponseDataUserData)obj);
        }

        /// <summary>
        /// Returns true if IllinoisCCRIDashboardResponseDataUserData instances are equal
        /// </summary>
        /// <param name="other">Instance of IllinoisCCRIDashboardResponseDataUserData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IllinoisCCRIDashboardResponseDataUserData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CompletedItems == other.CompletedItems ||
                    CompletedItems != null &&
                    other.CompletedItems != null &&
                    CompletedItems.SequenceEqual(other.CompletedItems)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
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
                    if (CompletedItems != null)
                    hashCode = hashCode * 59 + CompletedItems.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IllinoisCCRIDashboardResponseDataUserData left, IllinoisCCRIDashboardResponseDataUserData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IllinoisCCRIDashboardResponseDataUserData left, IllinoisCCRIDashboardResponseDataUserData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
