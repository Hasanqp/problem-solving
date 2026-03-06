# Beecrowd Challenge 1045 - Triangle Types

## 📋 Problem Description
- **Problem ID:** 1045
- **Title:** Triangle Types  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1045)

### Problem Statement
Read three sides of a triangle (A, B, C) and classify it based on:
- **Triangle formation:** If A ≥ B + C → "NAO FORMA TRIANGULO"
- **Angle types:**
  - A² = B² + C² → "TRIANGULO RETANGULO" (right triangle)
  - A² > B² + C² → "TRIANGULO OBTUSANGULO" (obtuse triangle)
  - A² < B² + C² → "TRIANGULO ACUTANGULO" (acute triangle)
- **Side types:**
  - All sides equal → "TRIANGULO EQUILATERO"
  - Two sides equal → "TRIANGULO ISOSCELES"

## 💡 Solution Approach

### Strategy
1. Read three double values
2. Sort in decreasing order (A ≥ B ≥ C)
3. Check if triangle is valid (A < B + C)
4. Apply angle classifications (all may apply)
5. Apply side classifications (mutually exclusive)
6. Print all applicable messages

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `CultureInfo.InvariantCulture` | Ensures correct decimal parsing |
| `Array.Sort()` + `Array.Reverse()` | Orders sides decreasing |
| `A >= B + C` | Checks if triangle is valid |
| `A * A == B * B + C * C` | Pythagorean theorem for right triangle |
| `A * A > B * B + C * C` | Obtuse triangle condition |
| `A * A < B * B + C * C` | Acute triangle condition |
| `A == B && B == C` | Equilateral check |
| `A == B \|\| A == C \|\| B == C` | Isosceles check |

## 📐 Triangle Classification Rules

**Formation Condition:**
- Triangle exists only if A < B + C

**Angle Classification (Pythagorean Theorem):**
- **Right:** A² = B² + C²
- **Obtuse:** A² > B² + C²
- **Acute:** A² < B² + C²

**Side Classification:**
- **Equilateral:** All sides equal
- **Isosceles:** Two sides equal
- **Scalene:** All sides different (no specific message)
