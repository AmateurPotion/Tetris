using Tetris.Game;
using UnityEditor;
using UnityEngine;

namespace Tetris.Editor.Tetris
{
    [CustomEditor(typeof(MinoShape)), CanEditMultipleObjects]
    public class MinoShapeEditor : UnityEditor.Editor
    {
        private MinoShape _shape;

        private void OnEnable()
        {
            _shape = (MinoShape)target;
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            GUILayout.Space(10);

            // srs rotation point
            GUILayout.Label("SRS rotation point", EditorStyles.boldLabel);
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
            {
                var x = EditorGUILayout.IntField("x", _shape.rotationPoint.x);
                GUILayout.Space(10);
                var y = EditorGUILayout.IntField("y", _shape.rotationPoint.y);

                _shape.rotationPoint = new Vector2Int(
                    x < 0 ? 0 : x < _shape.width ? x : _shape.width - 1,
                    y < 0 ? 0 : y < _shape.height ? y : _shape.height - 1
                );
            }
            GUILayout.EndHorizontal();

            GUILayout.Space(10);
            
            GUILayout.Label("Structure", EditorStyles.boldLabel);
            GUILayout.BeginVertical();
            {
                for (var y = 0; y < _shape.height; y++)
                {
                    GUILayout.BeginHorizontal();
                    GUILayout.FlexibleSpace();
                    for (var x = 0; x < _shape.width; x++)
                    {
                        GUI.color = _shape.rotationPoint == new Vector2Int(x, y) ? Color.red : Color.white;
                        _shape[x, y] = GUILayout.Toggle(_shape[x, y], "");
                    }

                    GUILayout.EndHorizontal();
                }
            }
            GUILayout.EndVertical();

            EditorUtility.SetDirty(_shape);
        }
        
        
    }
}