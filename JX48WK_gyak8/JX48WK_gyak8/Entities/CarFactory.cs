﻿using JX48WK_gyak8.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JX48WK_gyak8.Entities
{
    public class CarFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();
        }
    }
}