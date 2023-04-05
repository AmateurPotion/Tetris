﻿using System;
using UnityEditor;
using UnityEngine;

namespace Tetris.Utils.Singletons
{
    public class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T _main;
        public static T Main => _main;

        protected virtual void Awake()
        {
            _main = this as T;
        }
    }
}