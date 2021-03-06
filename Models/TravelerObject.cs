﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnocracyProject
{
    public class TravelerObject : GameObject
    {
        public override string Description { get; set; }     
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int SpaceTimeLocationID { get; set; }
        public TravelerObjectType Type { get; set; }
        public bool CanInventory { get; set; }
        public bool IsConsumable { get; set; }
        public bool IsVisible { get; set; }
        public int Value { get; set; }
    }
}
