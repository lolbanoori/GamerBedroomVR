# 🎮 GamerBedroomVR

A virtual reality recreation of a real-world gamer-themed bedroom, built using **Unity 6 (6000.0.46f1)** with **URP** and **OpenXR Plugin**. Designed for full immersion with real-world scale and layout.

---

## 🛠 Platform & XR Setup

- **Engine**: Unity 6.0.0 (VR Core Template)
- **Render Pipeline**: Universal Render Pipeline (URP)
- **XR Setup**: OpenXR Plugin  
  - ✅ **Mock HMD Loader Enabled** (for headset-free testing)

---

## 🧾 Project Description

This project simulates a gamer bedroom in virtual reality. Features include:

- Loft bed layout  
- Dual desk setup (gaming + work)  
- Custom staircase  
- Built-in shelving  
- TV area with animated screen  
- Volumetric LED light strips with breathing animation  
- Environmental audio sources (roomtone, AC, TV audio)  
- Real-world scale and proportions for immersive exploration  

All 3D objects are manually positioned, textured, and organized to match the intended room design.

---

## 📦 Instructions

1. Clone or download the repository.
2. Open in **Unity 6.0.0** using the **VR Core Template with URP**.
3. Open the main scene: `Assets/Scenes/GamerBedroom.unity`
4. Enter **Play Mode** to explore the room.

---

## 🕶️ Testing Without a Headset

> Mock HMD is enabled for VR simulation without a headset.

- Simply press Play to simulate VR camera movement.
- Great for peer reviews and setups without an HMD.

📺 **Watch setup guide**:  
[Mock HMD Tutorial](https://www.youtube.com/watch?v=MytUA33WhFI&t=51s)

---

## 🔊 Audio Features

- **Roomtone** ambient audio for immersion  
- **AC unit** sound effect positioned for spatial realism  
- **TV** audio synced with animated video texture  
- Audio sources configured with 3D spatial blending  

---

## 💡 Visual Enhancements

- **Global illumination** baked for static lighting realism  
- **Volumetric LED strips** animated using material-based breathing effect  
- Synced animation across all strip segments using shared controller  

---

## 💻 Hardware Requirements

| Component          | Requirement                              |
|--------------------|-------------------------------------------|
| Engine             | Unity 6.0.0 with URP & XR Plugins         |
| OS                 | Windows/macOS/Linux                       |
| GPU                | Any capable of running Unity              |
| Headset (Optional) | OpenXR-compatible (Quest 2, HTC Vive, etc.) |

---

## ⚠️ Known Issues

- **Pink materials** may appear on load. Fix via: [Fix Guide](https://youtu.be/8MplcYrkwqU?si=kKJ1MBCx6E6g5hMl)  
- **Red XR Rig error**: Delete and re-add from the **Assets** folder  
- **Falling through walls**: Avoid exiting room bounds; some colliders may fail due to Unity 6 physics quirks  

---

## 🎯 Final Objective

This project will evolve into a fully immersive virtual environment targeted for **Meta Quest** devices, with full interaction, lighting, animation, and spatial audio in future versions.

---
