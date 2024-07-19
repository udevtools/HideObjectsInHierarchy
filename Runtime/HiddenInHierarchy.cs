using UnityEngine;

public class HiddenInHierarchy : MonoBehaviour
{
    private void OnValidate()
    {
        UpdateState();
    }

    public void UpdateState()
    {
#if UNITY_EDITOR
        bool hidden = UnityEditor.EditorPrefs.GetBool("hidden", false);
        gameObject.hideFlags = hidden ? HideFlags.HideInHierarchy : HideFlags.None;
#endif
    }
}
