# Beecrowd Challenge 1035 - Selection Test 1

## 📋 Problem Description
- **Problem ID:** 1035
- **Title:** Selection Test 1  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1035)

### Problem Statement
Read four integer values (A, B, C, D) and check if they satisfy all these conditions:
1. B is greater than C
2. D is greater than A  
3. Sum of C and D is greater than sum of A and B
4. C and D are positive
5. A is even
If all conditions are met, print "Valores aceitos", otherwise print "Valores nao aceitos"

## 💡 Solution Approach

### Strategy
1. Read four integers in a single line
2. Check all six conditions using logical AND (&&)
3. Print appropriate Portuguese message based on result

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `Console.ReadLine().Split(' ')` | Splits input into four values |
| `int.Parse()` | Converts string to integer |
| `B > C` | Condition 1: B greater than C |
| `D > A` | Condition 2: D greater than A |
| `(C + D) > (A + B)` | Condition 3: Sum comparison |
| `C > 0 && D > 0` | Condition 4: C and D positive |
| `A % 2 == 0` | Condition 5: A is even |
| `Console.WriteLine()` | Prints Portuguese result |

## ⚠️ Important Notes
- **Single line input** with four integers
- **All conditions must be true** (logical AND)
- **Portuguese output:** "Valores aceitos" or "Valores nao aceitos"
- **Check both C and D are positive**
- **A must be even** (divisible by 2)

 
## 🚀 How to Run
```bash
C# Solution.cs