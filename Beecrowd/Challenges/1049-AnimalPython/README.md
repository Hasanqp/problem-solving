# Beecrowd Challenge 1049 - Animal

## 📋 Problem Description
- **Problem ID:** 1049
- **Title:** Animal  
- **Difficulty:** Beginner
- **Link:** [View Problem](https://judge.beecrowd.com/en/problems/view/1049)

### Problem Statement
Based on three Portuguese words describing an animal's characteristics, identify which animal it is. The words follow a hierarchical classification tree.

## 💡 Solution Approach

### Strategy
1. Read three strings representing:
   - Vertebrate/invertebrate
   - Class (bird/mammal/insect/annelid)
   - Diet type (carnivore/omnivore/hematophage/herbivore)
2. Use nested if-else statements to navigate the decision tree
3. Print the corresponding animal name

## 🔍 Code Explanation

| Component | Purpose |
|-----------|---------|
| `input()` | Reads each characteristic word |
| Nested if-else statements | Navigates classification tree |
| String comparisons | Matches input with expected values |