Exercise: Implementing the Singleton Pattern

🧩 Scenario
You need to ensure that a logging utility class in your application has only one instance throughout the application lifecycle to maintain consistent logging. This is where the Singleton design pattern comes in.

📁 Step 1: Create a New Java Project
- Project Name: SingletonPatternExample

🧱 Step 2: Define a Singleton Class
- Create a class named `Logger`
- Declare a private static instance of `Logger`
- Make the constructor of `Logger` private to prevent instantiation from outside
- Provide a public static method `getInstance()` to access the single instance

Example:
public class Logger {
    private static Logger instance;

    private Logger() {
        // private constructor
    }

    public static Logger getInstance() {
        if (instance == null) {
            instance = new Logger();
        }
        return instance;
    }

    public void log(String message) {
        System.out.println("LOG: " + message);
    }
}

⚙️ Step 3: Implement the Singleton Pattern
- The pattern ensures only one instance of the `Logger` class exists
- All parts of the application share the same `Logger` instance

🧪 Step 4: Test the Singleton Implementation
- Create a `Main` or `TestLogger` class
- Verify that multiple calls to `getInstance()` return the same object

Example:
Logger logger1 = Logger.getInstance();
Logger logger2 = Logger.getInstance();

System.out.println(logger1 == logger2); // Output: true

📌 Conclusion
The Singleton pattern is useful for resource management, configuration, and logging systems where a single instance is required throughout the application.

🛠 Tools Used
- Language: Java
- IDE: IntelliJ IDEA / Eclipse / VS Code

🙌 Author
Robinson Douglas



<img width="1440" alt="Screenshot 2025-06-21 at 8 46 19 PM" src="https://github.com/user-attachments/assets/7a315e30-87d9-4819-b02e-8fbdb614cc53" />
