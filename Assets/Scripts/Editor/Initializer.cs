#if UNITY_EDITOR
using Tetris;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tetris.Editor
{
    [InitializeOnLoad]
    public static class Initializer
    {
        static Initializer(){
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                General.Init();
            }
        }
    }
}
#endif