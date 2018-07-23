
# FlowExecutionState

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**inputData** | [**IdWithName**](IdWithName.md) |  |  [optional]
**output** | [**FlowExecutionStateOutput**](FlowExecutionStateOutput.md) |  |  [optional]
**stages** | [**List&lt;FlowExecutionStage&gt;**](FlowExecutionStage.md) |  |  [optional]
**iterations** | [**List&lt;FlowExecutionIteration&gt;**](FlowExecutionIteration.md) | if the input supports multiple iterations, these are the iterations |  [optional]
**report** | [**List&lt;FlowZoneState&gt;**](FlowZoneState.md) | if the input supports multiple iterations, but groupToSingleDocument is enabled, these are the post processing zones. If the input does not support multiple iterations, these are the flow zones |  [optional]
**waitingFor** | **String** |  |  [optional]



