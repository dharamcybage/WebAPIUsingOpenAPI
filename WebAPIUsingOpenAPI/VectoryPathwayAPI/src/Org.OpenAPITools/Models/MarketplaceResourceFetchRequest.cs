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
    public partial class MarketplaceResourceFetchRequest : IEquatable<MarketplaceResourceFetchRequest>
    {
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [Required]
        [DataMember(Name="page", EmitDefaultValue=true)]
        public long Page { get; set; }

        /// <summary>
        /// Gets or Sets AppearsInMarketplace
        /// </summary>
        [DataMember(Name="appearsInMarketplace", EmitDefaultValue=true)]
        public bool? AppearsInMarketplace { get; set; }

        /// <summary>
        /// Gets or Sets Per
        /// </summary>
        [Required]
        [DataMember(Name="per", EmitDefaultValue=true)]
        public long Per { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public long? Type { get; set; }

        /// <summary>
        /// Gets or Sets SearchQuery
        /// </summary>
        [DataMember(Name="searchQuery", EmitDefaultValue=true)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [DataMember(Name="district", EmitDefaultValue=true)]
        public long? District { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceResourceFetchRequest {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  AppearsInMarketplace: ").Append(AppearsInMarketplace).Append("\n");
            sb.Append("  Per: ").Append(Per).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SearchQuery: ").Append(SearchQuery).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MarketplaceResourceFetchRequest)obj);
        }

        /// <summary>
        /// Returns true if MarketplaceResourceFetchRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MarketplaceResourceFetchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketplaceResourceFetchRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Page == other.Page ||
                    
                    Page.Equals(other.Page)
                ) && 
                (
                    AppearsInMarketplace == other.AppearsInMarketplace ||
                    AppearsInMarketplace != null &&
                    AppearsInMarketplace.Equals(other.AppearsInMarketplace)
                ) && 
                (
                    Per == other.Per ||
                    
                    Per.Equals(other.Per)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    SearchQuery == other.SearchQuery ||
                    SearchQuery != null &&
                    SearchQuery.Equals(other.SearchQuery)
                ) && 
                (
                    District == other.District ||
                    District != null &&
                    District.Equals(other.District)
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
                    
                    hashCode = hashCode * 59 + Page.GetHashCode();
                    if (AppearsInMarketplace != null)
                    hashCode = hashCode * 59 + AppearsInMarketplace.GetHashCode();
                    
                    hashCode = hashCode * 59 + Per.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (SearchQuery != null)
                    hashCode = hashCode * 59 + SearchQuery.GetHashCode();
                    if (District != null)
                    hashCode = hashCode * 59 + District.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MarketplaceResourceFetchRequest left, MarketplaceResourceFetchRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MarketplaceResourceFetchRequest left, MarketplaceResourceFetchRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
