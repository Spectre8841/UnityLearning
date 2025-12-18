🎮 Unity RPG 2D – Week 1

Engine: Unity 2022.3 LTS
Genre: 2D Top-down RPG

📌 Overview

Week 1 tập trung xây dựng nền tảng gameplay cốt lõi cho một game RPG 2D, tạo ra một playable prototype với movement, combat, enemy AI và UI cơ bản.

✅ Features Implemented

Player

Di chuyển 4 hướng (Unity Input System)

Animator Idle / Walk

Sorting theo trục Y

Interaction với NPC (phím E)

Camera & Map

Cinemachine Camera + Confiner 2D

Tilemap + Collider

Combat System

Health & Damage system dùng chung cho Player / Enemy

Clamp HP, xử lý death

Event-based health update

Enemy AI

Phát hiện & đuổi player

Dừng ở khoảng cách tấn công (stop distance)

HP Bar UI

Image Filled (không dùng Slider)

Update bằng event

Fix bug sprite padding & HP không về 0

🛠️ Technical Notes

Tách biệt rõ Logic – Input – UI

Code reusable, dễ mở rộng

Fix bug theo root cause (production mindset)

🚀 Next

Enemy attack animation

Knockback & combat polish

Audio & Game Over UI
