# Beecrowd Challenge 1040 - Average 3

## 📋 Problem Description
- **Problem ID:** 1040
- **Title:** Average 3  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1040)

### Problem Statement
Read four grades (N1, N2, N3, N4) with weights 2, 3, 4, and 1 respectively. Calculate the weighted average. If the average is:
- ≥ 7.0: "Aluno aprovado."
- < 5.0: "Aluno reprovado."
- Between 5.0 and 6.9: "Aluno em exame." Read exam grade and recalculate final average.

## 💡 Solution Approach

### Strategy
1. Read four grades as floats
2. Calculate weighted average: (N1×2 + N2×3 + N3×4 + N4×1) / 10
3. Print average with 1 decimal place
4. Check conditions and print appropriate messages
5. If in exam, read exam grade and calculate final average

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `map(float, input().split())` | Reads and converts four grades |
| `(n1*2 + n2*3 + n3*4 + n4) / 10` | Weighted average calculation |
| `{media:.1f}` | Formats average to 1 decimal place |
| `if media >= 7.0` | Approved condition |
| `elif media < 5.0` | Failed condition |
| `else` | Exam condition (5.0 to 6.9) |
| `(media + exam) / 2` | Final average calculation |

## 📊 Grade Weights

| Grade | Weight |
|-------|--------|
| N1 | 2 |
| N2 | 3 |
| N3 | 4 |
| N4 | 1 |
| **Total** | **10** |

## ⚠️ Important Notes
- **Single line input** for four grades
- **1 decimal place** in all outputs
- **Portuguese messages** exactly as shown
- **Exam case:** read extra grade and recalculate
- **Ternary operator:** `"Aprovado" if final >= 5.0 else "Reprovado"`
