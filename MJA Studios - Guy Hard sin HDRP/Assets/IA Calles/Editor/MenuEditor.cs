﻿using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class MenuEditor : MonoBehaviour
{
    [MenuItem("StreePopulation/Create/New Scene", menuItem = "GuyHard/Create/New Scene", priority = 100, validate = false)]
    static void MakeScene()
    {
        if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            return;
        }
        EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects);

        GameObject g = (GameObject)Instantiate(AssetDatabase.LoadAssetAtPath(@"Assets/UTS_PRO/Models/People/Prefabs/Population System.prefab", typeof(UnityEngine.GameObject)));
        g.name = g.name.Split('(')[0];
    }

    [MenuItem("StreePopulation/Create/Vehicles")]
    private static void CreateVehiclePath()
    {
        CreatePath(PathType.VehiclePath);
    }

    [MenuItem("StreePopulation/Create/Bicycles\\Gyro")]
    private static void CreateBcyclesGyroPath()
    {
        CreatePath(PathType.BcyclesGyroPath);
    }

    [MenuItem("StreePopulation/Create/Population/Walking people")]
    private static void CreateWalkingPeople()
    {
        CreatePath(PathType.PeoplePath);
    }

    [MenuItem("StreePopulation/Create/Population/Audience")]
    private static void CreateAudience()
    {
        var populationSystemManager = GetPopulationSystemManager();
        Selection.activeGameObject = populationSystemManager.gameObject;
        ActiveEditorTracker.sharedTracker.isLocked = true;
        populationSystemManager.isConcert = true;
    }

    [MenuItem("StreePopulation/Create/Population/Talking people")]
    private static void CreateTalkingPeople()
    {
        var populationSystemManager = GetPopulationSystemManager();
        Selection.activeGameObject = populationSystemManager.gameObject;
        ActiveEditorTracker.sharedTracker.isLocked = true;
        populationSystemManager.isStreet = true;
    }

    [MenuItem("StreePopulation/Create/Semaphore System/Standard crossroad")]
    private static void CreateStandardCrossroad()
    {
        var populationSystemManager = GetPopulationSystemManager();
        GameObject go = Instantiate(populationSystemManager.pointPrefab);
        go.AddComponent<LightManager>().standardCrossroad = true;
        Selection.activeGameObject = go;
        ActiveEditorTracker.sharedTracker.isLocked = true;
    }

    [MenuItem("StreePopulation/Create/Semaphore System/T-shaped crossroad")]
    private static void CreateTshapedCrossroad()
    {
        var populationSystemManager = GetPopulationSystemManager();
        GameObject go = Instantiate(populationSystemManager.pointPrefab);
        go.AddComponent<LightManager>().TCrossroad = true;
        Selection.activeGameObject = go;
        ActiveEditorTracker.sharedTracker.isLocked = true;
    }

    private static void CreatePath(PathType pathType)
    {
        GetPopulationSystemManager();

        GameObject newPath = new GameObject { name = "New path" };
        NewPath newPathComponent = newPath.AddComponent<NewPath>();
        newPathComponent.PathType = pathType;
        Selection.activeGameObject = newPath;
    }

    private static PopulationSystemManager GetPopulationSystemManager()
    {
        if (FindObjectOfType<PopulationSystemManager>() == null)
        {
            string[] managerPrefabs = AssetDatabase.FindAssets("Population System t:Prefab");
            if (managerPrefabs.Length > 0)
            {
                string managerPath = AssetDatabase.GUIDToAssetPath(managerPrefabs[0]);
                PrefabUtility.InstantiatePrefab(AssetDatabase.LoadAssetAtPath<GameObject>(managerPath));
            }
        }

        return FindObjectOfType<PopulationSystemManager>();
    }
}