using UnityEngine;

namespace Tetris.Utils.DeConstructor
{
    public static class StructDeConstructor
    {
        public static (int width, int height) DeConstruct(this Texture2D texture)
        {
            return (texture.width, texture.height);
        }
    }
}