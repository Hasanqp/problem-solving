# Beecrowd Challenge 1002 - Area of a Circle

## 📋 Problem Description
- **Problem ID:** 1002
- **Title:** Area of a Circle  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1002)

### Problem Statement
Calculate the area of a circle given its radius R. Use the formula:  
**A = π × R²** and print the result with 4 decimal places in the format: `A={area}`

## 💡 Solution Approach

### Strategy
1. Read the radius value as input
2. Calculate the area using π = 3.14159
3. Print the result with 4 decimal places

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Convert.ToDouble(Console.ReadLine())` | Reads radius and converts to double |
| `3.14159 * R * R` | Calculates area using πR² formula |
| `ToString("F4")` | Formats output to 4 decimal places |
| `Console.WriteLine("A="+A.ToString("F4"))` | Outputs result in required format |

## 🚀 How to Run
```bash
C# solution.cs