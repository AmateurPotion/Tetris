using System.Collections.Generic;
using UnityEngine.AddressableAssets;

namespace Tetris.Game
{
    public partial class MinoShape
    {
        public static readonly Dictionary<string, MinoShape> allocated = new();

        public static MinoShape
            // original Tetris Shapes
            I, J, O, S, T, Z, L;
        
        public static void Init()
        {
            Addressables.LoadAssetsAsync<MinoShape>(new AssetLabelReference { labelString = "MinoShape" }, shape =>
            {
                allocated.Add(shape.name, shape);
            }).WaitForCompletion();

            allocated.TryGetValue("MinoShape_I", out I);
            allocated.TryGetValue("MinoShape_J", out J);
            allocated.TryGetValue("MinoShape_O", out O);
            allocated.TryGetValue("MinoShape_S", out S);
            allocated.TryGetValue("MinoShape_T", out T);
            allocated.TryGetValue("MinoShape_Z", out Z);
            allocated.TryGetValue("MinoShape_L", out L);
        }
    }
}