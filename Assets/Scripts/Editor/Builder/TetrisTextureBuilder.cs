#if UNITY_EDITOR
using System;
using Tetris.Utils.Attributes;
using UnityEditor;
using UnityEngine;

namespace Tetris.Editor.Builder
{
    public class TetrisTextureBuilder : EditorWindow
    {
        private static string _prevPath;
        private ReplicateType _selectedType = ReplicateType.Texture;
        private Texture2D _targetTexture, _originTexture;
        private RuleTile _origin, _tile;

        [MenuItem("Builder/Tetris texture Builder")]
        public static void ShowWindow()
        {
            var window = GetWindow<TetrisTextureBuilder>();
            window.titleContent = new GUIContent("Tetris texture Builder");
            window.Show();
        }

        private void OnEnable()
        {
            _prevPath = string.IsNullOrEmpty(_prevPath) ? Application.dataPath : _prevPath;
            _tile = CreateInstance<RuleTile>();
        }

        private void OnGUI()
        {
            _selectedType = (ReplicateType)EditorGUILayout.EnumPopup("Replicate type", _selectedType);
            _targetTexture = (Texture2D)EditorGUILayout.ObjectField("Target Texture", _targetTexture, typeof(Texture2D), false);

            switch (_selectedType)
            {
                case ReplicateType.Texture:
                {
                    _originTexture = (Texture2D)EditorGUILayout.ObjectField("Origin Texture", _originTexture, typeof(Texture2D), false);
                    
                    if (GUILayout.Button("Replicate Texture Format") && _origin != null)
                    {
                        // Null check
                        if (_targetTexture == null) throw new ArgumentNullException(nameof(_targetTexture));
                        if (_originTexture == null) throw new ArgumentNullException(nameof(_originTexture));

                        if (_originTexture.TryGetMetadata(out var data, out var path))
                        {
                            
                        }

                    }
                    break;
                }

                case ReplicateType.RuleTile:
                {
                    _origin = (RuleTile)EditorGUILayout.ObjectField("Origin RuleTile", _origin, typeof(RuleTile), false);

                    if (GUILayout.Button("Replicate Build"))
                    {
                        // Null check
                        if (_origin == null) throw new ArgumentNullException(nameof(_origin));
                        if (_tile == null) throw new ArgumentNullException(nameof(_tile));
                
                        // Processing...
                        for (var i = 0; i < _origin.m_TilingRules.Count; i++)
                        {
                            var rule = _origin.m_TilingRules[i];
                            Debug.Log($"id {rule.m_Id}: {string.Join(" / ", rule.m_Neighbors)}");
                        }

                        // Save
                        var path = EditorUtility.SaveFilePanel("Tilemap save path", _prevPath, "new Tetris Texture", "asset");

                        AssetDatabase.CreateAsset(_tile, path);
                        AssetDatabase.SaveAssets();
                    }
                    break;
                }
            }
            
        }
    }

    public enum ReplicateType
    {
        Texture, RuleTile
    }
}
#endif