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
    public partial class PayPeriodReflectionApprovalFetchResponse : IEquatable<PayPeriodReflectionApprovalFetchResponse>
    {
        /// <summary>
        /// Gets or Sets TimeLogs
        /// </summary>
        [Required]
        [DataMember(Name="timeLogs", EmitDefaultValue=false)]
        public List<TimeLogDTO> TimeLogs { get; set; }

        /// <summary>
        /// Gets or Sets Submission
        /// </summary>
        [DataMember(Name="submission", EmitDefaultValue=false)]
        public FormSubmissionResponse Submission { get; set; }

        /// <summary>
        /// Gets or Sets Form
        /// </summary>
        [DataMember(Name="form", EmitDefaultValue=false)]
        public FormResponse Form { get; set; }

        /// <summary>
        /// Gets or Sets PayPeriod
        /// </summary>
        [Required]
        [DataMember(Name="payPeriod", EmitDefaultValue=false)]
        public PayPeriodDTO PayPeriod { get; set; }

        /// <summary>
        /// Gets or Sets PayPeriodSubmission
        /// </summary>
        [Required]
        [DataMember(Name="payPeriodSubmission", EmitDefaultValue=false)]
        public Object PayPeriodSubmission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayPeriodReflectionApprovalFetchResponse {\n");
            sb.Append("  TimeLogs: ").Append(TimeLogs).Append("\n");
            sb.Append("  Submission: ").Append(Submission).Append("\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  PayPeriod: ").Append(PayPeriod).Append("\n");
            sb.Append("  PayPeriodSubmission: ").Append(PayPeriodSubmission).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PayPeriodReflectionApprovalFetchResponse)obj);
        }

        /// <summary>
        /// Returns true if PayPeriodReflectionApprovalFetchResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of PayPeriodReflectionApprovalFetchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayPeriodReflectionApprovalFetchResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TimeLogs == other.TimeLogs ||
                    TimeLogs != null &&
                    other.TimeLogs != null &&
                    TimeLogs.SequenceEqual(other.TimeLogs)
                ) && 
                (
                    Submission == other.Submission ||
                    Submission != null &&
                    Submission.Equals(other.Submission)
                ) && 
                (
                    Form == other.Form ||
                    Form != null &&
                    Form.Equals(other.Form)
                ) && 
                (
                    PayPeriod == other.PayPeriod ||
                    PayPeriod != null &&
                    PayPeriod.Equals(other.PayPeriod)
                ) && 
                (
                    PayPeriodSubmission == other.PayPeriodSubmission ||
                    PayPeriodSubmission != null &&
                    PayPeriodSubmission.Equals(other.PayPeriodSubmission)
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
                    if (TimeLogs != null)
                    hashCode = hashCode * 59 + TimeLogs.GetHashCode();
                    if (Submission != null)
                    hashCode = hashCode * 59 + Submission.GetHashCode();
                    if (Form != null)
                    hashCode = hashCode * 59 + Form.GetHashCode();
                    if (PayPeriod != null)
                    hashCode = hashCode * 59 + PayPeriod.GetHashCode();
                    if (PayPeriodSubmission != null)
                    hashCode = hashCode * 59 + PayPeriodSubmission.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PayPeriodReflectionApprovalFetchResponse left, PayPeriodReflectionApprovalFetchResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PayPeriodReflectionApprovalFetchResponse left, PayPeriodReflectionApprovalFetchResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
