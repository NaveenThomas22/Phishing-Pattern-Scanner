# Phishing Pattern Scanner  

A simple C# tool to quickly identify potentially suspicious URLs based on common phishing patterns.  

## Description  

Phishing Pattern Scanner is a basic command-line application that analyzes a given URL and flags it as potentially suspicious if it matches certain criteria often found in phishing attempts. It's designed as a first line of defense and should not be considered a definitive phishing detector.  

**Key Features:**  

*   **Quick URL Analysis:**  Provides a fast assessment of a URL's potential risk.  
*   **Pattern-Based Detection:**  Identifies suspicious URLs based on length, character patterns, and other simple heuristics.  
*   **Easy to Use:** Simple command-line interface for straightforward URL checking.  

**Limitations:**  

*   **Basic Checks Only:** Relies on simple pattern matching and does not employ advanced phishing detection techniques.  
*   **Not a Guarantee:**  A negative result does not guarantee a URL is safe.  Always exercise caution when clicking on links.  
*   **Limited Customization:**  The detection rules are hardcoded and not easily configurable.  

## Usage  

1.  **Clone the repository (if applicable) or copy the `Program.cs` file.**  
2.  **Compile the code:**  Use a C# compiler (like the one included with Visual Studio or the .NET SDK) to compile the `Program.cs` file.  For example:  

    ```bash  
    csc Program.cs  
    ```  

3.  **Run the executable:** Execute the compiled program.  

    ```bash  
    Program.exe  
    ```  

4.  **Enter the URL:**  The program will prompt you to enter the URL you want to check.  

5.  **View the Result:** The program will output whether the URL is considered suspicious based on its internal checks.  

## Code Overview  

The core logic is within the `CheckForPhishing` function:  

```csharp  
public static bool CheckForPhishing(string url)  
{  
    if (url.Length > 75)  
    {  
        return true;  
    }  

    if (url.Contains("a") || url.Contains("//") || url.Contains("http://http"))  
    {  
        return true;  
    }  
    if (!url.Contains(".") || url.EndsWith(".exe"))  
    {  
        return true;  
    }  
    return false;  
}  
