using System.Collections.Generic;
using UnityEngine;

namespace Tetris.Utils.Extensions
{
    public static class SpriteExtensions
    {
        public static List<Vector2> GetPhysicsShape(this Sprite sprite, int shapeIdx)
        {
            var shape = new List<Vector2>();
            sprite.GetPhysicsShape(shapeIdx, shape);
            
            return shape;
        }

        public static void SetColor(this Sprite sprite, Color color)
        {
            for (var x = 0; x < sprite.texture.width; x++)
            {
                for (var y = 0; y < sprite.texture.height; y++)
                {
                    var prevColor = sprite.texture.GetPixel(x, y);
                    sprite.texture.SetPixel(x, y, prevColor.Mix(color));
                }
            }
        }

        public static Texture2D Replicate(this Texture2D origin)
        {
            var result = new Texture2D(origin.width, origin.height, origin.format, origin.mipmapCount, true);
            
            for (var x = 0; x < origin.width; x++)
            {
                for (var y = 0; y < origin.height; y++)
                {
                    result.SetPixel(x, y, origin.GetPixel(x, y));
                }
            }
            
            return result;
        }
    }
}