```markdown
# 🧮 Console Calculator (C#)

![Calculator Demo](calculator-demo.gif) *(optional gif screenshot)*

## 🌟 Features
- **Basic arithmetic operations**:
  - ➕ Addition (`a`)
  - ➖ Subtraction (`s`)
  - ✖️ Multiplication (`m`)
  - ➗ Division (`d`)
- **Input validation**:
  - Checks for valid numbers
  - Prevents division by zero
  - Validates operation selection
- **User-friendly interface**:
  - UTF-8 emoji support
  - Continuous operation until exit
  - Clear error messages

## 🚀 Getting Started
1. **Prerequisites**:
   - [.NET 6+ SDK](https://dotnet.microsoft.com/download)

2. **Run the application**:
   ```bash
   dotnet run
   ```

3. **Build for release**:
   ```bash
   dotnet publish -c Release
   ```

## 🛠️ Code Structure
```csharp
Program.cs
├── Main()
│   ├── Number input validation (int.TryParse)
│   ├── Operation selection (a/s/m/d)
│   ├── Switch-case for calculations
│   ├── Division by zero protection
│   └── Loop control (y/n continue)
```

## 💻 Usage Example
```
Hello👋, Welcome to the calculator program!
Please enter your first number: 5
Please enter your second number: 3
What sort of operation would you like to do:
 a for addition
 s for subtraction
 m for multiplication
 d for division
m
5 * 3 = 15
Would you like to carry out another Calculation?(y/n)
```

## 🛡️ Error Handling
- ❌ Invalid number input:
  ``` 
  Please enter a valid number!
  ```
- ❌ Invalid operation:
  ```
  Please enter a valid operation
  ```
- ❌ Division by zero:
  ```
  Can't divide by 0
  ```


## 📜 License
MIT License - Free for personal and commercial use
```
