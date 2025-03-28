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
    public partial class FormFieldDTO : IEquatable<FormFieldDTO>
    {
        /// <summary>
        /// Gets or Sets CsvAllowed
        /// </summary>
        [Required]
        [DataMember(Name="csvAllowed", EmitDefaultValue=true)]
        public bool CsvAllowed { get; set; }

        /// <summary>
        /// Gets or Sets HiddenFromStudents
        /// </summary>
        [Required]
        [DataMember(Name="hiddenFromStudents", EmitDefaultValue=true)]
        public bool HiddenFromStudents { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [Required]
        [DataMember(Name="required", EmitDefaultValue=true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets WordLimit
        /// </summary>
        [DataMember(Name="wordLimit", EmitDefaultValue=true)]
        public long? WordLimit { get; set; }

        /// <summary>
        /// Gets or Sets FormId
        /// </summary>
        [Required]
        [DataMember(Name="form_id", EmitDefaultValue=true)]
        public long FormId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name="type", EmitDefaultValue=true)]
        public long Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ConditionalDisplayValue
        /// </summary>
        [DataMember(Name="conditionalDisplayValue", EmitDefaultValue=true)]
        public long? ConditionalDisplayValue { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets MaxMultiSelect
        /// </summary>
        [DataMember(Name="maxMultiSelect", EmitDefaultValue=true)]
        public long? MaxMultiSelect { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deletedAt", EmitDefaultValue=true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets CharacterLimit
        /// </summary>
        [DataMember(Name="characterLimit", EmitDefaultValue=true)]
        public long? CharacterLimit { get; set; }

        /// <summary>
        /// Gets or Sets AllowsOtherField
        /// </summary>
        [Required]
        [DataMember(Name="allowsOtherField", EmitDefaultValue=true)]
        public bool AllowsOtherField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormFieldDTO {\n");
            sb.Append("  CsvAllowed: ").Append(CsvAllowed).Append("\n");
            sb.Append("  HiddenFromStudents: ").Append(HiddenFromStudents).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  WordLimit: ").Append(WordLimit).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConditionalDisplayValue: ").Append(ConditionalDisplayValue).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  MaxMultiSelect: ").Append(MaxMultiSelect).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  CharacterLimit: ").Append(CharacterLimit).Append("\n");
            sb.Append("  AllowsOtherField: ").Append(AllowsOtherField).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FormFieldDTO)obj);
        }

        /// <summary>
        /// Returns true if FormFieldDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of FormFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormFieldDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CsvAllowed == other.CsvAllowed ||
                    
                    CsvAllowed.Equals(other.CsvAllowed)
                ) && 
                (
                    HiddenFromStudents == other.HiddenFromStudents ||
                    
                    HiddenFromStudents.Equals(other.HiddenFromStudents)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Required == other.Required ||
                    
                    Required.Equals(other.Required)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    WordLimit == other.WordLimit ||
                    WordLimit != null &&
                    WordLimit.Equals(other.WordLimit)
                ) && 
                (
                    FormId == other.FormId ||
                    
                    FormId.Equals(other.FormId)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    ConditionalDisplayValue == other.ConditionalDisplayValue ||
                    ConditionalDisplayValue != null &&
                    ConditionalDisplayValue.Equals(other.ConditionalDisplayValue)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    MaxMultiSelect == other.MaxMultiSelect ||
                    MaxMultiSelect != null &&
                    MaxMultiSelect.Equals(other.MaxMultiSelect)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    DeletedAt == other.DeletedAt ||
                    DeletedAt != null &&
                    DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    CharacterLimit == other.CharacterLimit ||
                    CharacterLimit != null &&
                    CharacterLimit.Equals(other.CharacterLimit)
                ) && 
                (
                    AllowsOtherField == other.AllowsOtherField ||
                    
                    AllowsOtherField.Equals(other.AllowsOtherField)
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
                    
                    hashCode = hashCode * 59 + CsvAllowed.GetHashCode();
                    
                    hashCode = hashCode * 59 + HiddenFromStudents.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    
                    hashCode = hashCode * 59 + Required.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (WordLimit != null)
                    hashCode = hashCode * 59 + WordLimit.GetHashCode();
                    
                    hashCode = hashCode * 59 + FormId.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (ConditionalDisplayValue != null)
                    hashCode = hashCode * 59 + ConditionalDisplayValue.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    if (MaxMultiSelect != null)
                    hashCode = hashCode * 59 + MaxMultiSelect.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (DeletedAt != null)
                    hashCode = hashCode * 59 + DeletedAt.GetHashCode();
                    if (CharacterLimit != null)
                    hashCode = hashCode * 59 + CharacterLimit.GetHashCode();
                    
                    hashCode = hashCode * 59 + AllowsOtherField.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FormFieldDTO left, FormFieldDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FormFieldDTO left, FormFieldDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
