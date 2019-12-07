using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#else
using UnityEngine.SceneManagement;
#endif
// Caleb Katzenstein
// Displacement
// Contains methods that should be accessible to all classes
public static class EventSystem
{
	public static void StartGame()
    {
    #if UNITY_EDITOR
        EditorSceneManager.LoadSceneAsync(1);
    #else
        SceneManager.LoadSceneAsync(1);  
#endif
    }
}
