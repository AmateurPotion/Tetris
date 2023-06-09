﻿using System;

namespace Tetris.Utils.Serialization
{
    [Serializable]
    public class SerializableContainer <T>
    {
        public T content;

        public SerializableContainer(T content)
        {
            this.content = content;
        }
        public SerializableContainer() : this(default){}
        
        public static implicit operator T(SerializableContainer<T> container) => container.content;
        public static implicit operator SerializableContainer<T>(T content) => new() { content = content };
    }
}