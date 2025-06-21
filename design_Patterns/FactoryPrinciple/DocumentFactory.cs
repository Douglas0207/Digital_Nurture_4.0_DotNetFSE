using System;

public class DocumentFactory
{
    public static Document CreateDocument(string type)
    {
        switch (type)
        {
            case "Word":
                return new WordDocument();
            case "PDF":
                return new PdfDocument();
            case "Excel":
                return new ExcelDocument();
            default:
                throw new ArgumentException("Unknown Document type");
       }
    }
}