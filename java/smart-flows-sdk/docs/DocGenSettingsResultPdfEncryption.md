
# DocGenSettingsResultPdfEncryption

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**algorithm** | [**AlgorithmEnum**](#AlgorithmEnum) | The encryption algorithm. rc4_40: RC4 encryption, key length of 40 bits. rc4_128: RC4 encryption, key length of 128 bits. |  [optional]
**ownerPassword** | **String** | The password for the encrypted document |  [optional]
**userPassword** | **String** | The password required for opening the encrypted document |  [optional]
**permissions** | [**List&lt;PermissionsEnum&gt;**](#List&lt;PermissionsEnum&gt;) |  |  [optional]


<a name="AlgorithmEnum"></a>
## Enum: AlgorithmEnum
Name | Value
---- | -----
_128 | &quot;rc4_128&quot;
_40 | &quot;rc4_40&quot;


<a name="List<PermissionsEnum>"></a>
## Enum: List&lt;PermissionsEnum&gt;
Name | Value
---- | -----
DISALLOWALL | &quot;disallowAll&quot;
ALLOWALL | &quot;allowAll&quot;
CONTENTCOPY | &quot;contentCopy&quot;
CONTENTCOPYFORACCESSIBILITY | &quot;contentCopyForAccessibility&quot;
MODIFYCONTENTS | &quot;modifyContents&quot;
MODIFYANNOTATIONS | &quot;modifyAnnotations&quot;
FILLIN | &quot;fillIn&quot;
DOCUMENTASSEMBLY | &quot;documentAssembly&quot;
PRINTING | &quot;printing&quot;
HIGHRESOLUTIONPRINTING | &quot;highResolutionPrinting&quot;



