# Beecrowd Challenge 1006 - Average 2

## 📋 Problem Description
- **Problem ID:** 1006
- **Title:** Average 2  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1006)

### Problem Statement
Calculate the student's average with weights 2, 3, and 5 for three grades, and print the result with 1 decimal place in the format: `MEDIA = {average}`

## 💡 Solution Approach

### Strategy
1. Read three double values (grades A, B, and C)
2. Calculate weighted average: (A × 2 + B × 3 + C × 5) / 10
3. Print the result with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Convert.ToDouble(Console.ReadLine())` | Reads input and converts to double |
| `(A * 2 + B * 3 + C * 5) / 10` | Calculates weighted average |
| `ToString("F1")` | Formats output to 1 decimal place |
| `Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"))` | Outputs result in required format |

## 🚀 How to Run
```bash
C# Solution.cs