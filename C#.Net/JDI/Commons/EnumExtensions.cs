﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Epam.JDI.Commons
{
    public static class EnumExtensions
    {
        public static List<string> GetEnumValues(this Type type)
        {
            return (from object value in Enum.GetValues(type) select value.ToString()).ToList();
        }
    }
}
