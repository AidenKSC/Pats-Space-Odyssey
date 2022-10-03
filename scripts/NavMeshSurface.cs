using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.SceneManagement;
#endif
namespace UnityEngine.AI
{
public enum CollectObjects
    {
All = 0,
Volume = 1,
Children = 2,
    }
    [ExecuteAlways]
    [DefaultExecutionOrder(-102)]
    [AddComponentMenu("Navigation/NavMeshSurface", 30)]
    [HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
public class NavMeshSurface : MonoBehaviour
    {

    }
}
