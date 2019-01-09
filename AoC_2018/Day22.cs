using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
     * 
    */
    public class Day22 : Day
    {
        public override string Title => "2018 - Day 22";
        public static int TargetX = 14; // 10
        public static int TargetY = 709; // 10
        public static int CaveDepth = 6084; //510

        public override void PartOne()
        {
            base.PartOne();

            var regions = new List<SquareRegion>();
            for (int y = 0; y <= TargetY; y++)
            {
                for (int x = 0; x <= TargetX; x++)
                {
                    regions.Add(new SquareRegion(x, y, regions));
                }
            }

            var result = regions.Sum(s => s.RiskLevel);
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }
    }

    public class SquareRegion
    {
        public int X;
        public int Y;
        public RegionType Type;
        public int GeologicIndex;
        public int ErosionLevel;
        public int RiskLevel => (int)Type;
        private List<SquareRegion> _allRegions;

        public SquareRegion(int x, int y, List<SquareRegion> allRegions)
        {
            X = x;
            Y = y;
            _allRegions = allRegions;
            GeologicIndex = GetGeologicIndex();
            SetErosionLevelAndSetType();
        }

        public void SetErosionLevelAndSetType()
        {
            ErosionLevel = (GeologicIndex + Day22.CaveDepth) % 20183;

            if (ErosionLevel % 3 == 0)
            {
                Type = RegionType.Rocky;
            }
            else if (ErosionLevel % 3 == 1)
            {
                Type = RegionType.Wet;
            }
            else if (ErosionLevel % 3 == 2)
            {
                Type = RegionType.Narrow;
            }
        }

        private int GetGeologicIndex()
        {
            if ((X == 0 && Y == 0) ||
                X == Day22.TargetX && Y == Day22.TargetY)
            {
                return 0;
            }

            if (Y == 0)
            {
                return X * 16807;
            }

            if (X == 0)
            {
                return Y * 48271;
            }

            var neigbourOne = _allRegions.First(f => f.X == X - 1 && f.Y == Y);
            var neigbourTwo = _allRegions.First(f => f.X == X && f.Y == Y - 1);

            return neigbourOne.ErosionLevel * neigbourTwo.ErosionLevel;
        }
    }

    public enum RegionType
    {
        Rocky = 0,
        Narrow = 2,
        Wet = 1
    }
}