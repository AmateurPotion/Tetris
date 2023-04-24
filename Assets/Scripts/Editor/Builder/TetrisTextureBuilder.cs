#if UNITY_EDITOR
using System;
using Tetris.Graphics;
using UnityEditor;
using UnityEngine;

namespace Tetris.Editor.Builder
{
    public class TetrisTextureBuilder : EditorWindow
    {
        private static string _prevPath;
        private Sprite _sprite;
        private RuleTile _tile;
        private TetrisTextureBuildType _buildType;
        
        [MenuItem("Builder/Tetris texture Builder")]
        private static void ShowWindow()
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
            _sprite = (Sprite)EditorGUILayout.ObjectField("Sprite", _sprite, typeof(Sprite), false);
            _buildType =
                (TetrisTextureBuildType)EditorGUILayout.ObjectField("Build Type", _buildType, typeof(TetrisTextureBuildType), false);

            if (GUILayout.Button("Info") && _tile != null)
            {
                for (var i = 0; i < _tile.m_TilingRules.Count; i++)
                {
                    var rule = _tile.m_TilingRules[i];
                    Debug.Log($"id {rule.m_Id}: {string.Join(" / ", rule.m_Neighbors)}");
                }
            }

            if (GUILayout.Button("Build"))
            {
                if (_buildType == null) throw new ArgumentNullException(nameof(_buildType));
                if (_tile == null) throw new ArgumentNullException(nameof(_tile));
                
                var path = EditorUtility.SaveFilePanel("Tilemap save path", _prevPath, "new Tetris Texture", "asset");
                
                AssetDatabase.CreateAsset(_tile, path);
                AssetDatabase.SaveAssets();
            }
        }
        
    }
}
#endif