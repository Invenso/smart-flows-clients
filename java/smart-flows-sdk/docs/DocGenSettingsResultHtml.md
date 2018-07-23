
# DocGenSettingsResultHtml

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**format** | [**FormatEnum**](#FormatEnum) |  |  [optional]
**encoding** | **String** | Specifies the encoding to use |  [optional]
**exportHeadersFooters** | [**ExportHeadersFootersEnum**](#ExportHeadersFootersEnum) | Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section. |  [optional]
**exportPageMargins** | **Boolean** | Specifies whether page margins is exported |  [optional]
**exportPageSetup** | **Boolean** | Specifies whether page setup is exported |  [optional]
**exportTOCPageNumbers** | **Boolean** | Specifies whether to write page numbers to table of contents |  [optional]
**exportRelativeFontSize** | **Boolean** | Specifies whether font sizes should be output in relative units |  [optional]
**imageResolution** | [**BigDecimal**](BigDecimal.md) | Specifies the output resolution for images in dpi |  [optional]
**exportImagesAsBase64** | **Boolean** | Specifies whether images are saved in Base64 |  [optional]
**maintainLinkToExternalImages** | **Boolean** | Specifies whether original URL should be used as the URL of the linked images |  [optional]
**scaleImagesToShapeSize** | **Boolean** | Specifies whether images are scaled to the bounding shape size when exporting |  [optional]


<a name="FormatEnum"></a>
## Enum: FormatEnum
Name | Value
---- | -----
EPUB | &quot;epub&quot;
MHTML | &quot;mhtml&quot;
HTML | &quot;html&quot;


<a name="ExportHeadersFootersEnum"></a>
## Enum: ExportHeadersFootersEnum
Name | Value
---- | -----
FIRSTPAGEHEADERFOOTERPERSECTION | &quot;firstPageheaderFooterPerSection&quot;
PERSECTION | &quot;perSection&quot;
FIRSTSECTIONHEADERLASTSECTIONFOOTER | &quot;firstSectionHeaderLastSectionFooter&quot;
NONE | &quot;none&quot;



