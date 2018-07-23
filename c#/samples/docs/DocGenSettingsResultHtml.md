# IO.Swagger.Model.DocGenSettingsResultHtml
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Format** | **string** |  | [optional] [default to FormatEnum.Html]
**Encoding** | **string** | Specifies the encoding to use | [optional] [default to "UTF-8"]
**ExportHeadersFooters** | **string** | Specifies how headers and footers are output. None: Headers and footers are not exported. PerSection: Primary headers and footers are exported at the beginning and the end of each section. FirstSectionHeaderLastSectionFooter: Primary header of the first section is exported at the beginning of the document and primary footer is at the end. FirstPageheaderFooterPerSection: First page header and footer are exported at the beginning and the end of each section. | [optional] [default to ExportHeadersFootersEnum.PerSection]
**ExportPageMargins** | **bool?** | Specifies whether page margins is exported | [optional] [default to false]
**ExportPageSetup** | **bool?** | Specifies whether page setup is exported | [optional] [default to false]
**ExportTOCPageNumbers** | **bool?** | Specifies whether to write page numbers to table of contents | [optional] [default to false]
**ExportRelativeFontSize** | **bool?** | Specifies whether font sizes should be output in relative units | [optional] [default to false]
**ImageResolution** | **decimal?** | Specifies the output resolution for images in dpi | [optional] 
**ExportImagesAsBase64** | **bool?** | Specifies whether images are saved in Base64 | [optional] [default to false]
**MaintainLinkToExternalImages** | **bool?** | Specifies whether original URL should be used as the URL of the linked images | [optional] [default to true]
**ScaleImagesToShapeSize** | **bool?** | Specifies whether images are scaled to the bounding shape size when exporting | [optional] [default to true]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

