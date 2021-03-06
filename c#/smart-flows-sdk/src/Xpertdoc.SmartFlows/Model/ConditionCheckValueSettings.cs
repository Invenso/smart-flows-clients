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
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// ConditionCheckValueSettings
    /// </summary>
    [DataContract]
    public partial class ConditionCheckValueSettings : IEquatable<ConditionCheckValueSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionCheckValueSettings" /> class.
        /// </summary>
        /// <param name="Date">Date.</param>
        /// <param name="Number">Number.</param>
        /// <param name="Text">Text.</param>
        /// <param name="Boolean">Boolean.</param>
        public ConditionCheckValueSettings(DateCondition Date = default(DateCondition), NumberCondition Number = default(NumberCondition), TextCondition Text = default(TextCondition), BooleanCondition Boolean = default(BooleanCondition))
        {
            this.Date = Date;
            this.Number = Number;
            this.Text = Text;
            this.Boolean = Boolean;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateCondition Date { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public NumberCondition Number { get; set; }
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public TextCondition Text { get; set; }
        /// <summary>
        /// Gets or Sets Boolean
        /// </summary>
        [DataMember(Name = "boolean", EmitDefaultValue = false)]
        public BooleanCondition Boolean { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionCheckValueSettings {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Boolean: ").Append(Boolean).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConditionCheckValueSettings);
        }

        /// <summary>
        /// Returns true if ConditionCheckValueSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of ConditionCheckValueSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionCheckValueSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) &&
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) &&
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.Boolean == other.Boolean ||
                    this.Boolean != null &&
                    this.Boolean.Equals(other.Boolean)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Boolean != null)
                    hash = hash * 59 + this.Boolean.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
