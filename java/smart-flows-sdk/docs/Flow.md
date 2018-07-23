
# Flow

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** |  |  [optional]
**displayName** | **String** |  |  [optional]
**description** | **String** |  |  [optional]
**createdAt** | **String** |  |  [optional]
**createdBy** | [**IdWithName**](IdWithName.md) |  |  [optional]
**modifiedAt** | **String** |  |  [optional]
**modifiedBy** | [**IdWithName**](IdWithName.md) |  |  [optional]
**tagGroups** | [**List&lt;TagGroupRef&gt;**](TagGroupRef.md) |  |  [optional]
**type** | [**TypeEnum**](#TypeEnum) |  |  [optional]
**body** | [**FlowBody**](FlowBody.md) |  |  [optional]
**input** | [**FlowInput**](FlowInput.md) |  |  [optional]
**primaryEntity** | **String** |  |  [optional]
**primaryTemplate** | [**IdWithName**](IdWithName.md) |  |  [optional]
**settings** | [**FlowSettings**](FlowSettings.md) |  |  [optional]


<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
SIMPLE | &quot;simple&quot;
ADVANCED | &quot;advanced&quot;



