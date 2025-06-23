# 🐝 Artificial Bee Colony Optimization (ABC) – C# Implementation

This project implements the **Artificial Bee Colony (ABC)** algorithm from scratch using **C#**, without any external libraries or AI frameworks. The application features a Windows Forms interface for configuring parameters, running the optimization, and visualizing results.

---

## 🧠 Algorithm Overview

The **Artificial Bee Colony (ABC)** algorithm is a swarm-based optimization method inspired by the intelligent foraging behavior of honey bees. It mimics the way bees explore and exploit food sources through:

- **Employed Bees** – Search around known food sources and share information.
- **Onlooker Bees** – Choose food sources based on shared knowledge.
- **Scout Bees** – Randomly explore for new food sources.

---

## 🎯 Optimization Objective

The default objective function used in this project is the **sum of squares**:

---

##⚙️ Configurable Parameters

| Parameter         | Description                                |
| ----------------- | ------------------------------------------ |
| Food Source Count | Number of candidate solutions (bees)       |
| Limit             | Abandonment threshold for food sources     |
| Max Cycles        | Total number of iterations                 |
| Dimension         | Number of variables in the solution vector |
| Range             | Lower and upper bounds for each variable   |

---

##📌 Future Improvements
Visualization of convergence curve

Support for constraint handling

Integration of additional test functions (Rastrigin, Rosenbrock, etc.)

Save/export best solutions

---

##🪪 License
MIT License

Ahmet Burak Akbaş
