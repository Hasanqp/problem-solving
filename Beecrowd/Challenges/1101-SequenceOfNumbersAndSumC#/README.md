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
4. Initialize sum to 0
5. Loop from min to max (inclusive)
6. Print each number with a space
7. Add each number to sum
8. Print "Sum={sum}" at the end of sequence

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `while (true)` | Infinite loop until break condition |
| `Console.ReadLine().Split(' ')` | Read M and N |
| `if (M <= 0 || N <= 0)` | Stop condition |
| `Math.Min(M, N)` | Find smaller value |
| `Math.Max(M, N)` | Find larger value |
| `for (int i = min; i <= max; i++)` | Loop including both ends |
| `Console.Write(i + " ")` | Print number with space |
| `sum += i` | Add to cumulative sum |
| `Console.WriteLine($"Sum={sum}")` | Print total |

## ⚠️ Important Notes
- **Multiple input pairs** until one value ≤ 0
- **Last line has** M ≤ 0 or N ≤ 0 (not processed)
- **Print in ascending order** from smaller to larger
- **Include both M and N** in sequence
- **Space after each number** before the word "Sum"
- **Format:** `X X X ... Sum=Y`