# SHIVR

## Subtle Haptics in Virtual Reality (SHIVR)


SHIVR is an innovative SDK that empowers developers to integrate vibrotactile haptic feedback with Ultraleap hand tracking for refined, subtle hand interactions within Virtual Reality (VR) environments. SHIVR is designed to elevate VR experiences, providing users with a deeper sense of immersion and engagement through nuanced tactile sensations.

![SHIVR image](https://github.com/user-attachments/assets/15769e5c-746b-4dc0-9b4f-c5c8e25eebcf)



## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Technology Stack](#technology-stack)
- [Installation](#installation)
- [Usage](#usage)
- [Development Process](#development-process)
- [Challenges and Solutions](#challenges-and-solutions)
- [Future Work](#future-work)
- [Team](#team)
- [Demo and Showcase](#demo-and-showcase)

## Overview

<table>
  <tr>
    <td>
      SHIVR enhances the VR landscape by incorporating subtle haptic feedback into hand-tracking interactions. This innovation enriches the realism of VR environments and boosts user engagement by seamlessly blending tactile sensations with natural hand gestures.
    </td>
    <td>
      <img src="https://github.com/leonkoech/SHIVR-SDK/assets/39020723/e149a019-6ff6-4d39-8f8d-32ad64bebecd" alt="Unity interface" width="500px">
    </td>
  </tr>
</table>

## Features

- **Precise Hand Tracking**: Utilizes Ultraleap technology for detailed hand gesture recognition.
- **Vibrotactile Haptics**: Implements ESP32 and vibration sensors for nuanced haptic feedback.
- **Seamless Integration**: Compatible with Unity and various VR platforms.
- **Enhanced Realism**: Provides subtle feedback to improve interactivity and immersion.

## Technology Stack

- **Hardware**:
<table>
  <tr>
    <td>
    <ul>
    <li>Ultraleap hand tracking device</li>
   <li>ESP32 microcontroller</li>
   <li>Arduino Uno (for specific prototyping purposes)</li>
    </ul>
    </td>
    <td>
      <img src="https://github.com/leonkoech/SHIVR-Hardware/assets/39020723/e920845b-a6e6-4082-a98e-5a6693d505b5" alt="Unity interface" width="500px">
    </td>
  </tr>
</table>

- **Software**:
  - Development Platform: Unity
  - SDKs and Tools: Custom-built algorithms for haptic response, integration support for Oculus
- **Operating System**: Compatible with various platforms supporting Unity

## Installation

1. Set up your VR hardware, including Ultraleap and ESP32 connections.
2. Clone the SHIVR repository to your local system.
3. Open the project in Unity.
4. Connect ESP32 and load the firmware using Arduino IDE as necessary.
5. Import the required hand tracking SDKs and custom SHIVR scripts.
6. Build and run the project on your VR platform.

## Usage

1. Launch the SHIVR-enabled application in Unity.
2. Use Ultraleap-enabled hand gestures to interact within the VR environment.
3. Experience subtle haptic feedback that adjusts based on hand movements and interactions.
4. Modify or customize the feedback settings through Unity for tailored user experiences.

## Development Process

1. **Conceptualization**: Identified the need for subtle, vibrotactile feedback to complement visual and auditory VR cues.
2. **Prototyping**: Developed initial hand-tracking modules with haptic integration using ESP32 and vibration sensors.
3. **Integration and Testing**: Refined haptic feedback synchronization to ensure fluid, responsive interactions in VR.
4. **User Testing**: Collaborated with testers to gather insights and adjust feedback frequency for maximum effectiveness.

## Challenges and Solutions

| Challenge | Solution |
|-----------|----------|
| Synchronizing hand tracking with feedback | Optimized response algorithms for real-time interaction |
| Ensuring seamless feedback integration | Leveraged ESP32 firmware customization |
| Limited access to hardware during testing | Utilized simulations and virtual testing environments |

## Future Work

- Enhancing compatibility with more VR platforms.
- Introducing adaptive feedback for various hand gestures.
- Expanding applications for training simulations and interactive VR storytelling.
- Adding customizable user settings for haptic intensity.

## Team
<img src="https://github.com/user-attachments/assets/6ddc95b3-94b9-41f6-8e2e-1dd01ef391e9" alt="project overview" width="600px">


This project received the 'Best use of hardware' award at [Immerse The Bay](https://immersethebay.stanfordxr.org/) at Stanford University 2023 organized by [Stanford XR Club](https://www.stanfordxr.org/about)

It was made possible by the collaboration and expertise of the SHIVR team, dedicated to enhancing VR through the intersection of tactile feedback and cutting-edge technology.


