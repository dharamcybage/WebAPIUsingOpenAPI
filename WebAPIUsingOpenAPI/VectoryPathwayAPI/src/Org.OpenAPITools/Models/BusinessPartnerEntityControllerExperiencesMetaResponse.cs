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
    public partial class BusinessPartnerEntityControllerExperiencesMetaResponse : IEquatable<BusinessPartnerEntityControllerExperiencesMetaResponse>
    {
        /// <summary>
        /// Gets or Sets DashboardText
        /// </summary>
        [DataMember(Name="dashboardText", EmitDefaultValue=true)]
        public string DashboardText { get; set; }

        /// <summary>
        /// Gets or Sets Forms
        /// </summary>
        [Required]
        [DataMember(Name="forms", EmitDefaultValue=false)]
        public List<BusinessPartnerEntityControllerExperiencesMetaResponseForm> Forms { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [Required]
        [DataMember(Name="organizationId", EmitDefaultValue=true)]
        public long OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets RedirectsToExternal
        /// </summary>
        [Required]
        [DataMember(Name="redirectsToExternal", EmitDefaultValue=true)]
        public bool RedirectsToExternal { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLink
        /// </summary>
        [DataMember(Name="externalLink", EmitDefaultValue=true)]
        public string ExternalLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessPartnerEntityControllerExperiencesMetaResponse {\n");
            sb.Append("  DashboardText: ").Append(DashboardText).Append("\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  RedirectsToExternal: ").Append(RedirectsToExternal).Append("\n");
            sb.Append("  ExternalLink: ").Append(ExternalLink).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BusinessPartnerEntityControllerExperiencesMetaResponse)obj);
        }

        /// <summary>
        /// Returns true if BusinessPartnerEntityControllerExperiencesMetaResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BusinessPartnerEntityControllerExperiencesMetaResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessPartnerEntityControllerExperiencesMetaResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DashboardText == other.DashboardText ||
                    DashboardText != null &&
                    DashboardText.Equals(other.DashboardText)
                ) && 
                (
                    Forms == other.Forms ||
                    Forms != null &&
                    other.Forms != null &&
                    Forms.SequenceEqual(other.Forms)
                ) && 
                (
                    OrganizationId == other.OrganizationId ||
                    
                    OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    RedirectsToExternal == other.RedirectsToExternal ||
                    
                    RedirectsToExternal.Equals(other.RedirectsToExternal)
                ) && 
                (
                    ExternalLink == other.ExternalLink ||
                    ExternalLink != null &&
                    ExternalLink.Equals(other.ExternalLink)
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
                    if (DashboardText != null)
                    hashCode = hashCode * 59 + DashboardText.GetHashCode();
                    if (Forms != null)
                    hashCode = hashCode * 59 + Forms.GetHashCode();
                    
                    hashCode = hashCode * 59 + OrganizationId.GetHashCode();
                    
                    hashCode = hashCode * 59 + RedirectsToExternal.GetHashCode();
                    if (ExternalLink != null)
                    hashCode = hashCode * 59 + ExternalLink.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BusinessPartnerEntityControllerExperiencesMetaResponse left, BusinessPartnerEntityControllerExperiencesMetaResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BusinessPartnerEntityControllerExperiencesMetaResponse left, BusinessPartnerEntityControllerExperiencesMetaResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
