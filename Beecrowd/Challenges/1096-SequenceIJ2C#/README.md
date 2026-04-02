# Beecrowd Challenge 1096 - Sequence IJ 2

## 📋 Problem Description
- **Problem ID:** 1096
- **Title:** Sequence IJ 2
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1096)

### Problem Statement
Print a sequence following the pattern:
- I takes odd values from 1 to 9
- For each I, J takes values 7, 6, 5 (descending)
- Format: `I={I} J={J}`

## 💡 Solution Approach

### Strategy
1. Outer loop: I from 1 to 9, step 2 (odd numbers only)
2. Inner loop: J from 7 down to 5 (descending)
3. Print each combination
4. Repeat for each I value

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `for (int I = 1; I <= 9; I += 2)` | Outer loop for odd I values (1,3,5,7,9) |
| `for (int J = 7; J >= 5; J--)` | Inner loop for J values (7,6,5) |
| `Console.WriteLine($"I={I} J={J}")` | Print current pair |

## 📊 Sequence Pattern

| I | J values |
|---|----------|
| 1 | 7, 6, 5 |
| 3 | 7, 6, 5 |
| 5 | 7, 6, 5 |
| 7 | 7, 6, 5 |
| 9 | 7, 6, 5 |

## ⚠️ Important Notes
- **No input** required
- **Format exactly:** `I={I} J={J}` (no spaces around =)
- **I values:** odd numbers 1, 3, 5, 7, 9 (5 values)
- **J values:** 7, 6, 5 (3 values per I)
- **Total lines:** 5 × 3 = 15 lines