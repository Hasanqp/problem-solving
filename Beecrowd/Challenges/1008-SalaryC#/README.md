# Beecrowd Challenge 1008 - Salary

## 📋 Problem Description
- **Problem ID:** 1008
- **Title:** Salary  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1008)

### Problem Statement
Calculate an employee's salary based on their employee number, hours worked, and hourly rate. Print the employee number and salary with 2 decimal places.

## 💡 Solution Approach

### Strategy
1. Read employee number, hours worked, and hourly amount
2. Calculate salary: hours worked × hourly amount
3. Print employee number and salary in required format

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Convert.ToInt32(Console.ReadLine())` | Reads integer inputs |
| `Convert.ToDouble(Console.ReadLine())` | Reads double input for amount |
| `amount * workhours` | Calculates total salary |
| `ToString("F2")` | Formats salary to 2 decimal places |

## 🚀 How to Run
```bash
C# Solution.cs