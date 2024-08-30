# BARM 👥

## Description

`Build And Run Multiplayer` is an editor script for Unity that simplifies the process of building and running multiple instances of a multiplayer game. It allows developers to quickly configure a build for multiple players, generating separate executables for each player instance.

## Features

- Simple user interface in the Unity editor window to set the number of players.
- Automatic generation of Windows 64-bit executables for each player.
- Streamlined build and run process for multiplayer testing from a single action.
- Alternative to [ParrelSync](https://github.com/VeriorPies/ParrelSync)

## Supported Versions

This project is compatible with the following Unity versions:

- Unity 2023.X
- Unity 2022.X
- Unity 2021.X

Please ensure you are using a compatible version of Unity to avoid compatibility issues.

## Installation

1. Download the `.unitypackage` file from the [Releases](https://github.com/MisterIdle/BARM_Unity_Package/releases) section of the GitHub repository.

2. Open your Unity project.

3. Import the `.unitypackage` file by going to `Assets > Import Package > Custom Package...` and selecting the downloaded file.

4. After importing, you will find the `Build And Run Multiplayer` under the `File` menu in Unity, labeled as `Build And Run Multiplayer`.

## Usage

1. Open `Build And Run Multiplayer` by selecting `File > Build And Run Multiplayer` from the Unity menu.

2. In the window that opens, use the slider to set the desired number of players (between 2 and 16).

3. Click the `Build and Run` button to start the build and run process. Executables will be created in the `Builds/Win64` directory of your Unity project.

## Support

For any questions or issues, please check the [Issues](https://github.com/MisterIdle/BARM_Unity_Package/issues) section of the GitHub repository or open a new support request.

Thank you for using `Build And Run Multiplayer` to streamline your multiplayer build process!
