
# FlowStep

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** |  | 
**displayName** | **String** |  | 
**description** | **String** |  |  [optional]
**iconClass** | **String** |  |  [optional]
**group** | **String** |  |  [optional]
**type** | [**TypeEnum**](#TypeEnum) |  |  [optional]
**primaryParameters** | **List&lt;String&gt;** |  |  [optional]
**inputSchema** | **Object** |  |  [optional]
**inputForm** | **List&lt;Object&gt;** |  |  [optional]
**outputId** | **String** |  |  [optional]
**externalOutputParameters** | **List&lt;String&gt;** |  |  [optional]
**outputSchema** | **Object** |  |  [optional]


<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
DATA | &quot;data&quot;
GENDOC | &quot;gendoc&quot;
CONVERT | &quot;convert&quot;
POSTPROCESS | &quot;postprocess&quot;



