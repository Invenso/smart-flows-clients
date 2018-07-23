
# Dataset

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** |  |  [optional]
**displayName** | **String** |  | 
**description** | **String** |  |  [optional]
**createdAt** | **String** |  |  [optional]
**createdBy** | [**IdWithName**](IdWithName.md) |  |  [optional]
**modifiedAt** | **String** |  |  [optional]
**modifiedBy** | [**IdWithName**](IdWithName.md) |  |  [optional]
**datasources** | [**List&lt;IdWithName&gt;**](IdWithName.md) |  |  [optional]
**tagGroups** | [**List&lt;TagGroupRef&gt;**](TagGroupRef.md) |  |  [optional]
**content** | [**DatasetContent**](DatasetContent.md) |  |  [optional]
**layout** | [**List&lt;EntityReference&gt;**](EntityReference.md) |  |  [optional]
**purpose** | [**List&lt;PurposeEnum&gt;**](#List&lt;PurposeEnum&gt;) |  |  [optional]
**readOnly** | **Boolean** |  |  [optional]


<a name="List<PurposeEnum>"></a>
## Enum: List&lt;PurposeEnum&gt;
Name | Value
---- | -----
TEMPLATEDESIGN | &quot;templateDesign&quot;
FLOWINPUT | &quot;flowInput&quot;



