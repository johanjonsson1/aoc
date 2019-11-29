using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2018
{
    /*
     * 
    */
    public class Day15 : Day
    {
        public override string Title => "2018 - Day 15";

        public override void PartOne()
        {
            base.PartOne();
            // bygg cavern och combatants
            var allCombatants = new List<Combatant>();
            var liveCombatants = allCombatants.Where(x => !x.Dead).OrderBy(o => o.Coordinate.Y).ThenBy(o => o.Coordinate.X).ToList();
            // printconsole
            var fullRounds = 0;
            while (true)
            {
                foreach (var combatant in liveCombatants)
                {
                    combatant.TakeTurn();
                }

                liveCombatants = allCombatants.Where(x => !x.Dead).OrderBy(o => o.Coordinate.Y).ThenBy(o => o.Coordinate.X).ToList();

                if (liveCombatants.Select(x => x.Race).Distinct().Count() == 1)
                {
                    break;
                }

                fullRounds++;
            }

            var result = fullRounds * liveCombatants.Sum(s => s.HitPoints);
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }
    }

    public class Combatant
    {
        public Race Race;
        public int Id;
        public Coordinate Coordinate { get; set; }
        public bool Dead => HitPoints <= 0;
        public int HitPoints = 200;
        private readonly int _attackPower = 3;
        private readonly List<Combatant> _combatants;

        public Combatant(int id, int x, int y, Race race, List<Combatant> combatants)
        {
            Id = id;
            Coordinate = new Coordinate(x, y);
            Race = race;
            _combatants = combatants;
        }

        private List<Combatant> GetEnemiesOrderedByDistance()
        {
            return _combatants.Where(x => x.Race != Race && x.Id != Id).OrderBy(o => o.Coordinate.GetDistance(Coordinate)).ToList();
        }

        public void TakeTurn()
        {

        }

        // GetAdjacentSquares(enemy) (unoccupied)
        // ChooseClosestSquare(my x y)
        // TakeTurn { GetEnemies -> GetAdjacent -> Attack() || Move() }
        // Public void Attack(Combatant enemy)
        // Public List<Route> TryRoute(enemy)
    }

    public enum Race
    {
        Elf,
        Goblin
    }

    public class Route
    {
        public int Id;
        public int Distance => Steps.Count;
        public List<Coordinate> Steps = new List<Coordinate>();
        public Coordinate StartingPoint => Steps[0];
    }
}
