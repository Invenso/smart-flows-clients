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
    /// ConditionGroupNode
    /// </summary>
    [DataContract]
    public partial class ConditionGroupNode : IEquatable<ConditionGroupNode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionGroupNode" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Group">Group.</param>
        /// <param name="Condition">Condition.</param>
        public ConditionGroupNode(string Id = default(string), ConditionGroup Group = default(ConditionGroup), Condition Condition = default(Condition))
        {
            this.Id = Id;
            this.Group = Group;
            this.Condition = Condition;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public ConditionGroup Group { get; set; }

        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "condition", EmitDefaultValue = false)]
        public Condition Condition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionGroupNode {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
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
            return this.Equals(input as ConditionGroupNode);
        }

        /// <summary>
        /// Returns true if ConditionGroupNode instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionGroupNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionGroupNode input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) &&
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
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
