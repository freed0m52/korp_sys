using System;

class Calculator
{
    private double memory = 0;
    private double currentValue = 0;
    
    public void Run()
    {
        Console.WriteLine("Калькулятор");
        Console.WriteLine("Доступные операции: +, -, *, /, %, 1/x, x^2, sqrt, M+, M-, MR, C (очистка), EXIT");
        
        while (true)
        {
            try
            {
                Console.WriteLine($"\nТекущее значение: {Math.Round(currentValue, 4)}");
                Console.WriteLine($"Память: {Math.Round(memory, 4)}");
                Console.Write("Введите число или операчцию: ");
                
                string input = Console.ReadLine()?.Trim();
                
                if (string.IsNullOrEmpty(input))
                    continue;
                    
                if (input.ToUpper() == "EXIT")
                    break;
                    
                if (input.ToUpper() == "C")
                {
                    currentValue = 0;
                    continue;
                }
                
                if (IsOperation(input))
                {
                    ProcessOperation(input);
                }
                else
                {
                    if (IsValidNumber(input))
                    {
                        currentValue = Convert.ToDouble(input);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введите корректное число или операцию");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
    
    private bool IsOperation(string input)
    {
        string[] operations = { "+", "-", "*", "/", "%", "1/x", "x^2", "sqrt", "M+", "M-", "MR" };
        return Array.Exists(operations, op => op.Equals(input, StringComparison.OrdinalIgnoreCase));
    }
    
    private bool IsValidNumber(string input)
    {
        return double.TryParse(input, out _);
    }
    
    private void ProcessOperation(string operation)
    {
        switch (operation.ToLower())
        {
            case "+":
                PerformAddition();
                break;
            case "-":
                PerformSubtraction();
                break;
            case "*":
                PerformMultiplication();
                break;
            case "/":
                PerformDivision();
                break;
            case "%":
                PerformPercentage();
                break;
            case "1/x":
                PerformReciprocal();
                break;
            case "x^2":
                PerformSquare();
                break;
            case "sqrt":
                PerformSquareRoot();
                break;
            case "m+":
                MemoryAdd();
                break;
            case "m-":
                MemorySubtract();
                break;
            case "mr":
                MemoryRecall();
                break;
        }
    }
    
    private void PerformAddition()
    {
        Console.Write("Введите второе число: ");
        string input = Console.ReadLine()?.Trim();
        
        if (IsValidNumber(input))
        {
            double number = Convert.ToDouble(input);
            currentValue += number;
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число");
        }
    }
    
    private void PerformSubtraction()
    {
        Console.Write("Введите второе число: ");
        string input = Console.ReadLine()?.Trim();
        
        if (IsValidNumber(input))
        {
            double number = Convert.ToDouble(input);
            currentValue -= number;
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число");
        }
    }
    
    private void PerformMultiplication()
    {
        Console.Write("Введите второе число: ");
        string input = Console.ReadLine()?.Trim();
        
        if (IsValidNumber(input))
        {
            double number = Convert.ToDouble(input);
            currentValue *= number;
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число");
        }
    }
    
    private void PerformDivision()
    {
        Console.Write("Введите делитель: ");
        string input = Console.ReadLine()?.Trim();
        
        if (IsValidNumber(input))
        {
            double divisor = Convert.ToDouble(input);
            
            if (divisor == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно");
                return;
            }
            
            currentValue /= divisor;
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число");
        }
    }
    
    private void PerformPercentage()
    {
        Console.Write("Введите процент: ");
        string input = Console.ReadLine()?.Trim();
        
        if (IsValidNumber(input))
        {
            double percentage = Convert.ToDouble(input);
            currentValue = (currentValue * percentage) / 100;
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректное число");
        }
    }
    
    private void PerformReciprocal()
    {
        if (currentValue == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно");
            return;
        }
        
        currentValue = 1 / currentValue;
    }
    
    private void PerformSquare()
    {
        currentValue *= currentValue;
    }
    
    private void PerformSquareRoot()
    {
        if (currentValue < 0)
        {
            Console.WriteLine("Ошибка: Нельзя извлечь корень из отрицательного числа");
            return;
        }
        
        currentValue = Math.Sqrt(currentValue);
    }
    
    private void MemoryAdd()
    {
        memory += currentValue;
        Console.WriteLine($"Значение {Math.Round(currentValue, 4)} добавлено в память");
    }
    
    private void MemorySubtract()
    {
        memory -= currentValue;
        Console.WriteLine($"Значение {Math.Round(currentValue, 4)} вычтено из памяти");
    }
    
    private void MemoryRecall()
    {
        currentValue = memory;
        Console.WriteLine($"Значение {Math.Round(memory, 4)} восстановлено из памяти");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.Run();
    }
}
