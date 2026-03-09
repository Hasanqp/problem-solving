# Beecrowd Challenge 1043 - Triangle

## 📋 Problem Description
- **Problem ID:** 1043
- **Title:** Triangle  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1043)

### Problem Statement
Read three floating-point values (A, B, C) and verify if they can form a triangle. If possible, calculate the perimeter. If not, calculate the area of a trapezium with bases A and B and height C.

## 💡 Solution Approach

### Strategy
1. Read three float values (A, B, C)
2. Check triangle inequality theorem:
   - Sum of any two sides > third side
3. If triangle is possible:
   - Calculate perimeter: A + B + C
4. If triangle is not possible:
   - Calculate trapezium area: ((A + B) × C) / 2
5. Print result with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(float, input().split())` | Reads and converts three floats |
| `A + B > C` | Triangle inequality check |
| `A + C > B` | Triangle inequality check |
| `B + C > A` | Triangle inequality check |
| `A + B + C` | Calculates perimeter |
| `((A + B) * C) / 2` | Calculates trapezium area |
| `{value:.1f}` | Formats output to 1 decimal place |

## 📐 Mathematical Formulas

**Triangle Inequality Theorem:**