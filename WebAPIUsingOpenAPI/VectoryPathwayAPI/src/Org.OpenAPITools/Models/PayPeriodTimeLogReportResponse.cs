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
    public partial class PayPeriodTimeLogReportResponse : IEquatable<PayPeriodTimeLogReportResponse>
    {
        /// <summary>
        /// Gets or Sets StudentID
        /// </summary>
        [DataMember(Name="studentID", EmitDefaultValue=true)]
        public string StudentID { get; set; }

        /// <summary>
        /// Gets or Sets StudentName
        /// </summary>
        [Required]
        [DataMember(Name="studentName", EmitDefaultValue=false)]
        public string StudentName { get; set; }

        /// <summary>
        /// Gets or Sets Experience
        /// </summary>
        [Required]
        [DataMember(Name="experience", EmitDefaultValue=false)]
        public string Experience { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [Required]
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceContactEmail
        /// </summary>
        [DataMember(Name="experienceContactEmail", EmitDefaultValue=true)]
        public string ExperienceContactEmail { get; set; }

        /// <summary>
        /// Gets or Sets StudentEmail
        /// </summary>
        [Required]
        [DataMember(Name="studentEmail", EmitDefaultValue=false)]
        public string StudentEmail { get; set; }

        /// <summary>
        /// Gets or Sets TimeLog
        /// </summary>
        [Required]
        [DataMember(Name="timeLog", EmitDefaultValue=false)]
        public TimeLogDTO TimeLog { get; set; }

        /// <summary>
        /// Gets or Sets PayPeriod
        /// </summary>
        [DataMember(Name="payPeriod", EmitDefaultValue=false)]
        public PayPeriodDTO PayPeriod { get; set; }

        /// <summary>
        /// Gets or Sets SupervisorApproved
        /// </summary>
        [Required]
        [DataMember(Name="supervisorApproved", EmitDefaultValue=true)]
        public bool SupervisorApproved { get; set; }

        /// <summary>
        /// Gets or Sets ExperienceContact
        /// </summary>
        [Required]
        [DataMember(Name="experienceContact", EmitDefaultValue=false)]
        public string ExperienceContact { get; set; }

        /// <summary>
        /// Gets or Sets Archived
        /// </summary>
        [Required]
        [DataMember(Name="archived", EmitDefaultValue=true)]
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or Sets StudentSignature
        /// </summary>
        [DataMember(Name="studentSignature", EmitDefaultValue=true)]
        public string StudentSignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayPeriodTimeLogReportResponse {\n");
            sb.Append("  StudentID: ").Append(StudentID).Append("\n");
            sb.Append("  StudentName: ").Append(StudentName).Append("\n");
            sb.Append("  Experience: ").Append(Experience).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  ExperienceContactEmail: ").Append(ExperienceContactEmail).Append("\n");
            sb.Append("  StudentEmail: ").Append(StudentEmail).Append("\n");
            sb.Append("  TimeLog: ").Append(TimeLog).Append("\n");
            sb.Append("  PayPeriod: ").Append(PayPeriod).Append("\n");
            sb.Append("  SupervisorApproved: ").Append(SupervisorApproved).Append("\n");
            sb.Append("  ExperienceContact: ").Append(ExperienceContact).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  StudentSignature: ").Append(StudentSignature).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PayPeriodTimeLogReportResponse)obj);
        }

        /// <summary>
        /// Returns true if PayPeriodTimeLogReportResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PayPeriodTimeLogReportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayPeriodTimeLogReportResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    StudentID == other.StudentID ||
                    StudentID != null &&
                    StudentID.Equals(other.StudentID)
                ) && 
                (
                    StudentName == other.StudentName ||
                    StudentName != null &&
                    StudentName.Equals(other.StudentName)
                ) && 
                (
                    Experience == other.Experience ||
                    Experience != null &&
                    Experience.Equals(other.Experience)
                ) && 
                (
                    Organization == other.Organization ||
                    Organization != null &&
                    Organization.Equals(other.Organization)
                ) && 
                (
                    ExperienceContactEmail == other.ExperienceContactEmail ||
                    ExperienceContactEmail != null &&
                    ExperienceContactEmail.Equals(other.ExperienceContactEmail)
                ) && 
                (
                    StudentEmail == other.StudentEmail ||
                    StudentEmail != null &&
                    StudentEmail.Equals(other.StudentEmail)
                ) && 
                (
                    TimeLog == other.TimeLog ||
                    TimeLog != null &&
                    TimeLog.Equals(other.TimeLog)
                ) && 
                (
                    PayPeriod == other.PayPeriod ||
                    PayPeriod != null &&
                    PayPeriod.Equals(other.PayPeriod)
                ) && 
                (
                    SupervisorApproved == other.SupervisorApproved ||
                    
                    SupervisorApproved.Equals(other.SupervisorApproved)
                ) && 
                (
                    ExperienceContact == other.ExperienceContact ||
                    ExperienceContact != null &&
                    ExperienceContact.Equals(other.ExperienceContact)
                ) && 
                (
                    Archived == other.Archived ||
                    
                    Archived.Equals(other.Archived)
                ) && 
                (
                    StudentSignature == other.StudentSignature ||
                    StudentSignature != null &&
                    StudentSignature.Equals(other.StudentSignature)
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
                    if (StudentID != null)
                    hashCode = hashCode * 59 + StudentID.GetHashCode();
                    if (StudentName != null)
                    hashCode = hashCode * 59 + StudentName.GetHashCode();
                    if (Experience != null)
                    hashCode = hashCode * 59 + Experience.GetHashCode();
                    if (Organization != null)
                    hashCode = hashCode * 59 + Organization.GetHashCode();
                    if (ExperienceContactEmail != null)
                    hashCode = hashCode * 59 + ExperienceContactEmail.GetHashCode();
                    if (StudentEmail != null)
                    hashCode = hashCode * 59 + StudentEmail.GetHashCode();
                    if (TimeLog != null)
                    hashCode = hashCode * 59 + TimeLog.GetHashCode();
                    if (PayPeriod != null)
                    hashCode = hashCode * 59 + PayPeriod.GetHashCode();
                    
                    hashCode = hashCode * 59 + SupervisorApproved.GetHashCode();
                    if (ExperienceContact != null)
                    hashCode = hashCode * 59 + ExperienceContact.GetHashCode();
                    
                    hashCode = hashCode * 59 + Archived.GetHashCode();
                    if (StudentSignature != null)
                    hashCode = hashCode * 59 + StudentSignature.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PayPeriodTimeLogReportResponse left, PayPeriodTimeLogReportResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PayPeriodTimeLogReportResponse left, PayPeriodTimeLogReportResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
