using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;

public static class HiddenMenu
{
    [MenuItem("GameObject/Toggle Hidden Items %h")]
    static void ToggleHiddenItems()
    {
        EditorPrefs.SetBool("hidden", !EditorPrefs.GetBool("hidden", false));

        foreach(HiddenInHierarchy hidden in GameObject.FindObjectsByType<HiddenInHierarchy>(FindObjectsSortMode.None))
            hidden.UpdateState();
    }

    [MenuItem("GameObject/Add Hidden Component %j")]
    static void AddHiddenComponent()
    {
        Selection.activeObject.AddComponent<HiddenInHierarchy>();
    }
}
