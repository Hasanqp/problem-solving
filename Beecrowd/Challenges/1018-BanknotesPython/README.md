# Beecrowd Challenge 1018 - Banknotes

## 📋 Problem Description
- **Problem ID:** 1018
- **Title:** Banknotes  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1018)

### Problem Statement
Read an integer value and calculate the minimum number of banknotes needed using denominations: 100, 50, 20, 10, 5, 2, 1. Print the value and the count for each banknote.

## 💡 Solution Approach

### Strategy
1. Read the integer value
2. Print the original value
3. For each banknote denomination:
   - Calculate how many notes fit
   - Update remaining value
   - Print count in Portuguese format

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Reads integer value |
| `banknotes[]` | Array of denominations in descending order |
| `currentValue / banknotes[i]` | Calculates note count |
| `currentValue %= banknotes[i]` | Updates remaining value |
| `Console.WriteLine()` | Prints in required Portuguese format |

## 🔢 Algorithm Steps

1. Start with largest denomination (100)
2. Calculate: notes = value ÷ denomination
3. Update: value = value % denomination
4. Repeat for next denomination
5. Continue until value = 0

## ⚠️ Important Notes
- **Single integer input**
- **Print original value first**
- **Exact Portuguese format:** `{quantity} nota(s) de R$ {denomination},00`
- **Denominations in order:** 100, 50, 20, 10, 5, 2, 1
- **Line break after each output**

## 🧪 Example I/O

**Input:**

## 🚀 How to Run
```bash
python solution.py