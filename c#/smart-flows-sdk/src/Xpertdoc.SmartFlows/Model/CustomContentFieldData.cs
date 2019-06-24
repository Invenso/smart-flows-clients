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
    /// CustomContentFieldData
    /// </summary>
    [DataContract]
    public partial class CustomContentFieldData : IEquatable<CustomContentFieldData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomContentFieldData" /> class.
        /// </summary>
        /// <param name="Options">Options.</param>
        /// <param name="_Default">_Default.</param>
        public CustomContentFieldData(List<CustomContentFieldDataOptions> Options = default(List<CustomContentFieldDataOptions>), string _Default = default(string))
        {
            this.Options = Options;
            this._Default = _Default;
        }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public List<CustomContentFieldDataOptions> Options { get; set; }

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public string _Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomContentFieldData {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
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
            return this.Equals(input as CustomContentFieldData);
        }

        /// <summary>
        /// Returns true if CustomContentFieldData instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomContentFieldData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomContentFieldData input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) &&
                (
                    this._Default == input._Default ||
                    (this._Default != null &&
                    this._Default.Equals(input._Default))
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
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this._Default != null)
                    hashCode = hashCode * 59 + this._Default.GetHashCode();
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
