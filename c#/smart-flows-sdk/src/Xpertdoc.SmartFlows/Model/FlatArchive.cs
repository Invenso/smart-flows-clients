/* 
 * SmartFlows
 *
 * This describes the REST api for one SmartFlows project 
 *
 * OpenAPI spec version: 4.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// FlatArchive
    /// </summary>
    [DataContract]
    public partial class FlatArchive : IEquatable<FlatArchive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlatArchive" /> class.
        /// </summary>
        /// <param name="Archive">Archive.</param>
        /// <param name="Items">Items.</param>
        public FlatArchive(Archive Archive = default(Archive), List<ArchivableItem> Items = default(List<ArchivableItem>))
        {
            this.Archive = Archive;
            this.Items = Items;
        }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name = "archive", EmitDefaultValue = false)]
        public Archive Archive { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<ArchivableItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlatArchive {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlatArchive);
        }

        /// <summary>
        /// Returns true if FlatArchive instances are equal
        /// </summary>
        /// <param name="input">Instance of FlatArchive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlatArchive input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Archive == input.Archive ||
                    (this.Archive != null &&
                    this.Archive.Equals(input.Archive))
                ) &&
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                int hashCode = 41;
                if (this.Archive != null)
                    hashCode = hashCode * 59 + this.Archive.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
