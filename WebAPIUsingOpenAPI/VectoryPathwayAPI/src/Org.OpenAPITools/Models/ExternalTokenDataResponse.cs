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
    public partial class ExternalTokenDataResponse : IEquatable<ExternalTokenDataResponse>
    {
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public FormResponse Fields { get; set; }

        /// <summary>
        /// Gets or Sets LinkData
        /// </summary>
        [Required]
        [DataMember(Name="linkData", EmitDefaultValue=false)]
        public ExternalSubmissionLinkTokenDTO LinkData { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=true)]
        public List<ContactDTO> Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalTokenDataResponse {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  LinkData: ").Append(LinkData).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExternalTokenDataResponse)obj);
        }

        /// <summary>
        /// Returns true if ExternalTokenDataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ExternalTokenDataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalTokenDataResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fields == other.Fields ||
                    Fields != null &&
                    Fields.Equals(other.Fields)
                ) && 
                (
                    LinkData == other.LinkData ||
                    LinkData != null &&
                    LinkData.Equals(other.LinkData)
                ) && 
                (
                    Contacts == other.Contacts ||
                    Contacts != null &&
                    other.Contacts != null &&
                    Contacts.SequenceEqual(other.Contacts)
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
                    if (LinkData != null)
                    hashCode = hashCode * 59 + LinkData.GetHashCode();
                    if (Contacts != null)
                    hashCode = hashCode * 59 + Contacts.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExternalTokenDataResponse left, ExternalTokenDataResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExternalTokenDataResponse left, ExternalTokenDataResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
