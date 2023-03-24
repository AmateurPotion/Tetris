using UnityEngine;

namespace Tetris.Utils.Extensions
{
    public static class VectorExtensions
    {
        // Vector3
        public static Vector3 X(this Vector3 position, float x) => new(x, position.y, position.z);
        public static Vector3 Y(this Vector3 position, float y) => new(position.x, y, position.z);
        public static Vector3 Z(this Vector3 position, float z) => new(position.x, position.y, z);
        public static Vector3 Add(this Vector3 position, float x, float y, float z) => new(x + position.x, y + position.y, z + position.z);
        public static Vector3 Multiply(this Vector3 position, float x, float y, float z) => new(x * position.x, y * position.y, z * position.z);
        public static Vector3 Negate(this Vector3 position) => new(-position.x, -position.y, -position.z);
        public static Vector3 Abs(this Vector3 position) => new(Mathf.Abs(position.x), Mathf.Abs(position.y), Mathf.Abs(position.z));
        public static Vector3 Min(this Vector3 position1, Vector3 position2) => new(Mathf.Min(position1.x, position2.x), Mathf.Min(position1.y, position2.y), Mathf.Min(position1.z, position2.z));
        public static Vector3 Max(this Vector3 position1, Vector3 position2) => new(Mathf.Max(position1.x, position2.x), Mathf.Max(position1.y, position2.y), Mathf.Max(position1.z, position2.z));
        public static Vector3 Clamp(this Vector3 position, Vector3 min, Vector3 max) => new(Mathf.Clamp(position.x, min.x, max.x), Mathf.Clamp(position.y, min.y, max.y), Mathf.Clamp(position.z, min.z, max.z));
        public static Vector3 Clamp(this Vector3 position, float min, float max) => new(Mathf.Clamp(position.x, min, max), Mathf.Clamp(position.y, min, max), Mathf.Clamp(position.z, min, max));
        
        // Vector2Int
        public static Vector2Int X(this Vector2Int position, int x) => new(x, position.y);
        public static Vector2Int Y(this Vector2Int position, int y) => new(position.x, y);
        public static Vector2Int Add(this Vector2Int position, int x, int y) => new(x + position.x, y + position.y);
        public static Vector2Int Multiply(this Vector2Int position, int x, int y) => new(x * position.x, y * position.y);
        public static Vector2Int Negate(this Vector2Int position) => new(-position.x, -position.y);
        public static Vector2Int Abs(this Vector2Int position) => new(Mathf.Abs(position.x), Mathf.Abs(position.y));
        public static Vector2Int Min(this Vector2Int position1, Vector2Int position2) => new(Mathf.Min(position1.x, position2.x), Mathf.Min(position1.y, position2.y));
        public static Vector2Int Max(this Vector2Int position1, Vector2Int position2) => new(Mathf.Max(position1.x, position2.x), Mathf.Max(position1.y, position2.y));
        public static Vector2Int Clamp(this Vector2Int position, Vector2Int min, Vector2Int max) => new(Mathf.Clamp(position.x, min.x, max.x), Mathf.Clamp(position.y, min.y, max.y));
        public static Vector2Int Clamp(this Vector2Int position, int min, int max) => new(Mathf.Clamp(position.x, min, max), Mathf.Clamp(position.y, min, max));
        
        // 
        public static Vector2Int ToVector2Int(this Vector3Int vector) => new(vector.x, vector.y);
        public static Vector3Int ToVector3Int(this Vector2Int vector) => new(vector.x, vector.y, 0);
        public static Vector3Int ToVector3Int(this Vector2Int vector, int z) => new(vector.x, vector.y, z);
        
        public static Vector2 ToVector2(this Vector3 vector) => new(vector.x, vector.y);
        public static Vector3 ToVector3(this Vector2 vector) => new(vector.x, vector.y, 0);
        public static Vector3 ToVector3(this Vector2 vector, int z) => new(vector.x, vector.y, z);
        
        public static Vector2 ToVector2(this Vector2Int vector) => new(vector.x, vector.y);
        public static Vector2Int ToVector2Int(this Vector2 vector) => new((int)vector.x, (int)vector.y);
        
        public static Vector3 ToVector3(this Vector3Int vector) => new(vector.x, vector.y, vector.z);
        public static Vector3Int ToVector3Int(this Vector3 vector) => new((int)vector.x, (int)vector.y, (int)vector.z);
    }
}