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
    public partial class AssessmentControllerOccupationSearchResponse : IEquatable<AssessmentControllerOccupationSearchResponse>
    {
        /// <summary>
        /// Gets or Sets OnetId
        /// </summary>
        [Required]
        [DataMember(Name="onetId", EmitDefaultValue=false)]
        public string OnetId { get; set; }

        /// <summary>
        /// Gets or Sets FamilyCode
        /// </summary>
        [DataMember(Name="familyCode", EmitDefaultValue=true)]
        public string FamilyCode { get; set; }

        /// <summary>
        /// Gets or Sets CareerClusterId
        /// </summary>
        [DataMember(Name="careerClusterId", EmitDefaultValue=true)]
        public string CareerClusterId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [Required]
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessmentControllerOccupationSearchResponse {\n");
            sb.Append("  OnetId: ").Append(OnetId).Append("\n");
            sb.Append("  FamilyCode: ").Append(FamilyCode).Append("\n");
            sb.Append("  CareerClusterId: ").Append(CareerClusterId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AssessmentControllerOccupationSearchResponse)obj);
        }

        /// <summary>
        /// Returns true if AssessmentControllerOccupationSearchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AssessmentControllerOccupationSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssessmentControllerOccupationSearchResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OnetId == other.OnetId ||
                    OnetId != null &&
                    OnetId.Equals(other.OnetId)
                ) && 
                (
                    FamilyCode == other.FamilyCode ||
                    FamilyCode != null &&
                    FamilyCode.Equals(other.FamilyCode)
                ) && 
                (
                    CareerClusterId == other.CareerClusterId ||
                    CareerClusterId != null &&
                    CareerClusterId.Equals(other.CareerClusterId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
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
                    if (OnetId != null)
                    hashCode = hashCode * 59 + OnetId.GetHashCode();
                    if (FamilyCode != null)
                    hashCode = hashCode * 59 + FamilyCode.GetHashCode();
                    if (CareerClusterId != null)
                    hashCode = hashCode * 59 + CareerClusterId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AssessmentControllerOccupationSearchResponse left, AssessmentControllerOccupationSearchResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AssessmentControllerOccupationSearchResponse left, AssessmentControllerOccupationSearchResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
