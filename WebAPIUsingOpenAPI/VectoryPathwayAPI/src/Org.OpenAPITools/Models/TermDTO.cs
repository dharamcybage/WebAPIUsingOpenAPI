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
    public partial class TermDTO : IEquatable<TermDTO>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets IsCurrent
        /// </summary>
        [Required]
        [DataMember(Name="isCurrent", EmitDefaultValue=true)]
        public bool IsCurrent { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearId
        /// </summary>
        [Required]
        [DataMember(Name="school_year_id", EmitDefaultValue=true)]
        public long SchoolYearId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DistrictId
        /// </summary>
        [Required]
        [DataMember(Name="district_id", EmitDefaultValue=true)]
        public long DistrictId { get; set; }

        /// <summary>
        /// Gets or Sets UploadId
        /// </summary>
        [Required]
        [DataMember(Name="uploadId", EmitDefaultValue=false)]
        public string UploadId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TermDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  SchoolYearId: ").Append(SchoolYearId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DistrictId: ").Append(DistrictId).Append("\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TermDTO)obj);
        }

        /// <summary>
        /// Returns true if TermDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of TermDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TermDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    IsCurrent == other.IsCurrent ||
                    
                    IsCurrent.Equals(other.IsCurrent)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    SchoolYearId == other.SchoolYearId ||
                    
                    SchoolYearId.Equals(other.SchoolYearId)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    DistrictId == other.DistrictId ||
                    
                    DistrictId.Equals(other.DistrictId)
                ) && 
                (
                    UploadId == other.UploadId ||
                    UploadId != null &&
                    UploadId.Equals(other.UploadId)
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
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsCurrent.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    
                    hashCode = hashCode * 59 + SchoolYearId.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    
                    hashCode = hashCode * 59 + DistrictId.GetHashCode();
                    if (UploadId != null)
                    hashCode = hashCode * 59 + UploadId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TermDTO left, TermDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TermDTO left, TermDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
