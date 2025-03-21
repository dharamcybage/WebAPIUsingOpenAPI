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
    public partial class ReportMetadataResponse : IEquatable<ReportMetadataResponse>
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets UpdatesNext
        /// </summary>
        [Required]
        [DataMember(Name="updatesNext", EmitDefaultValue=false)]
        public DateTime UpdatesNext { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [Required]
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<ReportFilterDTO> Segments { get; set; }

        /// <summary>
        /// Gets or Sets GroupByCustomField
        /// </summary>
        [DataMember(Name="groupByCustomField", EmitDefaultValue=true)]
        public long? GroupByCustomField { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Required]
        [DataMember(Name="type", EmitDefaultValue=true)]
        public long Type { get; set; }

        /// <summary>
        /// Gets or Sets ReadyToShowGraph
        /// </summary>
        [Required]
        [DataMember(Name="readyToShowGraph", EmitDefaultValue=true)]
        public bool ReadyToShowGraph { get; set; }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [Required]
        [DataMember(Name="columns", EmitDefaultValue=false)]
        public List<ReportColumnDefinition> Columns { get; set; }

        /// <summary>
        /// Gets or Sets CustomFieldItems
        /// </summary>
        [Required]
        [DataMember(Name="customFieldItems", EmitDefaultValue=false)]
        public List<ReportMetadataResponseCustomFieldItem> CustomFieldItems { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [Required]
        [DataMember(Name="entity", EmitDefaultValue=true)]
        public long Entity { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [Required]
        [DataMember(Name="created_by", EmitDefaultValue=true)]
        public long CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets GroupByField
        /// </summary>
        [DataMember(Name="groupByField", EmitDefaultValue=true)]
        public long? GroupByField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportMetadataResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UpdatesNext: ").Append(UpdatesNext).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  GroupByCustomField: ").Append(GroupByCustomField).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ReadyToShowGraph: ").Append(ReadyToShowGraph).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  CustomFieldItems: ").Append(CustomFieldItems).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  GroupByField: ").Append(GroupByField).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ReportMetadataResponse)obj);
        }

        /// <summary>
        /// Returns true if ReportMetadataResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportMetadataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportMetadataResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    UpdatesNext == other.UpdatesNext ||
                    UpdatesNext != null &&
                    UpdatesNext.Equals(other.UpdatesNext)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Segments == other.Segments ||
                    Segments != null &&
                    other.Segments != null &&
                    Segments.SequenceEqual(other.Segments)
                ) && 
                (
                    GroupByCustomField == other.GroupByCustomField ||
                    GroupByCustomField != null &&
                    GroupByCustomField.Equals(other.GroupByCustomField)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    ReadyToShowGraph == other.ReadyToShowGraph ||
                    
                    ReadyToShowGraph.Equals(other.ReadyToShowGraph)
                ) && 
                (
                    Columns == other.Columns ||
                    Columns != null &&
                    other.Columns != null &&
                    Columns.SequenceEqual(other.Columns)
                ) && 
                (
                    CustomFieldItems == other.CustomFieldItems ||
                    CustomFieldItems != null &&
                    other.CustomFieldItems != null &&
                    CustomFieldItems.SequenceEqual(other.CustomFieldItems)
                ) && 
                (
                    Entity == other.Entity ||
                    
                    Entity.Equals(other.Entity)
                ) && 
                (
                    CreatedBy == other.CreatedBy ||
                    
                    CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    GroupByField == other.GroupByField ||
                    GroupByField != null &&
                    GroupByField.Equals(other.GroupByField)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (UpdatesNext != null)
                    hashCode = hashCode * 59 + UpdatesNext.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Segments != null)
                    hashCode = hashCode * 59 + Segments.GetHashCode();
                    if (GroupByCustomField != null)
                    hashCode = hashCode * 59 + GroupByCustomField.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    
                    hashCode = hashCode * 59 + ReadyToShowGraph.GetHashCode();
                    if (Columns != null)
                    hashCode = hashCode * 59 + Columns.GetHashCode();
                    if (CustomFieldItems != null)
                    hashCode = hashCode * 59 + CustomFieldItems.GetHashCode();
                    
                    hashCode = hashCode * 59 + Entity.GetHashCode();
                    
                    hashCode = hashCode * 59 + CreatedBy.GetHashCode();
                    if (GroupByField != null)
                    hashCode = hashCode * 59 + GroupByField.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ReportMetadataResponse left, ReportMetadataResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReportMetadataResponse left, ReportMetadataResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
