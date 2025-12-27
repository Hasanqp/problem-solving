# Beecrowd Challenge 1036 - Bhaskara's Formula

## 📋 Problem Description
- **Problem ID:** 1036
- **Title:** Bhaskara's Formula  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1036)

### Problem Statement
Read three floating-point numbers (A, B, C) and calculate the roots of the quadratic equation using Bhaskara's formula. If calculation is impossible (division by zero or negative square root), print "Impossivel calcular".

## 💡 Solution Approach

### Strategy
1. Read three double values (A, B, C)
2. Calculate discriminant: Δ = B² - 4AC
3. Check for impossible cases:
   - A = 0 (division by zero)
   - Δ < 0 (square root of negative)
4. Calculate roots if possible
5. Print roots with 5 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Console.ReadLine().Split(' ')` | Splits input into three values |
| `double.Parse()` | Converts string to double |
| `Math.Pow(B, 2)` | Calculates B² |
| `4 * A * C` | Calculates 4AC |
| `Math.Sqrt(delta)` | Calculates square root of Δ |
| `(A == 0 || delta < 0)` | Checks impossible cases |
| `ToString("F5")` or `:F5` | Formats output to 5 decimal places |

 
## 🚀 How to Run
```bash
C# Solution.cs