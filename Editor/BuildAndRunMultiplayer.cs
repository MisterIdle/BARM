using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class RunMultiplayerWindow : EditorWindow
{
    private int playerCount = 2;

    [MenuItem("File/Build And Run Multiplayer %&B", priority = 220)]
    public static void ShowWindow()
    {
        GetWindow<RunMultiplayerWindow>("Build Multiplayer");
    }

    private void OnGUI()
    {
        GUILayout.Label("Multiplayer Build Settings", EditorStyles.boldLabel);

        playerCount = EditorGUILayout.IntSlider("Number of Players", playerCount, 2, 16);

        if (GUILayout.Button("Build and Run"))
        {
            PerformWin64Build(playerCount);
        }
    }

    private static void PerformWin64Build(int playerCount)
    {
        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64);

        for (int i = 1; i <= playerCount; i++)
        {
            BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
            {
                scenes = GetScenePaths(),
                locationPathName = $"Builds/Win64/{GetProjectName()}_{i}.exe",
                target = BuildTarget.StandaloneWindows64,
                options = BuildOptions.AutoRunPlayer
            };

            BuildPipeline.BuildPlayer(buildPlayerOptions);
        }
    }

    private static string GetProjectName()
    {
        string[] s = Application.dataPath.Split('/');
        return s[s.Length - 2];
    }

    private static string[] GetScenePaths()
    {
        List<string> scenes = new List<string>();
        foreach (EditorBuildSettingsScene scene in EditorBuildSettings.scenes)
        {
            if (scene.enabled)
            {
                scenes.Add(scene.path);
            }
        }
        return scenes.ToArray();
    }
}
