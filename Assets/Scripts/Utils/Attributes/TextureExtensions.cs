#if UNITY_EDITOR
using System;
using UnityEditor;
#endif

using UnityEngine;
using System.Collections.Generic;

namespace Tetris.Utils.Attributes
{
    public static class TextureExtensions
    {
#if UNITY_EDITOR
        public static bool TryGetMetadata(this Texture2D texture, out List<SpriteMetaData> data, out string path)
        {
            data = new();

            path = AssetDatabase.GetAssetPath(texture);
            var importer = AssetImporter.GetAtPath(path) as TextureImporter;
            if (importer == null)
            {
                return false;
            }

            for (var i = 0; i < importer.spritesheet.Length; i++)
            {
                data.Add(importer.spritesheet[i]);
            }

            return true;
        }

        public static void SetMultipleMetadata(this Texture2D texture, SpriteMetaData[] metadata, Action<TextureImporter> then)
        {
            var path = AssetDatabase.GetAssetPath(texture);
            var importer = AssetImporter.GetAtPath(path) as TextureImporter;

            if (importer == null) throw new NullReferenceException();

            importer.textureType = TextureImporterType.Sprite;
            importer.spriteImportMode = SpriteImportMode.Multiple;
            importer.spritesheet = metadata;

            then(importer);

            AssetDatabase.ImportAsset(path, ImportAssetOptions.ForceUpdate);
        }
#endif
    }
}