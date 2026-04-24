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
2. If X == Y, break the loop
3. If X < Y, print "Crescente" (ascending)
4. If X > Y, print "Decrescente" (descending)

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `while (true)` | Infinite loop until break condition |
| `Console.ReadLine().Split(' ')` | Read and split X and Y |
| `int.Parse()` | Convert strings to integers |
| `if (X == Y)` | Stop condition |
| `if (X < Y)` | Check if ascending |
| `Console.WriteLine("Crescente")` | Print ascending message |
| `Console.WriteLine("Decrescente")` | Print descending message |

## ⚠️ Important Notes
- **Multiple input pairs** until X equals Y
- **Stop condition:** X == Y (this pair is NOT processed)
- **No output for equal numbers** (breaks before printing)
- **Portuguese messages:**
  - "Crescente" = ascending
  - "Decrescente" = descending

  ## 🚀 How to Run
```bash
dotnet run