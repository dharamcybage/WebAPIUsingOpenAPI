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
    public partial class StudentProposalResponseData : IEquatable<StudentProposalResponseData>
    {
        /// <summary>
        /// Gets or Sets Experience
        /// </summary>
        [Required]
        [DataMember(Name="experience", EmitDefaultValue=false)]
        public ExternalExperienceViewableDataResponse Experience { get; set; }

        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [Required]
        [DataMember(Name="org", EmitDefaultValue=false)]
        public OrganizationExternalInputDTO Org { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [Required]
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ViewableContactExternalInput Contact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentProposalResponseData {\n");
            sb.Append("  Experience: ").Append(Experience).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return obj.GetType() == GetType() && Equals((StudentProposalResponseData)obj);
        }

        /// <summary>
        /// Returns true if StudentProposalResponseData instances are equal
        /// </summary>
        /// <param name="other">Instance of StudentProposalResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentProposalResponseData other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Experience == other.Experience ||
                    Experience != null &&
                    Experience.Equals(other.Experience)
                ) && 
                (
                    Org == other.Org ||
                    Org != null &&
                    Org.Equals(other.Org)
                ) && 
                (
                    Contact == other.Contact ||
                    Contact != null &&
                    Contact.Equals(other.Contact)
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
                    if (Experience != null)
                    hashCode = hashCode * 59 + Experience.GetHashCode();
                    if (Org != null)
                    hashCode = hashCode * 59 + Org.GetHashCode();
                    if (Contact != null)
                    hashCode = hashCode * 59 + Contact.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(StudentProposalResponseData left, StudentProposalResponseData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StudentProposalResponseData left, StudentProposalResponseData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
