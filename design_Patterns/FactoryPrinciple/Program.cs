using System;

class Program
{
    static void Main(string[] args)
    {
        Document doc1 = DocumentFactory.CreateDocument("Word");
        doc1.Open();

        Document doc2 = DocumentFactory.CreateDocument("PDF");
        doc2.Open();

        Document doc3 = DocumentFactory.CreateDocument("Excel");
        doc3.Open();
    }
}
