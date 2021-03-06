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
    /// InProgressExecutions
    /// </summary>
    [DataContract]
    public partial class InProgressExecutions : IEquatable<InProgressExecutions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InProgressExecutions" /> class.
        /// </summary>
        /// <param name="Schedule">Schedule.</param>
        /// <param name="SelectFlow">SelectFlow.</param>
        /// <param name="UserInput">UserInput.</param>
        /// <param name="Waiting">Waiting.</param>
        public InProgressExecutions(Schedule Schedule = default(Schedule), CleanupActionSettings SelectFlow = default(CleanupActionSettings), CleanupActionSettings UserInput = default(CleanupActionSettings), CleanupActionSettings Waiting = default(CleanupActionSettings))
        {
            this.Schedule = Schedule;
            this.SelectFlow = SelectFlow;
            this.UserInput = UserInput;
            this.Waiting = Waiting;
        }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name = "schedule", EmitDefaultValue = false)]
        public Schedule Schedule { get; set; }
        /// <summary>
        /// Gets or Sets SelectFlow
        /// </summary>
        [DataMember(Name = "selectFlow", EmitDefaultValue = false)]
        public CleanupActionSettings SelectFlow { get; set; }
        /// <summary>
        /// Gets or Sets UserInput
        /// </summary>
        [DataMember(Name = "userInput", EmitDefaultValue = false)]
        public CleanupActionSettings UserInput { get; set; }
        /// <summary>
        /// Gets or Sets Waiting
        /// </summary>
        [DataMember(Name = "waiting", EmitDefaultValue = false)]
        public CleanupActionSettings Waiting { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InProgressExecutions {\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SelectFlow: ").Append(SelectFlow).Append("\n");
            sb.Append("  UserInput: ").Append(UserInput).Append("\n");
            sb.Append("  Waiting: ").Append(Waiting).Append("\n");
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
            return this.Equals(obj as InProgressExecutions);
        }

        /// <summary>
        /// Returns true if InProgressExecutions instances are equal
        /// </summary>
        /// <param name="other">Instance of InProgressExecutions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InProgressExecutions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Schedule == other.Schedule ||
                    this.Schedule != null &&
                    this.Schedule.Equals(other.Schedule)
                ) &&
                (
                    this.SelectFlow == other.SelectFlow ||
                    this.SelectFlow != null &&
                    this.SelectFlow.Equals(other.SelectFlow)
                ) &&
                (
                    this.UserInput == other.UserInput ||
                    this.UserInput != null &&
                    this.UserInput.Equals(other.UserInput)
                ) &&
                (
                    this.Waiting == other.Waiting ||
                    this.Waiting != null &&
                    this.Waiting.Equals(other.Waiting)
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
                if (this.Schedule != null)
                    hash = hash * 59 + this.Schedule.GetHashCode();
                if (this.SelectFlow != null)
                    hash = hash * 59 + this.SelectFlow.GetHashCode();
                if (this.UserInput != null)
                    hash = hash * 59 + this.UserInput.GetHashCode();
                if (this.Waiting != null)
                    hash = hash * 59 + this.Waiting.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
