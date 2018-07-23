
# DocGenSettingsResultImage

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pageing** | [**DocGenSettingsResultImagePageing**](DocGenSettingsResultImagePageing.md) |  |  [optional]
**format** | [**FormatEnum**](#FormatEnum) |  |  [optional]
**antiAliasing** | **Boolean** | Whether or not to use anti-aliasing for rendering |  [optional]
**colorMode** | [**ColorModeEnum**](#ColorModeEnum) | How colors are rendered. normal: render with unmodified colors. Grayscale: render with colors in a range of gray shades from white to black |  [optional]
**resolution** | **Integer** | Specifies the output resolution for images in dpi |  [optional]
**paperColor** | **String** | The background (paper) color for the generated images. When rendering pages of a document that specifies its own background color, then the document background color will override the color specified by this property |  [optional]
**scale** | [**BigDecimal**](BigDecimal.md) | The zoom factor for the generated images |  [optional]
**jpegQuality** | **Integer** | The quality of JPEG images. 0 means worst quality but maximum compression and 100 means best quality but minimum compression. If quality is 100, it means no compression |  [optional]


<a name="FormatEnum"></a>
## Enum: FormatEnum
Name | Value
---- | -----
PNG | &quot;png&quot;
JPEG | &quot;jpeg&quot;
SVG | &quot;svg&quot;
BMP | &quot;bmp&quot;
GIF | &quot;gif&quot;
EMF | &quot;emf&quot;


<a name="ColorModeEnum"></a>
## Enum: ColorModeEnum
Name | Value
---- | -----
NORMAL | &quot;normal&quot;
BLACKANDWHITE | &quot;blackAndWhite&quot;
GRAYSCALE | &quot;grayscale&quot;



