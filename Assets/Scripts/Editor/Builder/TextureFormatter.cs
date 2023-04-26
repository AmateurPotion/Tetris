using System;
using Tetris.Utils.Attributes;
using UnityEditor;
using UnityEngine;

namespace Tetris.Editor.Builder
{
    public class TextureFormatter : EditorWindow
    {
        private TextureType _formatterType = TextureType.Texture2DReplicate;

        // Texture 2D
        private Texture2D _texture2DOrigin, _texture2DTarget;

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
                case TextureType.Texture2DReplicate:
                {
                    _texture2DOrigin =
                        (Texture2D)EditorGUILayout.ObjectField("origin texture", _texture2DOrigin, typeof(Texture2D),
                            false);
                    _texture2DTarget = (Texture2D)EditorGUILayout.ObjectField("target texture", _texture2DTarget,
                        typeof(Texture2D), false);

                    if (
                        GUILayout.Button("Replicate Format") &&
                        _texture2DOrigin != null &&
                        _texture2DOrigin.TryGetMetadata(out var metadataList, out var metaPath) &&
                        _texture2DTarget != null
                    )
                    {
                        
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
            Texture2DReplicate,
            Texture3D
        }
    }
}