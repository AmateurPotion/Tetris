using UnityEditor;
using UnityEngine;

namespace Tetris.Editor.Builder
{
    public class TextureFormatter : EditorWindow
    {
        private TextureType _formatterType;
        private Texture2D _texture2D;
        [MenuItem("Builder/Texture Formatter")]
        private static void ShowWindow()
        {
            var window = GetWindow<TextureFormatter>();
            window.titleContent = new GUIContent("Texture Formatter");
            window.Show();
        }

        private void OnGUI()
        {
            _formatterType = (TextureType)EditorGUILayout.EnumPopup("Formatter Type", _formatterType);
        }

        public enum TextureType
        {
            Texture2D, Texture3D
        }
    }
}