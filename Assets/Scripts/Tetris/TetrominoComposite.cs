using System;
using Tetris.Utils.Extensions;
using UnityEngine;

namespace Tetris.Tetris
{
    public class TetrominoComposite : MonoBehaviour
    {
        public RuleTile tile;
        public Vector2Int[] tiles;

        public void Down()
        {
            for (var i = 0; i < tiles.Length; i++)
            {
                tiles[i] = tiles[i].Add(0, -1);
            }
        }
    }
}