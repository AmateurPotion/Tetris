using System;
using System.Collections.Generic;
using Tetris.Utils;
using Tetris.Utils.Attributes;
using Tetris.Utils.Extensions;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Tilemaps;

namespace Tetris.Game
{
    public class Field : ComponentSingleton<Field>
    {
        [Header("Component")] [SerializeField] private Tilemap board;
        [SerializeField] private Tilemap background;

        [Header("Properties")] protected byte?[,] data;
        [SerializeField, GetSet("width")] private byte _width = 10;

        public byte width
        {
            get => _width;
            protected set
            {
                if (background != null)
                {
                    var b = _width < value;
                    background.SetTiles(
                        new Vector2Int(_width, 0),
                        new Vector2Int(value - (b ? 1 : 0), _height - 1),
                        b ? backgroundTile : null);
                }

                _width = value;
            }
        }

        [SerializeField, GetSet("height")] private byte _height = 20;

        public byte height
        {
            get => _height;
            protected set
            {
                if (background != null)
                {
                    var b = _height < value;
                    background.SetTiles(
                        new Vector2Int(0, _height),
                        new Vector2Int(_width - 1, value - (b ? 1 : 0)),
                        b ? backgroundTile : null);
                }

                _height = value;
            }
        }

        public int extraSize = 4;

        [Header("Temporary")] [SerializeField] private RuleTile backgroundTile;

        [Header("Tetromino Composites & Pool")]
        private ObjectPool<TetrominoComposite> _compositePool;

        public List<TetrominoComposite> composites = new();
        [SerializeField] private Transform poolParent;
        [SerializeField] private GameObject baseComposite;

        private void Awake()
        {
            data = new byte?[_width, _height].Fill((byte)0);

            _compositePool = new ObjectPool<TetrominoComposite>(
                () => Instantiate(baseComposite, poolParent).GetComponent<TetrominoComposite>(),
                composite => { composites.Add(composite); },
                composite => { composites.Remove(composite); },
                composite => { }, true, 10, 10000
            );
        }

        public void AddLine(Direction direction, byte count)
        {
            var newData = new byte?[_width + (direction is Direction.Left or Direction.Right ? count : 0),
                _height + (direction is Direction.Top or Direction.Bottom ? count : 0)];

            for (var x = 0; x < _width; x++)
            {
                for (var y = 0; y < _height; y++)
                {
                    var dx = x + (direction == Direction.Right ? count : 0);
                    var dy = y + (direction == Direction.Bottom ? count : 0);
                    newData[dx, dy] = data[x, y];
                }
            }

            data = newData;
        }

        public void RemoveLine(Direction direction, byte count)
        {
            var newData = new byte?[_width - (direction is Direction.Left or Direction.Right ? count : 0),
                _height - (direction is Direction.Top or Direction.Bottom ? count : 0)];

            for (var x = 0; x < _width; x++)
            {
                for (var y = 0; y < _height; y++)
                {
                    var dx = x - (direction == Direction.Right ? count : 0);
                    if (dx < 0) continue;
                    var dy = y - (direction == Direction.Bottom ? count : 0);
                    if (dy < 0) continue;
                    newData[dx, dy] = data[x, y];
                }
            }

            data = newData;
        }

        public RuleTile tile;

        public TetrominoComposite SpawnTetromino(MinoShape shape)
        {
            var piece = _compositePool.Get();

            for (var targetX = shape.width - 1; targetX >= 0; targetX--)
            {
                for (var targetY = shape.height - 1; targetY >= 0; targetY--)
                {
                    if (shape[targetX, targetY] != 0)
                    {
                        board.SetTile(new Vector3Int(targetX + (_width - shape.width) / 2, targetY + height),
                            shape[targetX, targetY] switch
                            {
                                _ => tile
                            });
                    }
                }
            }

            return piece;
        }

        public MinoShape _shape;

        public void Spawn()
        {
            SpawnTetromino(_shape);
        }
    }
}