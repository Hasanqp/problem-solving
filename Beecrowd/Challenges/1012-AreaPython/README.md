# Beecrowd Challenge 1012 - Area

## 📋 Problem Description
- **Problem ID:** 1012
- **Title:** Area  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1012)

### Problem Statement
Read three floating point values (A, B, C) and calculate five different geometric areas, printing each with 3 decimal places.

## 💡 Solution Approach

### Strategy
1. Read three float values from a single line
2. Calculate five areas using geometric formulas
3. Print each result in the exact Portuguese format

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `input().split()` | Splits input into three values |
| `float()` | Converts string values to float |
| Geometric formulas | Calculate five different areas |
| `{value:.3f}` | Formats output to 3 decimal places |

## 📐 Geometric Formulas

| Shape | Formula | Variables |
|-------|---------|-----------|
| Triangle | `(A * C) / 2` | base = A, height = C |
| Circle | `3.14159 * C * C` | radius = C, π = 3.14159 |
| Trapezium | `(A + B) * (C / 2)` | bases = A, B, height = C |
| Square | `B * B` | side = B |
| Rectangle | `A * B` | sides = A, B |

## ⚠️ Important Notes
- **Single line input:** all three values on one line
- **Portuguese labels:** TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO
- **Three decimal places** mandatory
- **Exact format:** `LABEL: {value}` with one space after colon

## 🚀 How to Run
```bash
python solution.py