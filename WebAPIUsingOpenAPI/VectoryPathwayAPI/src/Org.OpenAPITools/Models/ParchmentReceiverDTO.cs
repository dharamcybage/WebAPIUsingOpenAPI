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
    public partial class ParchmentReceiverDTO : IEquatable<ParchmentReceiverDTO>
    {
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [Required]
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets MemberType
        /// </summary>
        [Required]
        [DataMember(Name="memberType", EmitDefaultValue=false)]
        public string MemberType { get; set; }

        /// <summary>
        /// Gets or Sets DeletedAt
        /// </summary>
        [DataMember(Name="deletedAt", EmitDefaultValue=true)]
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [Required]
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=true)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets CeebCode
        /// </summary>
        [Required]
        [DataMember(Name="ceebCode", EmitDefaultValue=false)]
        public string CeebCode { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [Required]
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Nicknames
        /// </summary>
        [Required]
        [DataMember(Name="nicknames", EmitDefaultValue=false)]
        public List<string> Nicknames { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ParchmentId
        /// </summary>
        [Required]
        [DataMember(Name="parchmentId", EmitDefaultValue=true)]
        public long ParchmentId { get; set; }

        /// <summary>
        /// Gets or Sets ZipCode
        /// </summary>
        [Required]
        [DataMember(Name="zipCode", EmitDefaultValue=false)]
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [Required]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AddressOne
        /// </summary>
        [Required]
        [DataMember(Name="addressOne", EmitDefaultValue=false)]
        public string AddressOne { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets NcesId
        /// </summary>
        [DataMember(Name="ncesId", EmitDefaultValue=true)]
        public string NcesId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParchmentReceiverDTO {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  MemberType: ").Append(MemberType).Append("\n");
            sb.Append("  DeletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CeebCode: ").Append(CeebCode).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Nicknames: ").Append(Nicknames).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ParchmentId: ").Append(ParchmentId).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AddressOne: ").Append(AddressOne).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  NcesId: ").Append(NcesId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ParchmentReceiverDTO)obj);
        }

        /// <summary>
        /// Returns true if ParchmentReceiverDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ParchmentReceiverDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParchmentReceiverDTO other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PhoneNumber == other.PhoneNumber ||
                    PhoneNumber != null &&
                    PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
                ) && 
                (
                    MemberType == other.MemberType ||
                    MemberType != null &&
                    MemberType.Equals(other.MemberType)
                ) && 
                (
                    DeletedAt == other.DeletedAt ||
                    DeletedAt != null &&
                    DeletedAt.Equals(other.DeletedAt)
                ) && 
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                ) && 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    CeebCode == other.CeebCode ||
                    CeebCode != null &&
                    CeebCode.Equals(other.CeebCode)
                ) && 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    Nicknames == other.Nicknames ||
                    Nicknames != null &&
                    other.Nicknames != null &&
                    Nicknames.SequenceEqual(other.Nicknames)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    ParchmentId == other.ParchmentId ||
                    
                    ParchmentId.Equals(other.ParchmentId)
                ) && 
                (
                    ZipCode == other.ZipCode ||
                    ZipCode != null &&
                    ZipCode.Equals(other.ZipCode)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    AddressOne == other.AddressOne ||
                    AddressOne != null &&
                    AddressOne.Equals(other.AddressOne)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    NcesId == other.NcesId ||
                    NcesId != null &&
                    NcesId.Equals(other.NcesId)
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
                    if (PhoneNumber != null)
                    hashCode = hashCode * 59 + PhoneNumber.GetHashCode();
                    if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                    if (MemberType != null)
                    hashCode = hashCode * 59 + MemberType.GetHashCode();
                    if (DeletedAt != null)
                    hashCode = hashCode * 59 + DeletedAt.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (CeebCode != null)
                    hashCode = hashCode * 59 + CeebCode.GetHashCode();
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (Nicknames != null)
                    hashCode = hashCode * 59 + Nicknames.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    
                    hashCode = hashCode * 59 + ParchmentId.GetHashCode();
                    if (ZipCode != null)
                    hashCode = hashCode * 59 + ZipCode.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (AddressOne != null)
                    hashCode = hashCode * 59 + AddressOne.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (NcesId != null)
                    hashCode = hashCode * 59 + NcesId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ParchmentReceiverDTO left, ParchmentReceiverDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ParchmentReceiverDTO left, ParchmentReceiverDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
