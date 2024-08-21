## Install the Unity Editor

After installing Unity Hub, you can install the Unity Editor. You should download versions 2022 and above.

## Cloning the Project

Prerequisite: you need to [install Git-LFS](https://docs.github.com/en/repositories/working-with-files/managing-large-files/installing-git-large-file-storage)

You can clone the project with the following command:
For Ubuntu:
```bash
GIT_CLONE_PROTECTION_ACTIVE=false git clone https://github.com/NTU-Mecatron/UnitySim.git
```
For Window:
```bash
set GIT_CLONE_PROTECTION_ACTIVE=false 
git clone https://github.com/NTU-Mecatron/UnitySim.git
```

## Opening the Project

In the Unity Hub, click on the `Add` button and navigate to the project folder. Select the folder and click on the `Open` button. The project should now appear in the Unity Hub.

After opening the project, navigate to the `Assets/Scenes` folder. As of now there is only one scene in the project, `OutdoorsScene`. Double click on the scene to open it.

![image](https://github.com/user-attachments/assets/4a662bd5-343a-40a9-ae2b-1ae07316df5a)

## Configuring the external Script Editor

You can either use Microsoft Visual Studio or Visual Studio Code as the script editor. Common steps for setting up:  

1. Window -> Package Manager. In the top left corner, select `Unity Registry` from the Packages drop-down menu. Install both the `Visual Studio Code Editor` and `Visual Studio Editor` packages.

2. Edit -> Preferences -> External Tools. Set the External Script Editor to the desired editor.

## Running the project
- Click the play button at the top of the unity scene.
- Open **Edit -> Project Settings -> Perception**, this will bring uo the **_Perception Settings_** pane. Click _**Show Folder**_ to show where the data is stored.
- To generate dataset accepted for YOLO training, run the command below to change each solo folder to coco dataset.
```bash
solo2coco <SOLO_PATH> <COCO_PATH>
```
Prerequisite: you need to setup Pysolotools by referring the guide [here](https://docs.unity3d.com/Packages/com.unity.perception@1.0/manual/Tutorial/convert_to_coco.html)

