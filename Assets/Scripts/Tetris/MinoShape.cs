using Tetris.Utils.Serialization;
using UnityEngine;

namespace Tetris.Tetris
{
    [CreateAssetMenu(fileName = "new MinoShape", menuName = "Tetris/TetroMino Shape", order = 0)]
    public partial class MinoShape : ScriptableObject
    {
        [HideInInspector] public int width = 4;
        [HideInInspector] public int height = 4;
        public SerializableContainer<bool[]>[] structure;
    }
}