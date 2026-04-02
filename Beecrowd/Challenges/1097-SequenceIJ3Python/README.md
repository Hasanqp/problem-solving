# Beecrowd Challenge 1097 - Sequence IJ 3

## 📋 Problem Description
- **Problem ID:** 1097
- **Title:** Sequence IJ 3
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1097)

### Problem Statement
Print a sequence following the pattern:
- I takes odd values from 1 to 9
- For each I, J takes 3 descending values starting from I+6
- Format: `I={I} J={J}`

## 💡 Solution Approach

### Strategy
1. Outer loop: I from 1 to 9, step 2 (odd numbers only)
2. Calculate starting J value: startJ = I + 6
3. Inner loop: J from startJ down to startJ-2 (3 values)
4. Print each combination

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `for I in range(1, 10, 2):` | Outer loop for odd I values (1,3,5,7,9) |
| `startJ = I + 6` | Calculate starting J for current I |
| `for J in range(startJ, startJ - 3, -1):` | Loop through 3 descending J values |
| `print(f"I={I} J={J}")` | Print current pair |

## 📊 Sequence Pattern

| I | startJ = I+6 | J values |
|---|--------------|----------|
| 1 | 7 | 7, 6, 5 |
| 3 | 9 | 9, 8, 7 |
| 5 | 11 | 11, 10, 9 |
| 7 | 13 | 13, 12, 11 |
| 9 | 15 | 15, 14, 13 |

## ⚠️ Important Notes
- **No input** required
- **Format exactly:** `I={I} J={J}` (no spaces around =)
- **I values:** odd numbers 1, 3, 5, 7, 9 (5 values)
- **J values:** 3 values per I, starting at I+6
- **Total lines:** 5 × 3 = 15 lines
- **range(startJ, startJ - 3, -1)** generates 3 values: startJ, startJ-1, startJ-2