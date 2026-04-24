# Beecrowd Challenge 1113 - Ascending and Descending

## 📋 Problem Description
- **Problem ID:** 1113
- **Title:** Ascending and Descending
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1113)

### Problem Statement
Read pairs of integer values until X equals Y. For each pair, print "Crescente" if the numbers are in ascending order (X < Y), otherwise print "Decrescente" (X > Y).

## 💡 Solution Approach

### Strategy
1. Read pairs in an infinite loop
2. If X == Y, break the loop (this pair is not processed)
3. If X < Y, print "Crescente" (ascending)
4. If X > Y, print "Decrescente" (descending)

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `while True:` | Infinite loop until break condition |
| `map(int, input().split())` | Read and convert X and Y |
| `if X == Y:` | Stop condition (X equals Y) |
| `break` | Exit the loop |
| `if X < Y:` | Check if ascending |
| `print("Crescente")` | Print ascending message |
| `else:` | X must be greater than Y |
| `print("Decrescente")` | Print descending message |

## ⚠️ Important Notes
- **Multiple input pairs** until X equals Y
- **Stop condition:** X == Y (this pair is NOT processed/output)
- **No output for equal numbers** (breaks before printing)
- **Portuguese messages:**
  - "Crescente" = ascending
  - "Decrescente" = descending
- **Input can be any number of lines**

## 🚀 How to Run
```bash
python solution.py