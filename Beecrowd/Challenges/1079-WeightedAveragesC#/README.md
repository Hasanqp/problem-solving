# Beecrowd Challenge 1079 - Weighted Averages

## 📋 Problem Description
- **Problem ID:** 1079
- **Title:** Weighted Averages
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1079)

### Problem Statement
Read N test cases. For each test case, read three floating-point numbers and calculate the weighted average with weights 2, 3, and 5 respectively.

## 💡 Solution Approach

### Strategy
1. Read N (number of test cases)
2. Loop N times
3. For each test case, read three numbers
4. Calculate weighted average: (A×2 + B×3 + C×5) / 10
5. Print result with 1 decimal place

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `int.Parse(Console.ReadLine())` | Read N value |
| `Console.ReadLine().Split(' ')` | Split input into three values |
| `double.Parse()` with `CultureInfo.InvariantCulture` | Parse numbers with decimal point |
| `(A*2 + B*3 + C*5) / 10.0` | Weighted average formula |
| `ToString("F1")` | Format to 1 decimal place |