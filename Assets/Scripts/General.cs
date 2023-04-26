using System.Collections.Generic;
using Tetris.Game;
using Tetris.Graphics.TexturePacks;
using UnityEngine;

namespace Tetris
{
    public static class General
    {
        // Settings
        // staticMode | false(default) - frame time / true - ms time 
        public static (int frame, float ms, bool staticMode) ARR, DAS, SDF;
        public static TexturePack activeTexture;

        // Contents
        public static Dictionary<string, MinoShape> shapes => MinoShape.allocated;
        public static void Init()
        {
            MinoShape.Init();

            ARR = (PlayerPrefs.GetInt("arr_i", 1), PlayerPrefs.GetFloat("arr_f", 1),
                PlayerPrefs.GetInt("arr_m", 0) == 1);
            DAS = (PlayerPrefs.GetInt("das_i", 1), PlayerPrefs.GetFloat("das_f", 1),
                PlayerPrefs.GetInt("das_m", 0) == 1);
            SDF = (PlayerPrefs.GetInt("sdf_i", 1), PlayerPrefs.GetFloat("sdf_f", 1),
                PlayerPrefs.GetInt("sdf_m", 0) == 1);
            
        }
    }
}