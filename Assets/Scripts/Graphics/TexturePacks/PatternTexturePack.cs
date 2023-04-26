using System;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Tetris.Graphics.TexturePacks
{
    [CreateAssetMenu(fileName = "new Pattern Texture Pack", menuName = "Tetris/Texture/Pattern Texture", order = 0)]
    public class PatternTexturePack : TexturePack
    {
        public RuleTile pattern;
        private Tilemap map;

        private void OnEnable()
        {
            for (var i = 0; i < pattern.m_TilingRules.Count; i++)
            {
                var tile = pattern.m_TilingRules[i];
            }
        }

        public override RuleTile GetTile(Tile type) => type switch
        {
            Tile.Color1 => pattern,
            Tile.Color2 => pattern,
            Tile.Color3 => pattern,
            Tile.Color4 => pattern,
            Tile.Color5 => pattern,
            Tile.Color6 => pattern,
            Tile.Color7 => pattern,
            Tile.Color8 => pattern,
            Tile.Shadow => pattern,
            Tile.Blocked => pattern,
            _ => throw new ArgumentException(nameof(type))
        };
    }
}