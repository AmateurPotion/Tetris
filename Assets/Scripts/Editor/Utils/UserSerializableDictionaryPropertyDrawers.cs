#if UNITY_EDITOR
using Tetris.Utils.Serialization;
using UnityEditor;

namespace Tetris.Editor.Utils
{
    [CustomPropertyDrawer(typeof(SerializableDictionary<,>))]
    public class AnySerializableDictionaryPropertyDrawer : SerializableDictionaryPropertyDrawer {}

    [CustomPropertyDrawer(typeof(SerializableDictionary<,,>))]
    public class AnySerializableDictionaryStoragePropertyDrawer: SerializableDictionaryStoragePropertyDrawer {}
}
#endif