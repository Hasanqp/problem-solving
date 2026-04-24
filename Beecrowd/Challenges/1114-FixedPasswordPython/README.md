# Beecrowd Challenge 1114 - Fixed Password

## 📋 Problem Description
- **Problem ID:** 1114
- **Title:** Fixed Password
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1114)

### Problem Statement
Keep reading passwords until the correct one (2002) is entered. For each wrong password, print "Senha Invalida". When the correct password is entered, print "Acesso Permitido" and terminate the program.

## 💡 Solution Approach

### Strategy
1. Read passwords in an infinite loop
2. If password equals 2002, print "Acesso Permitido" and break
3. Otherwise, print "Senha Invalida" and continue reading

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `while True:` | Infinite loop until correct password |
| `int(input())` | Read password as integer |
| `if password == 2002:` | Check if password is correct |
| `print("Acesso Permitido")` | Print success message |
| `break` | Exit the loop |
| `else:` | Incorrect password case |
| `print("Senha Invalida")` | Print error message |

## ⚠️ Important Notes
- **Multiple attempts** allowed until correct password
- **Correct password:** 2002
- **Portuguese messages:**
  - "Senha Invalida" = Invalid password
  - "Acesso Permitido" = Access granted
- **Terminates only** when password matches
- **Case and spelling must be exact**

## 🚀 How to Run
```bash
python solution.py