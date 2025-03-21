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
    public partial class SuperUserInformationResponseDistrict : IEquatable<SuperUserInformationResponseDistrict>
    {
        /// <summary>
        /// Gets or Sets ArrowsLink
        /// </summary>
        [Required]
        [DataMember(Name="arrowsLink", EmitDefaultValue=false)]
        public string ArrowsLink { get; set; }

        /// <summary>
        /// Gets or Sets GoogleDomain
        /// </summary>
        [DataMember(Name="googleDomain", EmitDefaultValue=true)]
        public string GoogleDomain { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets OneRosterConfig
        /// </summary>
        [DataMember(Name="oneRosterConfig", EmitDefaultValue=false)]
        public Object OneRosterConfig { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SamlMetadata
        /// </summary>
        [DataMember(Name="samlMetadata", EmitDefaultValue=true)]
        public string SamlMetadata { get; set; }

        /// <summary>
        /// Gets or Sets CleverDistrictId
        /// </summary>
        [DataMember(Name="cleverDistrictId", EmitDefaultValue=true)]
        public string CleverDistrictId { get; set; }

        /// <summary>
        /// Gets or Sets MicrosoftDomain
        /// </summary>
        [DataMember(Name="microsoftDomain", EmitDefaultValue=true)]
        public string MicrosoftDomain { get; set; }

        /// <summary>
        /// Gets or Sets UploadLogs
        /// </summary>
        [Required]
        [DataMember(Name="uploadLogs", EmitDefaultValue=false)]
        public List<Object> UploadLogs { get; set; }

        /// <summary>
        /// Gets or Sets ClasslinkTenantId
        /// </summary>
        [DataMember(Name="classlinkTenantId", EmitDefaultValue=true)]
        public string ClasslinkTenantId { get; set; }

        /// <summary>
        /// Gets or Sets Schools
        /// </summary>
        [Required]
        [DataMember(Name="schools", EmitDefaultValue=false)]
        public List<SuperUserInformationResponseSchool> Schools { get; set; }

        /// <summary>
        /// Gets or Sets ApiKeys
        /// </summary>
        [Required]
        [DataMember(Name="apiKeys", EmitDefaultValue=false)]
        public List<DistrictAPIKeyDTO> ApiKeys { get; set; }

        /// <summary>
        /// Gets or Sets SftpPassword
        /// </summary>
        [Required]
        [DataMember(Name="sftpPassword", EmitDefaultValue=false)]
        public string SftpPassword { get; set; }

        /// <summary>
        /// Gets or Sets NcesID
        /// </summary>
        [Required]
        [DataMember(Name="ncesID", EmitDefaultValue=false)]
        public string NcesID { get; set; }

        /// <summary>
        /// Gets or Sets AuthenticationMethod
        /// </summary>
        [Required]
        [DataMember(Name="authenticationMethod", EmitDefaultValue=true)]
        public long AuthenticationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperUserInformationResponseDistrict {\n");
            sb.Append("  ArrowsLink: ").Append(ArrowsLink).Append("\n");
            sb.Append("  GoogleDomain: ").Append(GoogleDomain).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OneRosterConfig: ").Append(OneRosterConfig).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SamlMetadata: ").Append(SamlMetadata).Append("\n");
            sb.Append("  CleverDistrictId: ").Append(CleverDistrictId).Append("\n");
            sb.Append("  MicrosoftDomain: ").Append(MicrosoftDomain).Append("\n");
            sb.Append("  UploadLogs: ").Append(UploadLogs).Append("\n");
            sb.Append("  ClasslinkTenantId: ").Append(ClasslinkTenantId).Append("\n");
            sb.Append("  Schools: ").Append(Schools).Append("\n");
            sb.Append("  ApiKeys: ").Append(ApiKeys).Append("\n");
            sb.Append("  SftpPassword: ").Append(SftpPassword).Append("\n");
            sb.Append("  NcesID: ").Append(NcesID).Append("\n");
            sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SuperUserInformationResponseDistrict)obj);
        }

        /// <summary>
        /// Returns true if SuperUserInformationResponseDistrict instances are equal
        /// </summary>
        /// <param name="other">Instance of SuperUserInformationResponseDistrict to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperUserInformationResponseDistrict other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ArrowsLink == other.ArrowsLink ||
                    ArrowsLink != null &&
                    ArrowsLink.Equals(other.ArrowsLink)
                ) && 
                (
                    GoogleDomain == other.GoogleDomain ||
                    GoogleDomain != null &&
                    GoogleDomain.Equals(other.GoogleDomain)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    OneRosterConfig == other.OneRosterConfig ||
                    OneRosterConfig != null &&
                    OneRosterConfig.Equals(other.OneRosterConfig)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    SamlMetadata == other.SamlMetadata ||
                    SamlMetadata != null &&
                    SamlMetadata.Equals(other.SamlMetadata)
                ) && 
                (
                    CleverDistrictId == other.CleverDistrictId ||
                    CleverDistrictId != null &&
                    CleverDistrictId.Equals(other.CleverDistrictId)
                ) && 
                (
                    MicrosoftDomain == other.MicrosoftDomain ||
                    MicrosoftDomain != null &&
                    MicrosoftDomain.Equals(other.MicrosoftDomain)
                ) && 
                (
                    UploadLogs == other.UploadLogs ||
                    UploadLogs != null &&
                    other.UploadLogs != null &&
                    UploadLogs.SequenceEqual(other.UploadLogs)
                ) && 
                (
                    ClasslinkTenantId == other.ClasslinkTenantId ||
                    ClasslinkTenantId != null &&
                    ClasslinkTenantId.Equals(other.ClasslinkTenantId)
                ) && 
                (
                    Schools == other.Schools ||
                    Schools != null &&
                    other.Schools != null &&
                    Schools.SequenceEqual(other.Schools)
                ) && 
                (
                    ApiKeys == other.ApiKeys ||
                    ApiKeys != null &&
                    other.ApiKeys != null &&
                    ApiKeys.SequenceEqual(other.ApiKeys)
                ) && 
                (
                    SftpPassword == other.SftpPassword ||
                    SftpPassword != null &&
                    SftpPassword.Equals(other.SftpPassword)
                ) && 
                (
                    NcesID == other.NcesID ||
                    NcesID != null &&
                    NcesID.Equals(other.NcesID)
                ) && 
                (
                    AuthenticationMethod == other.AuthenticationMethod ||
                    
                    AuthenticationMethod.Equals(other.AuthenticationMethod)
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
                    if (ArrowsLink != null)
                    hashCode = hashCode * 59 + ArrowsLink.GetHashCode();
                    if (GoogleDomain != null)
                    hashCode = hashCode * 59 + GoogleDomain.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (OneRosterConfig != null)
                    hashCode = hashCode * 59 + OneRosterConfig.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (SamlMetadata != null)
                    hashCode = hashCode * 59 + SamlMetadata.GetHashCode();
                    if (CleverDistrictId != null)
                    hashCode = hashCode * 59 + CleverDistrictId.GetHashCode();
                    if (MicrosoftDomain != null)
                    hashCode = hashCode * 59 + MicrosoftDomain.GetHashCode();
                    if (UploadLogs != null)
                    hashCode = hashCode * 59 + UploadLogs.GetHashCode();
                    if (ClasslinkTenantId != null)
                    hashCode = hashCode * 59 + ClasslinkTenantId.GetHashCode();
                    if (Schools != null)
                    hashCode = hashCode * 59 + Schools.GetHashCode();
                    if (ApiKeys != null)
                    hashCode = hashCode * 59 + ApiKeys.GetHashCode();
                    if (SftpPassword != null)
                    hashCode = hashCode * 59 + SftpPassword.GetHashCode();
                    if (NcesID != null)
                    hashCode = hashCode * 59 + NcesID.GetHashCode();
                    
                    hashCode = hashCode * 59 + AuthenticationMethod.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SuperUserInformationResponseDistrict left, SuperUserInformationResponseDistrict right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SuperUserInformationResponseDistrict left, SuperUserInformationResponseDistrict right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
