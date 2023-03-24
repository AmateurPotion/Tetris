using UnityEngine;

namespace Tetris.Utils.Extensions
{
    public static class VectorExtensions
    {
        public static Vector3 X(this Vector3 position, float x) => new Vector3(x, position.y, position.z);
        public static Vector3 Y(this Vector3 position, float y) => new Vector3(position.x, y, position.z);
        public static Vector3 Z(this Vector3 position, float z) => new Vector3(position.x, position.y, z);
        public static Vector3 Add(this Vector3 position, float x, float y, float z) => new Vector3(x + position.x, y + position.y, z + position.z);
        public static Vector3 Subtract(this Vector3 position, float x, float y, float z) => new Vector3(x - position.x, y - position.y, z - position.z);
        public static Vector3 Multiply(this Vector3 position, float x, float y, float z) => new Vector3(x * position.x, y * position.y, z * position.z);
        public static Vector3 Divide(this Vector3 position, float x, float y, float z) => new Vector3(x / position.x, y / position.y, z / position.z);
        public static Vector3 Negate(this Vector3 position) => new Vector3(-position.x, -position.y, -position.z);
        public static Vector3 Abs(this Vector3 position) => new Vector3(Mathf.Abs(position.x), Mathf.Abs(position.y), Mathf.Abs(position.z));
        public static Vector3 Min(this Vector3 position1, Vector3 position2) => new Vector3(Mathf.Min(position1.x, position2.x), Mathf.Min(position1.y, position2.y), Mathf.Min(position1.z, position2.z));
        public static Vector3 Max(this Vector3 position1, Vector3 position2) => new Vector3(Mathf.Max(position1.x, position2.x), Mathf.Max(position1.y, position2.y), Mathf.Max(position1.z, position2.z));
        public static Vector3 Clamp(this Vector3 position, Vector3 min, Vector3 max) => new Vector3(Mathf.Clamp(position.x, min.x, max.x), Mathf.Clamp(position.y, min.y, max.y), Mathf.Clamp(position.z, min.z, max.z));
        public static Vector3 Clamp(this Vector3 position, float min, float max) => new Vector3(Mathf.Clamp(position.x, min, max), Mathf.Clamp(position.y, min, max), Mathf.Clamp(position.z, min, max));
        
        public static Vector2Int ToVector2Int(this Vector3Int vector) => new Vector2Int(vector.x, vector.y);
        public static Vector3Int ToVector3Int(this Vector2Int vector) => new Vector3Int(vector.x, vector.y, 0);
        public static Vector3Int ToVector3Int(this Vector2Int vector, int z) => new Vector3Int(vector.x, vector.y, z);
        
        public static Vector2 ToVector2(this Vector3 vector) => new Vector2(vector.x, vector.y);
        public static Vector3 ToVector3(this Vector2 vector) => new Vector3(vector.x, vector.y, 0);
        public static Vector3 ToVector3(this Vector2 vector, int z) => new Vector3(vector.x, vector.y, z);
        
        public static Vector2 ToVector2(this Vector2Int vector) => new Vector2(vector.x, vector.y);
        public static Vector2Int ToVector2Int(this Vector2 vector) => new Vector2Int((int)vector.x, (int)vector.y);
        
        public static Vector3 ToVector3(this Vector3Int vector) => new Vector3(vector.x, vector.y, vector.z);
        public static Vector3Int ToVector3Int(this Vector3 vector) => new Vector3Int((int)vector.x, (int)vector.y, (int)vector.z);
    }
}