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
    /// FlowSwitch
    /// </summary>
    [DataContract]
    public partial class FlowSwitch : IEquatable<FlowSwitch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowSwitch" /> class.
        /// </summary>
        /// <param name="SwitchValue">SwitchValue.</param>
        /// <param name="Cases">Cases.</param>
        /// <param name="_Default">_Default.</param>
        public FlowSwitch(Object SwitchValue = default(Object), List<FlowSwitchCases> Cases = default(List<FlowSwitchCases>), List<FlowZone> _Default = default(List<FlowZone>))
        {
            this.SwitchValue = SwitchValue;
            this.Cases = Cases;
            this._Default = _Default;
        }

        /// <summary>
        /// Gets or Sets SwitchValue
        /// </summary>
        [DataMember(Name = "switchValue", EmitDefaultValue = false)]
        public Object SwitchValue { get; set; }

        /// <summary>
        /// Gets or Sets Cases
        /// </summary>
        [DataMember(Name = "cases", EmitDefaultValue = false)]
        public List<FlowSwitchCases> Cases { get; set; }

        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public List<FlowZone> _Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowSwitch {\n");
            sb.Append("  SwitchValue: ").Append(SwitchValue).Append("\n");
            sb.Append("  Cases: ").Append(Cases).Append("\n");
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
            return this.Equals(input as FlowSwitch);
        }

        /// <summary>
        /// Returns true if FlowSwitch instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowSwitch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowSwitch input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SwitchValue == input.SwitchValue ||
                    (this.SwitchValue != null &&
                    this.SwitchValue.Equals(input.SwitchValue))
                ) &&
                (
                    this.Cases == input.Cases ||
                    this.Cases != null &&
                    this.Cases.SequenceEqual(input.Cases)
                ) &&
                (
                    this._Default == input._Default ||
                    this._Default != null &&
                    this._Default.SequenceEqual(input._Default)
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
                if (this.SwitchValue != null)
                    hashCode = hashCode * 59 + this.SwitchValue.GetHashCode();
                if (this.Cases != null)
                    hashCode = hashCode * 59 + this.Cases.GetHashCode();
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
