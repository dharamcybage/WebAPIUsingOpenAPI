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
    public partial class ExperienceSearchRequest : IEquatable<ExperienceSearchRequest>
    {
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=true)]
        public List<ExperienceSearchRequestField> Fields { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organization_id", EmitDefaultValue=true)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ClusterIds
        /// </summary>
        [DataMember(Name="cluster_ids", EmitDefaultValue=true)]
        public List<long> ClusterIds { get; set; }

        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=true)]
        public bool? MatchMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExperienceSearchRequest {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ClusterIds: ").Append(ClusterIds).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExperienceSearchRequest)obj);
        }

        /// <summary>
        /// Returns true if ExperienceSearchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ExperienceSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExperienceSearchRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fields == other.Fields ||
                    Fields != null &&
                    other.Fields != null &&
                    Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    OrganizationId == other.OrganizationId ||
                    OrganizationId != null &&
                    OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    ClusterIds == other.ClusterIds ||
                    ClusterIds != null &&
                    other.ClusterIds != null &&
                    ClusterIds.SequenceEqual(other.ClusterIds)
                ) && 
                (
                    MatchMode == other.MatchMode ||
                    MatchMode != null &&
                    MatchMode.Equals(other.MatchMode)
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
                    if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (OrganizationId != null)
                    hashCode = hashCode * 59 + OrganizationId.GetHashCode();
                    if (ClusterIds != null)
                    hashCode = hashCode * 59 + ClusterIds.GetHashCode();
                    if (MatchMode != null)
                    hashCode = hashCode * 59 + MatchMode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExperienceSearchRequest left, ExperienceSearchRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExperienceSearchRequest left, ExperienceSearchRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
