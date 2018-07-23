
# Archivable

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**identifier** | [**IdWithName**](IdWithName.md) |  |  [optional]
**archiveType** | [**ArchiveTypeEnum**](#ArchiveTypeEnum) |  |  [optional]
**definition** | **String** |  |  [optional]
**checksum** | **String** |  |  [optional]
**contents** | [**List&lt;ArchivableContent&gt;**](ArchivableContent.md) |  |  [optional]
**outboundDependencies** | [**List&lt;DependencyTreeNode&gt;**](DependencyTreeNode.md) |  |  [optional]


<a name="ArchiveTypeEnum"></a>
## Enum: ArchiveTypeEnum
Name | Value
---- | -----
EXPLICIT | &quot;explicit&quot;
DEPENDENCY | &quot;dependency&quot;



