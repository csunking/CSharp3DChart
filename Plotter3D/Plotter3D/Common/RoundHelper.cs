﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plotter3D.Common
{
    internal static class RoundHelper
    {
        internal static int GetDifferenceLog(double min, double max)
        {
            return (int)Math.Log(Math.Abs(max - min));
        }

        internal static double Round(double number, int rem, RoudingMode roundMode)
        {
            var unit = 1d;

            if (rem <= 0)
            {
                rem = MathHelper.Clamp(-rem, 0, 15);
                unit = Math.Pow(10, -rem - 1);

            }
            else
            {
                unit = Math.Pow(10, rem - 1);
            }

            if (roundMode == RoudingMode.Celling)
            {
                number = Math.Round((number + unit / 2) / unit, 0) * unit;
            }
            else
            {
                number = Math.Round((number - unit / 2) / unit, 0) * unit;
            }
            return number;
        }

        internal static Range<double> CreateRoundedRange(double min, double max)
        {

            //return new Range<double>(Math.Floor(min), Math.Ceiling(max));

            double delta = max - min;

            if (delta == 0)
                return new Range<double>(min, max);

            int log = (int)Math.Floor(Math.Log10(Math.Abs(delta)));

            double newMin = Round(min, log, RoudingMode.Floor);
            double newMax = Round(max, log, RoudingMode.Celling);

            return new Range<double>(newMin, newMax);
        }

        internal enum RoudingMode
        {
            Celling = 0,
            Floor = 1
        }
    }
}
