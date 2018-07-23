
# Part

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**template** | **String** |  | 
**templateDisplayName** | **String** | Read-only, will contain the displayName of the linked template at the moment of retrieval |  [optional]
**type** | [**TypeEnum**](#TypeEnum) |  | 
**_break** | [**BreakEnum**](#BreakEnum) |  |  [optional]
**linkHeaders** | **Boolean** |  |  [optional]
**occurrence** | [**OccurrenceEnum**](#OccurrenceEnum) |  |  [optional]
**conditions** | [**ConditionGroup**](ConditionGroup.md) |  |  [optional]


<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
BODY | &quot;body&quot;
HEADER | &quot;header&quot;
FOOTER | &quot;footer&quot;
ADDITION | &quot;addition&quot;


<a name="BreakEnum"></a>
## Enum: BreakEnum
Name | Value
---- | -----
NONE | &quot;none&quot;
CONTINUOUS | &quot;continuous&quot;
NEWCOLUMN | &quot;newColumn&quot;
NEWPAGE | &quot;newPage&quot;
EVENPAGE | &quot;evenPage&quot;
ODDPAGE | &quot;oddPage&quot;


<a name="OccurrenceEnum"></a>
## Enum: OccurrenceEnum
Name | Value
---- | -----
PRIMARY | &quot;primary&quot;
FIRSTPAGE | &quot;firstPage&quot;
EVENPAGE | &quot;evenPage&quot;



