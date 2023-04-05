﻿using UnityEngine;

namespace Tetris.Utils
{
    public class DDOLSingleton <T> : MonoBehaviour where T : DDOLSingleton<T>
    {
        private static T _instance;
        public static T instance
        {
            get
            {
                if (_instance) return _instance;

                if (Application.isPlaying)
                {
                    var obj = new GameObject
                    {
                        transform =
                        {
                            position = Vector3.zero
                        }
                    };
                
                    DontDestroyOnLoad(obj);
                    
                    var comp = obj.AddComponent<T>();
                    _instance = comp;

                    obj.name = comp.GetType().Name;
                
                    return comp;
                }

                return null;
            }
        }

    }
}