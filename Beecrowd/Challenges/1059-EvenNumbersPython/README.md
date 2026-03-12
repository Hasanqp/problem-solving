# Beecrowd Challenge 1059 - Even Numbers

## 📋 Problem Description
- **Problem ID:** 1059
- **Title:** Even Numbers  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1059)

### Problem Statement
Print all even numbers between 1 and 100, inclusive.

## 💡 Solution Approach

### Strategy
1. Start from 2 (first even number)
2. Increment by 2 each time using range step
3. Continue until 100
4. Print each number on a new line

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `range(2, 101, 2)` | Generates numbers from 2 to 100 with step 2 |
| `for i in range(...)` | Iterates through each even number |
| `print(i)` | Prints each even number on new line |
