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
    public partial class CreateReportRequestFilter : IEquatable<CreateReportRequestFilter>
    {
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [Required]
        [DataMember(Name="entity", EmitDefaultValue=true)]
        public long Entity { get; set; }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=true)]
        public long? Field { get; set; }

        /// <summary>
        /// Gets or Sets IsPartOfMultiDimensionalChart
        /// </summary>
        [Required]
        [DataMember(Name="isPartOfMultiDimensionalChart", EmitDefaultValue=true)]
        public bool IsPartOfMultiDimensionalChart { get; set; }

        /// <summary>
        /// Gets or Sets CustomFieldId
        /// </summary>
        [DataMember(Name="custom_field_id", EmitDefaultValue=true)]
        public long? CustomFieldId { get; set; }

        /// <summary>
        /// Gets or Sets Comparison
        /// </summary>
        [Required]
        [DataMember(Name="comparison", EmitDefaultValue=true)]
        public long Comparison { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [Required]
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReportRequestFilter {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  IsPartOfMultiDimensionalChart: ").Append(IsPartOfMultiDimensionalChart).Append("\n");
            sb.Append("  CustomFieldId: ").Append(CustomFieldId).Append("\n");
            sb.Append("  Comparison: ").Append(Comparison).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CreateReportRequestFilter)obj);
        }

        /// <summary>
        /// Returns true if CreateReportRequestFilter instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateReportRequestFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateReportRequestFilter other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Entity == other.Entity ||
                    
                    Entity.Equals(other.Entity)
                ) && 
                (
                    Field == other.Field ||
                    Field != null &&
                    Field.Equals(other.Field)
                ) && 
                (
                    IsPartOfMultiDimensionalChart == other.IsPartOfMultiDimensionalChart ||
                    
                    IsPartOfMultiDimensionalChart.Equals(other.IsPartOfMultiDimensionalChart)
                ) && 
                (
                    CustomFieldId == other.CustomFieldId ||
                    CustomFieldId != null &&
                    CustomFieldId.Equals(other.CustomFieldId)
                ) && 
                (
                    Comparison == other.Comparison ||
                    
                    Comparison.Equals(other.Comparison)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
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
                    
                    hashCode = hashCode * 59 + Entity.GetHashCode();
                    if (Field != null)
                    hashCode = hashCode * 59 + Field.GetHashCode();
                    
                    hashCode = hashCode * 59 + IsPartOfMultiDimensionalChart.GetHashCode();
                    if (CustomFieldId != null)
                    hashCode = hashCode * 59 + CustomFieldId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Comparison.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CreateReportRequestFilter left, CreateReportRequestFilter right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CreateReportRequestFilter left, CreateReportRequestFilter right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
