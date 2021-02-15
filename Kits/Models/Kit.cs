﻿using System;
using System.Collections.Generic;

namespace Kits.Models
{
    [Serializable]
    public class Kit
    {
        public string? Name { get; set; }
        public float Cooldown { get; set; }
        public decimal Cost { get; set; }
        public decimal Money { get; set; }
        public List<KitItem>? Items { get; set; }
    }
}