using UnityEngine;

namespace Tetris.Graphics.TexturePacks
{
    //[CreateAssetMenu(fileName = "new Tetris Texture Pack", menuName = "Tetris/Texture pack", order = 0)]
    public abstract class TexturePack : ScriptableObject
    {
        public abstract RuleTile GetTile(Tile type);
    }

    public enum Tile
    {
        Color1, Color2, Color3, Color4, Color5, Color6, Color7, Color8,
        Shadow, Blocked
    }
}