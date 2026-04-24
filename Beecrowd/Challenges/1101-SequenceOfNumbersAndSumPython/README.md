# Beecrowd Challenge 1101 - Sequence of Numbers and Sum

## 📋 Problem Description
- **Problem ID:** 1101
- **Title:** Sequence of Numbers and Sum
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1101)

### Problem Statement
Read pairs of integers M and N until any value is ≤ 0. For each pair, print:
- All consecutive integers from smallest to largest (inclusive)
- The sum of all these integers

## 💡 Solution Approach

### Strategy
1. Read pairs in an infinite loop
2. If M ≤ 0 or N ≤ 0, break the loop
3. Determine min and max values
4. Generate list of numbers from min to max
5. Calculate sum of all numbers
6. Print numbers separated by spaces followed by "Sum={total}"

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `while True:` | Infinite loop until break condition |
| `map(int, input().split())` | Read and convert M and N |
| `if M <= 0 or N <= 0:` | Stop condition |
| `min(M, N)` | Find smaller value |
| `max(M, N)` | Find larger value |
| `range(min_val, max_val + 1)` | Generate sequence (inclusive) |
| `list(range(...))` | Convert to list of numbers |
| `sum(numbers)` | Calculate total |
| `' '.join(map(str, numbers))` | Create space-separated string |
| `print(f"{...} Sum={total}")` | Output sequence and sum |

## ⚠️ Important Notes
- **Multiple input pairs** until one value ≤ 0
- **Last line has** M ≤ 0 or N ≤ 0 (not processed)
- **Print in ascending order** from smaller to larger
- **Include both M and N** in sequence
- **No trailing space** before "Sum" (join handles it)
- **Format:** `X X X ... Sum=Y`