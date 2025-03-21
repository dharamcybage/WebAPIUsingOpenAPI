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
    public partial class PathwayOSAdminDashboardMetricsResponse : IEquatable<PathwayOSAdminDashboardMetricsResponse>
    {
        /// <summary>
        /// Gets or Sets NumberOfParticipatingStudents
        /// </summary>
        [Required]
        [DataMember(Name="numberOfParticipatingStudents", EmitDefaultValue=true)]
        public long NumberOfParticipatingStudents { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfActivitiesOffered
        /// </summary>
        [Required]
        [DataMember(Name="numberOfActivitiesOffered", EmitDefaultValue=true)]
        public long NumberOfActivitiesOffered { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfExperiencesOffered
        /// </summary>
        [Required]
        [DataMember(Name="numberOfExperiencesOffered", EmitDefaultValue=true)]
        public long NumberOfExperiencesOffered { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPartnerContacts
        /// </summary>
        [Required]
        [DataMember(Name="numberOfPartnerContacts", EmitDefaultValue=true)]
        public long NumberOfPartnerContacts { get; set; }

        /// <summary>
        /// Gets or Sets AverageHoursPerTimeLog
        /// </summary>
        [Required]
        [DataMember(Name="averageHoursPerTimeLog", EmitDefaultValue=true)]
        public double AverageHoursPerTimeLog { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfPartnerOrganizations
        /// </summary>
        [Required]
        [DataMember(Name="numberOfPartnerOrganizations", EmitDefaultValue=true)]
        public long NumberOfPartnerOrganizations { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfCompletedHours
        /// </summary>
        [Required]
        [DataMember(Name="numberOfCompletedHours", EmitDefaultValue=true)]
        public double NumberOfCompletedHours { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PathwayOSAdminDashboardMetricsResponse {\n");
            sb.Append("  NumberOfParticipatingStudents: ").Append(NumberOfParticipatingStudents).Append("\n");
            sb.Append("  NumberOfActivitiesOffered: ").Append(NumberOfActivitiesOffered).Append("\n");
            sb.Append("  NumberOfExperiencesOffered: ").Append(NumberOfExperiencesOffered).Append("\n");
            sb.Append("  NumberOfPartnerContacts: ").Append(NumberOfPartnerContacts).Append("\n");
            sb.Append("  AverageHoursPerTimeLog: ").Append(AverageHoursPerTimeLog).Append("\n");
            sb.Append("  NumberOfPartnerOrganizations: ").Append(NumberOfPartnerOrganizations).Append("\n");
            sb.Append("  NumberOfCompletedHours: ").Append(NumberOfCompletedHours).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PathwayOSAdminDashboardMetricsResponse)obj);
        }

        /// <summary>
        /// Returns true if PathwayOSAdminDashboardMetricsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PathwayOSAdminDashboardMetricsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PathwayOSAdminDashboardMetricsResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NumberOfParticipatingStudents == other.NumberOfParticipatingStudents ||
                    
                    NumberOfParticipatingStudents.Equals(other.NumberOfParticipatingStudents)
                ) && 
                (
                    NumberOfActivitiesOffered == other.NumberOfActivitiesOffered ||
                    
                    NumberOfActivitiesOffered.Equals(other.NumberOfActivitiesOffered)
                ) && 
                (
                    NumberOfExperiencesOffered == other.NumberOfExperiencesOffered ||
                    
                    NumberOfExperiencesOffered.Equals(other.NumberOfExperiencesOffered)
                ) && 
                (
                    NumberOfPartnerContacts == other.NumberOfPartnerContacts ||
                    
                    NumberOfPartnerContacts.Equals(other.NumberOfPartnerContacts)
                ) && 
                (
                    AverageHoursPerTimeLog == other.AverageHoursPerTimeLog ||
                    
                    AverageHoursPerTimeLog.Equals(other.AverageHoursPerTimeLog)
                ) && 
                (
                    NumberOfPartnerOrganizations == other.NumberOfPartnerOrganizations ||
                    
                    NumberOfPartnerOrganizations.Equals(other.NumberOfPartnerOrganizations)
                ) && 
                (
                    NumberOfCompletedHours == other.NumberOfCompletedHours ||
                    
                    NumberOfCompletedHours.Equals(other.NumberOfCompletedHours)
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
                    
                    hashCode = hashCode * 59 + NumberOfParticipatingStudents.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfActivitiesOffered.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfExperiencesOffered.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfPartnerContacts.GetHashCode();
                    
                    hashCode = hashCode * 59 + AverageHoursPerTimeLog.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfPartnerOrganizations.GetHashCode();
                    
                    hashCode = hashCode * 59 + NumberOfCompletedHours.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PathwayOSAdminDashboardMetricsResponse left, PathwayOSAdminDashboardMetricsResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PathwayOSAdminDashboardMetricsResponse left, PathwayOSAdminDashboardMetricsResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
