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
    public class Day15 : Day
    {
        public override string Title => "2018 - Day 15";

        public override void PartOne()
        {
            base.PartOne();
            // bygg cavern och combatants
            var allCombatants = new List<Combatant>();
            var liveCombatants = allCombatants.Where(x => !x.Dead).OrderBy(o => o.Y).ThenBy(o => o.X).ToList();
            // printconsole
            var fullRounds = 0;
            while (true)
            {
                foreach (var combatant in liveCombatants)
                {
                    combatant.TakeTurn();
                }

                liveCombatants = allCombatants.Where(x => !x.Dead).OrderBy(o => o.Y).ThenBy(o => o.X).ToList();

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
        public int X;
        public int Y;
        public bool Dead => HitPoints <= 0;
        public int HitPoints = 200;
        private int AttackPower = 3;
        private List<Combatant> _combatants;

        public Combatant(int id, int x, int y, Race race, List<Combatant> combatants)
        {
            Id = id;
            X = x;
            Y = y;
            Race = race;
            _combatants = combatants;
        }

        private List<Combatant> GetEnemiesOrderedByDistance()
        {
            return _combatants.Where(x => x.Race != Race && x.Id != Id).OrderBy(o => o.DistanceFrom(X, Y)).ToList();
        }

        public int DistanceFrom(int x, int y)
        {
            return Math.Abs(X - x) + Math.Abs(Y - y);
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
        public List<Square> Steps = new List<Square>();
        public Square StartingPoint => Steps[0];
    }

    public class Square
    {
        public int X;
        public int Y;
    }
}
