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
- [BackgroundObjectPlacementRandomizer](#backgroundobjectplacementrandomizer). Spawn different shapes (cubes, cylinderd, spheres etc.) during synthetic data generation.
- [TextureRandomizer](#texturerandomizer). Allocate random seabed images to the shapes during synthetic data generation.
- [ForegroundObjectPlacementRandomizer](#foregroundobjectplacementrandomizer). Spawn random pictures of brittle stars during synthetic data generation.
- [RotationRandomizer](#rotationrandomizer). Randomize the angle of background objects during synthetic data generation.
- [MyLightRandomizer](#mylightrandomizer). Randomize the color and brightness of light during synthetic data generation.
- [ForegroundScaleRandomizer](#foregroundscalerandomizer). Randomize the size of brittle stars pictures during synthetic data generation.


### GameObject
![image](https://github.com/user-attachments/assets/625e5f5b-b7ff-410d-b02b-4a1848f63072)

This game object has a volume with `Motion Blur` attached to it. It is created to avoid motion blur when the refresh rate that are set is too high.

> Note: For more information, please refer to the [Unity Perception Tutorial](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation~/Tutorial/Phase1.md)

## Scenario Properties
![image](https://github.com/user-attachments/assets/d4954376-72f5-49b4-b8ee-11733b258bdb)

This component will controll the number of frames taken for each iteration and the number of iteration.
> Note: Iteration means different combination and permutation of brittle stars with different background.
- **🟢 Action**: Set the rest of the properties of `Frames Per Iteration` and `Iteration Count` according to your preferences. The parameters we used is `Frames Per Iteration = 3, Iteration Count = 250`. This means that for each iteration, 3 frames will be taken and 250 sets of data with different randomizer combinations will be generated. 
  
## Randomizers
The randomizers are implemented here in order to generate various combinations of brittle stars layouts with different seabeds.
> Note: For proper setup guide of randomizers, please refer to the [Unity Perception Tutorial 1](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation~/Tutorial/Phase1.md) and [Unity Perception Tutorial 2](https://github.com/Unity-Technologies/com.unity.perception/blob/main/com.unity.perception/Documentation~/Tutorial/Phase2.md)

### BackgroundObjectPlacementRandomizer
![image](https://github.com/user-attachments/assets/c9ea983a-9230-47a9-9c8c-912ff52e7e7a)

This randomizer will scatter different shapes at the background of the camera view to act as chaotic background. Here, we are using the Prefabs provided in the sample folder of perception.
- **🟢 Action**: Click _**Add Folder**_, and from the file explorer window that opens, choose the folder which prefabs needed are stored. In this project, we use the sample prefabs in `Assets/Samples/Perception/<Perception Package Version>/Tutorial Files/Background Objects/Prefabs`.
- **🟢 Action**: Set the rest of the properties of `Depth`, `Layer Count`, `Separation Distance` and `Placement Area` according to your preferences. The parameters we used is  `Depth = 0, Layer Count = 2, Separation Distance = 0.7, Placement Area = (8,8)`.
The `Separation Distance` will define how crowded the prefabs of seabed are, while `Placement Area` will control the area of where prefabs of seabed will be scattered.

### TextureRandomizer
![image](https://github.com/user-attachments/assets/b4aa4bdc-fd6e-4309-8863-24245663dd7f)

This randomizer will render the seabed pictures onto the background shapes that we scatter with **_BackgroundObjectPlacementRandomizer_**.
- **🟢 Action**: Click _**Add Folder**_, and from the file explorer window that opens, choose the folder which seabed pictures needed are stored. In this project, we use the images in `Assets\Background\Images`.

### ForegroundObjectPlacementRandomizer
![image](https://github.com/user-attachments/assets/9c5b605c-2f58-45a2-92a5-ad45c13409a5)

This randomizer will put the pictures of brittle stars scatter randomly in the camera view.
- **🟢 Action**: Click _**Add Folder**_, and from the file explorer window that opens, choose the folder which brittle star planes needed are stored. In this project, we use the prefabs in `Assets/Ophiorpidea/Prefabs`.
- **🟢 Action**: Set the rest of the properties of `Depth`, `Layer Count`, `Separation Distance` and `Placement Area` according to your preferences. The parameters we used is  `Depth = -3, Separation Distance = 1, Placement Area = (8,4)`.
The `Separation Distance` will define how crowded the prefabs of brittle stars are, while `Placement Area` will control the area of where prefabs of brittle stars will be scattered.

### RotationRandomizer
![image](https://github.com/user-attachments/assets/f2d065aa-3384-4def-a0c9-6b817d0c9301)

This randomizer will flip the background objects, so usually this randomizer will be put above the **_ForegroundObjectPlacementRandomizer_**.
- **🟢 Action**: In the UI snippet for `RotationRandomizer`, verify that all the minimum values for the three ranges are `-10` and that maximum values are `10`.
If the rotation angle is too large, it will make the brittle stars look thinner, harder to be recoginized.

### MyLightRandomizer
![image](https://github.com/user-attachments/assets/218569a3-6acc-4d2f-93b2-022d1dce0d28)

This randomizer will change the color and brightness of light in camera view.
- **🟢 Action**: In the UI snippet for `MyLightRandomizer`, verify that `Light Intensity = (0,2), Temperature = (3000,16000)`.

### ForegroundScaleRandomizer
![image](https://github.com/user-attachments/assets/44bb3912-d2a1-4062-9cd1-bb8af2e4edb9)

This randomizer will stimulate the size of brittle stars in the camera view.
- **🟢 Action**: In the UI snippet for `ForegroundScaleRandomizer`, verify that `X = (0.02,0.08), Y = (0.01,0.1), Z = (0.02,0.08)`.



