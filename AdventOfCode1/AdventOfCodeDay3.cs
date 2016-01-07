using System.Collections.Generic;

namespace AdventOfCode1
{
    class AdventOfCodeDay3
    {
       
        private readonly Dictionary<string, Coord> _instructionSet;
        public readonly Dictionary<string, int> GridOfHouses;
        public Coord CurrentCoord;
        public Coord CurrentCoordRobo;
        public AdventOfCodeDay3()
        {
            CurrentCoord = new Coord {XCoord = 0, YCoord = 0};
            CurrentCoordRobo = new Coord { XCoord = 0, YCoord = 0 };
            GridOfHouses = new Dictionary<string, int> {{CurrentCoord.ToString(), 1}};
            _instructionSet = new Dictionary<string, Coord>
            {
                {"^",new Coord {XCoord = 0,YCoord = 1} },
                {"v", new Coord {XCoord = 0,YCoord = -1} },
                {">",new Coord {XCoord = 1,YCoord = 0} },
                {"<", new Coord {XCoord = -1,YCoord = 0} }
            };
        }

        public int RunDay3(string rawInput)
        {
            var input = rawInput.ToCharArray();
            var houseCount = 0;
            foreach (var c in input)
            {
                var direction = ParseOneDirection(c.ToString());
                houseCount = MapMove(direction);
            }
            return houseCount;
        }
        public int RunDay3Part2(string rawInput)
        {
            var input = rawInput.ToCharArray();
            var houseCount = 0;
            bool roboSanta = true;
            foreach (var c in input)
            {
                Coord direction = ParseOneDirection(c.ToString());
                houseCount = roboSanta ? 
                    MapMove(direction, CurrentCoordRobo) :
                    MapMove(direction, CurrentCoord);
                roboSanta = !roboSanta;
            }
            return houseCount;
        }

        public int MapMove(Coord direction, Coord cc)
        {
            cc.AddTwoCoords(direction);
            if(GridOfHouses.ContainsKey(cc.ToString()) == false)
                GridOfHouses.Add(cc.ToString(),1);
            else
            {
                GridOfHouses[cc.ToString()] += 1;
            }

            return GridOfHouses.Count;
        }
        public int MapMove(Coord direction)
        {
            CurrentCoord.AddTwoCoords(direction);
            if (GridOfHouses.ContainsKey(CurrentCoord.ToString()) == false)
                GridOfHouses.Add(CurrentCoord.ToString(), 1);
            else
            {
                GridOfHouses[CurrentCoord.ToString()] += 1;
            }

            return GridOfHouses.Count;
        }
        public Coord ParseOneDirection(string direction)
        {
            return _instructionSet[direction];
        }
       
    }

    internal class Coord
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public void AddTwoCoords(Coord c1)
        {
            XCoord += c1.XCoord;
            YCoord += c1.YCoord;
        }

        public override string ToString()
        {
            return XCoord + "," + YCoord;
        }
    }
}
