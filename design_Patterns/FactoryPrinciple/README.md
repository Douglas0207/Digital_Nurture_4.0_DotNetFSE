Exercise : Implementing the Factory Method Pattern

🧩 Scenario
You are developing a document management system that supports the creation of different document types like Word, PDF, and Excel. To allow scalable and flexible creation logic, you’ll use the Factory Method Design Pattern.

📁 Step 1: Create a New Java Project
- Project Name: FactoryMethodPatternExample

📄 Step 2: Define Document Interfaces or Abstract Classes
- Create a base interface or abstract class `Document` with a method like `open()`.

Example:
public interface Document {
    void open();
}

🏗 Step 3: Create Concrete Document Classes
- Implement `WordDocument`, `PdfDocument`, and `ExcelDocument` classes that implement `Document`.

Example:
public class WordDocument implements Document {
    public void open() {
        System.out.println("Opening Word document...");
    }
}

🏭 Step 4: Implement the Factory Method
- Create an abstract factory class `DocumentFactory` with an abstract method `createDocument()`
- Create concrete factories like `WordFactory`, `PdfFactory`, `ExcelFactory` that implement `createDocument()`

Example:
public abstract class DocumentFactory {
    public abstract Document createDocument();
}

public class PdfFactory extends DocumentFactory {
    public Document createDocument() {
        return new PdfDocument();
    }
}

🧪 Step 5: Test the Factory Method Implementation
- Write a test class that instantiates factories and uses them to create and open different documents

Example:
public class Main {
    public static void main(String[] args) {
        DocumentFactory factory = new PdfFactory();
        Document doc = factory.createDocument();
        doc.open(); // Output: Opening PDF document...
    }
}

📌 Conclusion
The Factory Method Pattern allows the system to be easily extended with new document types without modifying the existing code.

🛠 Tools Used
- Language: Java
- IDE: IntelliJ IDEA / Eclipse / VS Code

🙌 Author
Robinson Douglas
<img width="1440" alt="Screenshot 2025-06-21 at 8 46 59 PM" src="https://github.com/user-attachments/assets/a32ce929-9dce-41f2-9232-2787a09b4ead" />
