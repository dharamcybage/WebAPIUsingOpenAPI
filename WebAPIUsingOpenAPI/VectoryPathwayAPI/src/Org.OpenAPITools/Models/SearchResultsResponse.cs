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
    public partial class SearchResultsResponse : IEquatable<SearchResultsResponse>
    {
        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [Required]
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<SearchResultsResponseSearchResult> Users { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [Required]
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<SearchResultsResponseSearchResult> Contacts { get; set; }

        /// <summary>
        /// Gets or Sets Experiences
        /// </summary>
        [Required]
        [DataMember(Name="experiences", EmitDefaultValue=false)]
        public List<SearchResultsResponseSearchResult> Experiences { get; set; }

        /// <summary>
        /// Gets or Sets Organizations
        /// </summary>
        [Required]
        [DataMember(Name="organizations", EmitDefaultValue=false)]
        public List<SearchResultsResponseSearchResult> Organizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResultsResponse {\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Experiences: ").Append(Experiences).Append("\n");
            sb.Append("  Organizations: ").Append(Organizations).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SearchResultsResponse)obj);
        }

        /// <summary>
        /// Returns true if SearchResultsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchResultsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchResultsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Users == other.Users ||
                    Users != null &&
                    other.Users != null &&
                    Users.SequenceEqual(other.Users)
                ) && 
                (
                    Contacts == other.Contacts ||
                    Contacts != null &&
                    other.Contacts != null &&
                    Contacts.SequenceEqual(other.Contacts)
                ) && 
                (
                    Experiences == other.Experiences ||
                    Experiences != null &&
                    other.Experiences != null &&
                    Experiences.SequenceEqual(other.Experiences)
                ) && 
                (
                    Organizations == other.Organizations ||
                    Organizations != null &&
                    other.Organizations != null &&
                    Organizations.SequenceEqual(other.Organizations)
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
                    if (Users != null)
                    hashCode = hashCode * 59 + Users.GetHashCode();
                    if (Contacts != null)
                    hashCode = hashCode * 59 + Contacts.GetHashCode();
                    if (Experiences != null)
                    hashCode = hashCode * 59 + Experiences.GetHashCode();
                    if (Organizations != null)
                    hashCode = hashCode * 59 + Organizations.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SearchResultsResponse left, SearchResultsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SearchResultsResponse left, SearchResultsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
