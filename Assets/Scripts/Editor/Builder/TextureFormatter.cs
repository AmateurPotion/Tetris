using System;
using Tetris.Utils.Attributes;
using UnityEditor;
using UnityEngine;

namespace Tetris.Editor.Builder
{
    public class TextureFormatter : EditorWindow
    {
        private TextureType _formatterType = TextureType.Texture2D;
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

            switch (_formatterType)
            {
                case TextureType.Texture2D:
                {
                    _texture2D =
                        (Texture2D)EditorGUILayout.ObjectField("texture", _texture2D, typeof(Texture2D), false);

                    if (
                        GUILayout.Button("info") &&
                        _texture2D != null &&
                        _texture2D.TryGetMetadata(out var metadataList, out var metaPath)
                    )
                    {
                        foreach (var meta in metadataList)
                        {
                            Debug.Log(meta.name);
                        }
                    }

                    break;
                }

                case TextureType.Texture3D:
                {
                    break;
                }

                default: throw new ArgumentNullException(nameof(_formatterType));
            }
        }

        public enum TextureType
        {
            Texture2D,
            Texture3D
        }
    }
}