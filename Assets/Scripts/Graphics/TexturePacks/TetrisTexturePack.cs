using UnityEngine;

namespace Tetris.Graphics.TexturePacks
{
    //[CreateAssetMenu(fileName = "new Tetris Texture Pack", menuName = "Tetris/Texture pack", order = 0)]
    public abstract class TetrisTexturePack : ScriptableObject
    {
        public abstract RuleTile GetTile(TileType type);
    }

    public enum TileType
    {
        Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8,
        Shadow, Blocked
    }
}