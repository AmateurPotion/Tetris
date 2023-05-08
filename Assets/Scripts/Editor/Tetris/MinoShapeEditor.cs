using Tetris.Game.Tetris;
using Tetris.Utils.Extensions;
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

        private byte selectMode = 0;
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            GUILayout.Space(10);

            // srs rotation point
            GUILayout.Label("SRS rotation point", EditorStyles.boldLabel);
            GUILayout.Space(5);
            EditorGUILayout.BeginHorizontal();
            {
                _shape.left = EditorGUILayout.Vector2IntField("Left", _shape.left).Clamp((0, 0), (_shape.width - 1,_shape.height - 1));

                (selectMode switch
                {
                    1 => Color.white,
                    _ => Color.gray
                }).GUI(() =>
                {
                    if (GUILayout.Button("Select")) selectMode = selectMode == 1 ? (byte)0 : (byte)1;
                });
            }
            EditorGUILayout.EndHorizontal();

            EditorGUILayout.BeginHorizontal();
            {
                _shape.right = EditorGUILayout.Vector2IntField("Right", _shape.right).Clamp((0, 0), (_shape.width - 1,_shape.height - 1));
                
                (selectMode switch
                {
                    2 => Color.white,
                    _ => Color.gray
                }).GUI(() =>
                {
                    if (GUILayout.Button("Select")) selectMode = selectMode == 2 ? (byte)0 : (byte)2;
                });
            }
            EditorGUILayout.EndHorizontal();

            // Structure Editor
            bool clearStructure;
            GUILayout.Space(10);
            
            GUILayout.BeginHorizontal();
            {
                GUILayout.Label("Structure", EditorStyles.boldLabel);
                GUILayout.Space(10);
                clearStructure = GUILayout.Button("Clear");
            }
            GUILayout.EndHorizontal();
            
            GUILayout.Space(10);

            GUILayout.BeginVertical();
            {
                for (var y = 0; y < _shape.height; y++)
                {
                    GUILayout.BeginHorizontal();
                    GUILayout.FlexibleSpace();
                    for (var x = 0; x < _shape.width; x++)
                    {
                        bool l = _shape.left.Equals(new Vector2Int(x, y)),
                            r = _shape.right.Equals(new Vector2Int(x, y));
                        GUI.color = (r, l) switch
                        {
                            (true, true) => Color.magenta,
                            (true, false) => Color.red,
                            (false, true) => Color.blue,
                            (false, false) => Color.white
                        };

                        if (clearStructure)
                        {
                            _shape[x, y] = 0;
                            continue;    
                        }
                        
                        if (GUILayout.Button(_shape[x, y].ToString()))
                        {
                            if (selectMode != 0)
                            {
                                if (selectMode == 1) _shape.left = new Vector2Int(x, y);
                                else if (selectMode == 2) _shape.right = new Vector2Int(x, y);

                                selectMode = 0;
                                continue;
                            }
                            _shape[x, y] = _shape[x, y] > 7 ? (byte)0 : (byte)(_shape[x, y] + 1);
                        }
                    }

                    GUILayout.EndHorizontal();
                }
            }
            GUILayout.EndVertical();

            EditorUtility.SetDirty(_shape);
        }
    }
}