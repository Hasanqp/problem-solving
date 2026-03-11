# Beecrowd Challenge 1052 - Month

## 📋 Problem Description
- **Problem ID:** 1052
- **Title:** Month  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1052)

### Problem Statement
Read an integer between 1 and 12 and print the corresponding month name in English with the first letter uppercase.

## 💡 Solution Approach

### Strategy
1. Read an integer representing the month number
2. Use an array with month names in order
3. Access array using index (month - 1) for zero-based indexing
4. Print the month name

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Reads integer month number |
| `string[] months = { "January", "February", ... }` | Array of month names in order |
| `months[month - 1]` | Accesses month name (adjust for zero-based index) |
| `Console.WriteLine()` | Outputs the month name |

## 📅 Month Mapping

| Number | Array Index | Month Name |
|--------|-------------|------------|
| 1 | 0 | January |
| 2 | 1 | February |
| 3 | 2 | March |
| 4 | 3 | April |
| 5 | 4 | May |
| 6 | 5 | June |
| 7 | 6 | July |
| 8 | 7 | August |
| 9 | 8 | September |
| 10 | 9 | October |
| 11 | 10 | November |
| 12 | 11 | December |

## ⚠️ Important Notes
- **Single integer input** between 1 and 12
- **Array approach** is concise and efficient
- **Zero-based indexing** requires `month - 1`
- **First letter uppercase** as stored in array
- **No error handling needed** (input guaranteed valid)
- **English month names** exactly as specified
