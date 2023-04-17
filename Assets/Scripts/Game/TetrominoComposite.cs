using Tetris.Utils.Extensions;
using UnityEngine;

namespace Tetris.Game
{
    public class TetrominoComposite : MonoBehaviour
    {
        public Field field;
        public bool dummySpin = false;
        public int width { get; protected set; }
        public int height { get; protected set; }
        private byte?[,] _shape;
        public Vector2Int position;

        public byte?[,] shape
        {
            get => _shape;
            set
            {
                width = value.GetLength(0);
                height = value.GetLength(1);
                _shape = value;
            }
        }

        public void Init(MinoShape shape, Vector2Int position, Field field)
        {
            dummySpin = false;
        }

        public void Down()
        {
        }

        public Vector2Int GetShadowPosition()
        {
            return new();
        }

        /// <summary>
        /// Spin Tile
        /// </summary>
        /// <param name="direction">true(default) - left spin / false - right spin</param>
        public void Spin(bool direction = true)
        {
            
        }
    }
}