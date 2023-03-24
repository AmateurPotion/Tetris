using Tetris.Tetris;
using Tetris.Utils.Serialization;
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

        private const int MaxSize = 50;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUILayout.Space(5);
            GUILayout.Label("Size", EditorStyles.boldLabel);
            GUILayout.Space(5);
            GUILayout.BeginHorizontal();
            {
                var width = EditorGUILayout.IntField("width", _shape.width);
                if (width != _shape.width)
                {
                    _shape.width = width > MaxSize ? MaxSize : width < 1 ? 1 : width;
                    EditorUtility.SetDirty(_shape);
                    return;
                }

                GUILayout.Space(10);

                var height = EditorGUILayout.IntField("height", _shape.height);
                if (height != _shape.height)
                {
                    _shape.height = height > MaxSize ? MaxSize : height < 1 ? 1 : height;
                    EditorUtility.SetDirty(_shape);
                    return;
                }
            }
            GUILayout.EndHorizontal();

            var size = (_shape.height, _shape.width);
            var structure = new bool[size.height][];
            for (var y = 0; y < size.height; y++)
            {
                structure[y] = new bool[size.width];
            }
            

            if (_shape.structure != null)
            {
                for (var y = 0; y < size.height && y < _shape.structure.Length; y++)
                {
                    if (_shape.structure[y] == null) continue;

                    for (var x = 0; x < size.width && x < _shape.structure[y].content.Length; x++)
                    {
                        structure[y][x] = _shape.structure[y].content[x];
                    }
                }
            }

            GUILayout.Space(10);
            GUILayout.Label("Structure", EditorStyles.boldLabel);

            var container = new SerializableContainer<bool[]>[size.height];

            GUILayout.BeginVertical();
            {
                for (var y = 0; y < size.height; y++)
                {
                    container[y] = new SerializableContainer<bool[]>(new bool[size.width]);
                }

                for (var y = 0; y < size.height; y++)
                {
                    GUILayout.BeginHorizontal();
                    GUILayout.FlexibleSpace();
                    for (var x = 0; x < size.width; x++)
                    {
                        container[y].content[x] = GUILayout.Toggle(structure[y][x], "");
                    }

                    GUILayout.EndHorizontal();
                }
            }
            GUILayout.EndVertical();

            _shape.structure = container;
            EditorUtility.SetDirty(_shape);
        }
    }
}