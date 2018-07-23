# IO.Swagger.Model.FlowExecutionState
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputData** | [**IdWithName**](IdWithName.md) |  | [optional] 
**Output** | [**FlowExecutionStateOutput**](FlowExecutionStateOutput.md) |  | [optional] 
**Stages** | [**List&lt;FlowExecutionStage&gt;**](FlowExecutionStage.md) |  | [optional] 
**Iterations** | [**List&lt;FlowExecutionIteration&gt;**](FlowExecutionIteration.md) | if the input supports multiple iterations, these are the iterations | [optional] 
**Report** | [**List&lt;FlowZoneState&gt;**](FlowZoneState.md) | if the input supports multiple iterations, but groupToSingleDocument is enabled, these are the post processing zones. If the input does not support multiple iterations, these are the flow zones | [optional] 
**WaitingFor** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

