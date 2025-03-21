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
    public partial class TagReportConsumerResponse : IEquatable<TagReportConsumerResponse>
    {
        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [Required]
        [DataMember(Name="tag", EmitDefaultValue=false)]
        public Object Tag { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfLogs
        /// </summary>
        [Required]
        [DataMember(Name="numberOfLogs", EmitDefaultValue=true)]
        public long NumberOfLogs { get; set; }

        /// <summary>
        /// Gets or Sets TotalHours
        /// </summary>
        [Required]
        [DataMember(Name="totalHours", EmitDefaultValue=true)]
        public double TotalHours { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [Required]
        [DataMember(Name="logs", EmitDefaultValue=false)]
        public List<LogReport> Logs { get; set; }

        /// <summary>
        /// Gets or Sets PercentContribution
        /// </summary>
        [Required]
        [DataMember(Name="percentContribution", EmitDefaultValue=true)]
        public double PercentContribution { get; set; }

        /// <summary>
        /// Gets or Sets AveragePerLog
        /// </summary>
        [Required]
        [DataMember(Name="averagePerLog", EmitDefaultValue=true)]
        public double AveragePerLog { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagReportConsumerResponse {\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  NumberOfLogs: ").Append(NumberOfLogs).Append("\n");
            sb.Append("  TotalHours: ").Append(TotalHours).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  PercentContribution: ").Append(PercentContribution).Append("\n");
            sb.Append("  AveragePerLog: ").Append(AveragePerLog).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TagReportConsumerResponse)obj);
        }

        /// <summary>
        /// Returns true if TagReportConsumerResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TagReportConsumerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TagReportConsumerResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Tag == other.Tag ||
                    Tag != null &&
                    Tag.Equals(other.Tag)
                ) && 
                (
                    NumberOfLogs == other.NumberOfLogs ||
                    
                    NumberOfLogs.Equals(other.NumberOfLogs)
                ) && 
                (
                    TotalHours == other.TotalHours ||
                    
                    TotalHours.Equals(other.TotalHours)
                ) && 
                (
                    Logs == other.Logs ||
                    Logs != null &&
                    other.Logs != null &&
                    Logs.SequenceEqual(other.Logs)
                ) && 
                (
                    PercentContribution == other.PercentContribution ||
                    
                    PercentContribution.Equals(other.PercentContribution)
                ) && 
                (
                    AveragePerLog == other.AveragePerLog ||
                    
                    AveragePerLog.Equals(other.AveragePerLog)
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
                    if (Tag != null)
                    hashCode = hashCode * 59 + Tag.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfLogs.GetHashCode();
                    
                    hashCode = hashCode * 59 + TotalHours.GetHashCode();
                    if (Logs != null)
                    hashCode = hashCode * 59 + Logs.GetHashCode();
                    
                    hashCode = hashCode * 59 + PercentContribution.GetHashCode();
                    
                    hashCode = hashCode * 59 + AveragePerLog.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TagReportConsumerResponse left, TagReportConsumerResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TagReportConsumerResponse left, TagReportConsumerResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
