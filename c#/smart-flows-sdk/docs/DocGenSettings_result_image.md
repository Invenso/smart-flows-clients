# IO.Swagger.Model.DocGenSettingsResultImage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pageing** | [**DocGenSettingsResultImagePageing**](DocGenSettingsResultImagePageing.md) |  | [optional] 
**Format** | **string** |  | [optional] [default to FormatEnum.PngEnum]
**AntiAliasing** | **bool?** | Whether or not to use anti-aliasing for rendering | [optional] [default to true]
**ColorMode** | **string** | How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black | [optional] [default to ColorModeEnum.NormalEnum]
**Resolution** | **int?** | Specifies the output resolution for images in dpi | [optional] 
**PaperColor** | **string** | The background (paper) color for the generated images. When rendering pages of a document that specifies its own background color, then the document background color will override the color specified by this property | [optional] [default to "white"]
**Scale** | **decimal?** | The zoom factor for the generated images | [optional] 
**JpegQuality** | **int?** | The quality of JPEG images. 0 means worst quality but maximum compression and 100 means best quality but minimum compression. If quality is 100, it means no compression | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

