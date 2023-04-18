using UnityEngine;

namespace Tetris.Game
{
    [CreateAssetMenu(fileName = "new Tetris Texture Pack", menuName = "Tetris/Texture pack", order = 0)]
    public class TexturePack : ScriptableObject
    {
        public RuleTile color1, color2, color3, color4, color5, color6, color7, color8;
        public RuleTile shadowTile, blockedTile;
    }
}