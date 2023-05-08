using UnityEngine;

namespace Tetris.Game.Tetris
{
    public class TetrominoComposite : MonoBehaviour
    {
        public Field field;
        public bool dummySpin = false;
        public int width { get; protected set; }
        public int height { get; protected set; }
        private byte[,] _shape;
        public Vector2Int position;

        public byte[,] shape
        {
            get => _shape;
            set
            {
                width = value.GetLength(0);
                height = value.GetLength(1);
                _shape = value;
            }
        }

        public bool canDown
        {
            get
            {
                return false;
            }
        }

        public void Init(MinoShape minoShape, Vector2Int startPosition, Field targetField)
        {
            dummySpin = false;
            shape = minoShape.GetShape();
            position = startPosition;
            field = targetField;
        }

        public void Down()
        {
            if(!canDown) return;
            
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