using Tetris.Utils.Attributes;
using UnityEngine;

namespace Tetris.Game
{
    [CreateAssetMenu(fileName = "new MinoShape", menuName = "Tetris/TetroMino Shape", order = 0)]
    public partial class MinoShape : ScriptableObject
    {
        [SerializeField, GetSet("width")] private byte _width = 4;
        public byte width
        {
            get => _width;
            set
            {
                if (data != null)
                {
                    var newData = new byte[value * _height];
                    for (var y = 0; y < _height; y++)
                    {
                        for (var x = 0; x < _width && x < value; x++)
                        {
                            newData[y * value + x] = data[y * _width + x];
                        }
                    }
                    data = newData;
                }
                _width = value;
            }
        }
        [SerializeField, GetSet("height")] private byte _height = 4;
        public byte height
        {
            get => _height;
            set
            {
                if (data != null)
                {
                    var newData = new byte[_width * value];

                    for (var y = 0; y < _height && y < value; y++)
                    {
                        for (var x = 0; x < _width; x++)
                        {
                            newData[y * _width + x] = data[y * _width + x];
                        }
                    }
                    data = newData;
                }
                _height = value;
            }
        }

        [HideInInspector] public Vector2Int left = Vector2Int.zero;
        [HideInInspector] public Vector2Int right = Vector2Int.zero;
        public bool noRequireSpin = false;

        [SerializeField, HideInInspector] private byte[] data =
        {
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 0, 0
        };

        public byte this[int x, int y]
        {
            get => data[y * _width + x];
            set => data[y * _width + x] = value;
        }
    }
}