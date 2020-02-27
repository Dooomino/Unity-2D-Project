﻿using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static void SaveAsJSON(string savePath, SaveData save) {
        string json = JsonUtility.ToJson(save);
        File.WriteAllText(savePath, json);
    }
    public static SaveData LoadFromJSON(string savePath) {
        if (File.Exists(savePath)) {
            string json = File.ReadAllText(savePath);
            SaveData save = JsonUtility.FromJson<SaveData>(json);
            return save;        
        } else {            
            Debug.LogError("Unable to load from file: " + savePath);
        }  
        return null;
    }
}