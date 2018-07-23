# IO.Swagger.Model.DocGenSettingsResultPdf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compliance** | **string** | Specifies the PDF standards compliance level. Pdf15: The output file will comply with the PDF 1.5 standard. PdfA1a: The output file will comply with the PDF/A-1a standard. This level includes all the requirements of PDF/A-1b and additionally requires that document structure be included (also known as being tagged), with the objective of ensuring that document content can be searched and repurposed. PdfA1b: The output file will comply with the PDF/A-1b standard. PDF/A-1b has the objective of ensuring reliable reproduction of the visual appearance of the document | [optional] [default to ComplianceEnum.Pdf15]
**PreserveFormFields** | **bool?** | Specifies whether to preserve form fields in PDF or convert them to text. Microsoft Word form fields include text input, drop down and check box controls. When set to false, these fields will be exported as text. When set to true, these fields will be exported as PDF form fields. When exporting form fields to PDF as form fields, some formatting loss might occur because PDF form fields do not support all features of Microsoft Word form fields | [optional] [default to false]
**FontEmbeddingMode** | **string** | Controls how fonts are embedded into the resulting PDF documents. All: Embed all fonts. Non Standard: embed all fonts except standard Windows fonts Arial and Times New Roman. None: no fonts are embedded | [optional] [default to FontEmbeddingModeEnum.None]
**Encryption** | [**DocGenSettingsResultPdfEncryption**](DocGenSettingsResultPdfEncryption.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

