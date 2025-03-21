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
    public partial class ProcessSFTPNotificationJobContext : IEquatable<ProcessSFTPNotificationJobContext>
    {
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [Required]
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets TargetPath
        /// </summary>
        [DataMember(Name="target_path", EmitDefaultValue=true)]
        public string TargetPath { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=true)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessSFTPNotificationJobContext {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  TargetPath: ").Append(TargetPath).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ProcessSFTPNotificationJobContext)obj);
        }

        /// <summary>
        /// Returns true if ProcessSFTPNotificationJobContext instances are equal
        /// </summary>
        /// <param name="other">Instance of ProcessSFTPNotificationJobContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessSFTPNotificationJobContext other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Username == other.Username ||
                    Username != null &&
                    Username.Equals(other.Username)
                ) && 
                (
                    JobId == other.JobId ||
                    JobId != null &&
                    JobId.Equals(other.JobId)
                ) && 
                (
                    TargetPath == other.TargetPath ||
                    TargetPath != null &&
                    TargetPath.Equals(other.TargetPath)
                ) && 
                (
                    Path == other.Path ||
                    Path != null &&
                    Path.Equals(other.Path)
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
                    if (Username != null)
                    hashCode = hashCode * 59 + Username.GetHashCode();
                    if (JobId != null)
                    hashCode = hashCode * 59 + JobId.GetHashCode();
                    if (TargetPath != null)
                    hashCode = hashCode * 59 + TargetPath.GetHashCode();
                    if (Path != null)
                    hashCode = hashCode * 59 + Path.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ProcessSFTPNotificationJobContext left, ProcessSFTPNotificationJobContext right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProcessSFTPNotificationJobContext left, ProcessSFTPNotificationJobContext right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
