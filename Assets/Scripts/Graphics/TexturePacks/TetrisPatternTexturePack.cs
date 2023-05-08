using System;
using System.Collections.Generic;
using Tetris.Utils.Extensions;
using UnityEngine;

namespace Tetris.Graphics.TexturePacks
{
    [CreateAssetMenu(fileName = "new Tetris Pattern Texture Pack", menuName = "Tetris/Texture/Pattern Texture", order = 0)]
    public class TetrisPatternTexturePack : TetrisTexturePack
    {
        public RuleTile pattern, shadow, special;
        private List<RuleTile> _colorPatterns;

        private void OnEnable()
        {
            for (var i = 0; i < 8; i++)
            {
                var colorPattern = CreateInstance<RuleTile>();
                var currentColor = i switch
                {
                    0 => Color.red,
                    1 => new Color(0.93f, 0.52f, 0f),
                    2 => Color.yellow,
                    3 => Color.green,
                    4 => Color.cyan,
                    5 => Color.blue,
                    6 => new Color(0.55f, 0.06f, 0.75f),
                    7 => Color.gray,
                    _ => throw new InvalidOperationException()
                };

                for (var j = 0; j < pattern.m_TilingRules.Count; j++)
                {
                    var rule = pattern.m_TilingRules[j].Clone();
                    var prevSprite = rule.m_Sprites[0];
                    var sprite = Sprite.Create(prevSprite.texture.Clone(), prevSprite.rect, prevSprite.pivot,
                        prevSprite.pixelsPerUnit);
                    
                    sprite.SetColor(currentColor);
                    colorPattern.m_TilingRules.Add(rule);
                }
                
                _colorPatterns.Add(colorPattern);
            }
        }

        public override RuleTile GetTile(TileType type) => type switch
        {
            TileType.Color1 => _colorPatterns[0],
            TileType.Color2 => _colorPatterns[1],
            TileType.Color3 => _colorPatterns[2],
            TileType.Color4 => _colorPatterns[3],
            TileType.Color5 => _colorPatterns[4],
            TileType.Color6 => _colorPatterns[5],
            TileType.Color7 => _colorPatterns[6],
            TileType.Color8 => _colorPatterns[7],
            TileType.Shadow => shadow,
            TileType.Blocked => special,
            _ => throw new ArgumentException(nameof(type))
        };
    }
}