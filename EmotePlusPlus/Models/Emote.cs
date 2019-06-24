﻿using System;

namespace EmotePlusPlus.Models
{
    public class Emote
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public bool Animated { get; set; }
        public int Uses { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string ToString()
        {
            return $"<{(Animated ? "a" : "")}:{Name}:{Id}>";
        }
    }
}
