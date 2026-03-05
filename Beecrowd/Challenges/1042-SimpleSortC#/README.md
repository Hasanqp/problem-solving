# Beecrowd Challenge 1042 - Simple Sort

## 📋 Problem Description
- **Problem ID:** 1042
- **Title:** Simple Sort  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1042)

### Problem Statement
Read three integers, sort them in ascending order, and print them. Then print a blank line, followed by the original values in the order they were read.

## 💡 Solution Approach

### Strategy
1. Read three integers
2. Store original values in an array
3. Create a copy and sort it
4. Print sorted values (each on new line)
5. Print blank line
6. Print original values (each on new line)

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `CultureInfo.InvariantCulture` | Ensures correct parsing |
| `int[] original = { a, b, c }` | Stores values in read order |
| `int[] sorted = { a, b, c }` | Creates copy for sorting |
| `Array.Sort(sorted)` | Sorts array in ascending order |
| `foreach` loops | Prints values line by line |
| `Console.WriteLine()` | Blank line between outputs |

## ⚠️ Important Notes
- **Single line input** with three integers
- **Two sets of output:** sorted then original
- **Blank line** between the two sets
- **Each number on its own line**
- **Use `Array.Sort()`** for easy sorting