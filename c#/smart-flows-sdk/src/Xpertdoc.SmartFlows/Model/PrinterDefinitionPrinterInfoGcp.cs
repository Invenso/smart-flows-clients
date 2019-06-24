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
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// PrinterDefinitionPrinterInfoGcp
    /// </summary>
    [DataContract]
    public partial class PrinterDefinitionPrinterInfoGcp : IEquatable<PrinterDefinitionPrinterInfoGcp>, IValidatableObject
    {
        /// <summary>
        /// Defines ConnectionStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectionStatusEnum
        {

            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Online for value: online
            /// </summary>
            [EnumMember(Value = "online")]
            Online = 2,

            /// <summary>
            /// Enum Offline for value: offline
            /// </summary>
            [EnumMember(Value = "offline")]
            Offline = 3,

            /// <summary>
            /// Enum Dormant for value: dormant
            /// </summary>
            [EnumMember(Value = "dormant")]
            Dormant = 4
        }

        /// <summary>
        /// Gets or Sets ConnectionStatus
        /// </summary>
        [DataMember(Name = "connectionStatus", EmitDefaultValue = false)]
        public ConnectionStatusEnum? ConnectionStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterDefinitionPrinterInfoGcp" /> class.
        /// </summary>
        /// <param name="Connector">Connector.</param>
        /// <param name="CreateTime">CreateTime.</param>
        /// <param name="UpdateTime">UpdateTime.</param>
        /// <param name="AccessTime">AccessTime.</param>
        /// <param name="ConnectionStatus">ConnectionStatus.</param>
        /// <param name="VendorCapabilities">VendorCapabilities.</param>
        public PrinterDefinitionPrinterInfoGcp(IdWithName Connector = default(IdWithName), string CreateTime = default(string), string UpdateTime = default(string), string AccessTime = default(string), ConnectionStatusEnum? ConnectionStatus = default(ConnectionStatusEnum?), List<GcpVendorCapability> VendorCapabilities = default(List<GcpVendorCapability>))
        {
            this.Connector = Connector;
            this.CreateTime = CreateTime;
            this.UpdateTime = UpdateTime;
            this.AccessTime = AccessTime;
            this.ConnectionStatus = ConnectionStatus;
            this.VendorCapabilities = VendorCapabilities;
        }

        /// <summary>
        /// Gets or Sets Connector
        /// </summary>
        [DataMember(Name = "connector", EmitDefaultValue = false)]
        public IdWithName Connector { get; set; }

        /// <summary>
        /// Gets or Sets CreateTime
        /// </summary>
        [DataMember(Name = "createTime", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// Gets or Sets UpdateTime
        /// </summary>
        [DataMember(Name = "updateTime", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets AccessTime
        /// </summary>
        [DataMember(Name = "accessTime", EmitDefaultValue = false)]
        public string AccessTime { get; set; }


        /// <summary>
        /// Gets or Sets VendorCapabilities
        /// </summary>
        [DataMember(Name = "vendorCapabilities", EmitDefaultValue = false)]
        public List<GcpVendorCapability> VendorCapabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrinterDefinitionPrinterInfoGcp {\n");
            sb.Append("  Connector: ").Append(Connector).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  AccessTime: ").Append(AccessTime).Append("\n");
            sb.Append("  ConnectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  VendorCapabilities: ").Append(VendorCapabilities).Append("\n");
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
            return this.Equals(input as PrinterDefinitionPrinterInfoGcp);
        }

        /// <summary>
        /// Returns true if PrinterDefinitionPrinterInfoGcp instances are equal
        /// </summary>
        /// <param name="input">Instance of PrinterDefinitionPrinterInfoGcp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrinterDefinitionPrinterInfoGcp input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Connector == input.Connector ||
                    (this.Connector != null &&
                    this.Connector.Equals(input.Connector))
                ) &&
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) &&
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) &&
                (
                    this.AccessTime == input.AccessTime ||
                    (this.AccessTime != null &&
                    this.AccessTime.Equals(input.AccessTime))
                ) &&
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
                ) &&
                (
                    this.VendorCapabilities == input.VendorCapabilities ||
                    this.VendorCapabilities != null &&
                    this.VendorCapabilities.SequenceEqual(input.VendorCapabilities)
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
                if (this.Connector != null)
                    hashCode = hashCode * 59 + this.Connector.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.AccessTime != null)
                    hashCode = hashCode * 59 + this.AccessTime.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.VendorCapabilities != null)
                    hashCode = hashCode * 59 + this.VendorCapabilities.GetHashCode();
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
