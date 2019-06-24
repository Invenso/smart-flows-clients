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
using System.Runtime.Serialization;

namespace Xpertdoc.SmartFlows.Model
{
    /// <summary>
    /// Defines flowExecutionStatus
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum FlowExecutionStatus
    {

        /// <summary>
        /// Enum Queued for value: Queued
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued = 1,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 2,

        /// <summary>
        /// Enum Waiting for value: Waiting
        /// </summary>
        [EnumMember(Value = "Waiting")]
        Waiting = 3,

        /// <summary>
        /// Enum UserInput for value: UserInput
        /// </summary>
        [EnumMember(Value = "UserInput")]
        UserInput = 4,

        /// <summary>
        /// Enum Success for value: Success
        /// </summary>
        [EnumMember(Value = "Success")]
        Success = 5,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 6,

        /// <summary>
        /// Enum Canceled for value: Canceled
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled = 7,

        /// <summary>
        /// Enum SelectFlow for value: SelectFlow
        /// </summary>
        [EnumMember(Value = "SelectFlow")]
        SelectFlow = 8,

        /// <summary>
        /// Enum Interrupted for value: Interrupted
        /// </summary>
        [EnumMember(Value = "Interrupted")]
        Interrupted = 9
    }

}
