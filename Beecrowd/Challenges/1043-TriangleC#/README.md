# Beecrowd Challenge 1043 - Triangle

## 📋 Problem Description
- **Problem ID:** 1043
- **Title:** Triangle  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1043)

### Problem Statement
Read three floating-point values (A, B, C) and determine if they form a valid triangle. If they do, calculate the perimeter. If not, calculate the area of the trapezium with bases A and B and height C.

## 💡 Solution Approach

### Strategy
1. Read three float values (A, B, C)
2. Check triangle inequality theorem
3. If valid triangle: calculate perimeter = A + B + C
4. If not: calculate trapezium area = ((A + B) × C) / 2
5. Print result with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `CultureInfo.InvariantCulture` | Ensures correct decimal parsing |
| `A + B > C && A + C > B && B + C > A` | Triangle inequality check |
| `A + B + C` | Perimeter calculation |
| `((A + B) * C) / 2.0` | Trapezium area calculation |
| `ToString("F1", CultureInfo.InvariantCulture)` | Formats output to 1 decimal place |

## 📐 Triangle Inequality Theorem

A valid triangle must satisfy:
- A + B > C
- A + C > B
- B + C > A

If all conditions are true → Triangle
Otherwise → Trapezium
