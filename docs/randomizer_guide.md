# Randomizer Guide: Overview of existing randomizers & how to modify them

This page contains brief explanations for the various randomizers in the Unity and how to modify them to generate different synthetic data.

**Table of Contents**
- [The Unity Scene](#the-unity-scene)
    - [Simulation Scene](#simulation-scene)
    - [GameObject](#gameobject)
- [Randomizers](#randomizers)
    - [BackgroundObjectPlacementRandomizer](#backgroundobjectplacementrandomizer)
    - [TextureRandomizer](#texturerandomizer)
    - [ForegroundObjectPlacementRandomizer](#foregroundobjectplacementrandomizer)
    - [RotationRandomizer](#rotationrandomizer)
    - [MyLightRandomizer](#mylightrandomizer)
    - [ForegroundScaleRandomizer](#foregroundscalerandomizer)
      
---

Everything we've created to enable this particular Project lives inside the Assets folder, which you can locate in the Project Browser panel.

## The Unity Scene
We have made one example scene called `OutdoorsScene`. You can create your own scene, but it is recommended that you understand this scene first.  

![image](https://github.com/user-attachments/assets/219d1921-848f-465a-a336-b3d1882cda99)


### Simulation Scene
![image](https://github.com/user-attachments/assets/e9ce1bb2-5d8a-4203-802b-65a28237b43f)

The Simulation Scene has a few randomizers:
- [BackgroundObjectPlacementRandomizer](#backgroundobjectplacementrandomizer). Randomize the shape of seabed during synthetic data generation.
- [TextureRandomizer](#texturerandomizer). Randomize the seabed during synthetic data generation.
- [ForegroundObjectPlacementRandomizer](#foregroundobjectplacementrandomizer). Randomize the pictures of brittle stars during synthetic data generation.
- [RotationRandomizer](#rotationrandomizer). Randomize the angle of brittle stars picture during synthetic data generation.
- [MyLightRandomizer](#mylightrandomizer). Randomize the direction of light during synthetic data generation.
- [ForegroundScaleRandomizer](#foregroundscalerandomizer). Randomize the size of brittle stars pictures during synthetic data generation.


### GameObject
![image](https://github.com/user-attachments/assets/625e5f5b-b7ff-410d-b02b-4a1848f63072)

This game object has a volume with `Motion Blur` attached to it. It is created to avoid motion blur when the refresh rate that are set is too high.

> Note: For more information, please refer to the [Unity Perception Tutorial](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation~/Tutorial/Phase1.md)

### Randomizers
The randmoizers are implemented here in order to generate various combinations of brittle stars layouts with different seabeds.
> Note: For proper setup guide of randomizers, please refer to the [Unity Perception Tutorial 1](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation~/Tutorial/Phase1.md) and [Unity Perception Tutorial 2](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation~/Tutorial/Phase2.md)

### BackgroundObjectPlacementRandomizer
![image](https://github.com/user-attachments/assets/c9ea983a-9230-47a9-9c8c-912ff52e7e7a)
