using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day14 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            return;
            base.PartOne();
            var input = Inputs.Day14.ToStringList();
//            input = @"171 ORE => 8 CNZTR
//7 ZLQW, 3 BMBT, 9 XCVML, 26 XMNCP, 1 WPTQ, 2 MZWV, 1 RJRHP => 4 PLWSL
//114 ORE => 4 BHXH
//14 VRPVC => 6 BMBT
//6 BHXH, 18 KTJDG, 12 WPTQ, 7 PLWSL, 31 FHTLT, 37 ZDVW => 1 FUEL
//6 WPTQ, 2 BMBT, 8 ZLQW, 18 KTJDG, 1 XMNCP, 6 MZWV, 1 RJRHP => 6 FHTLT
//15 XDBXC, 2 LTCX, 1 VRPVC => 6 ZLQW
//13 WPTQ, 10 LTCX, 3 RJRHP, 14 XMNCP, 2 MZWV, 1 ZLQW => 1 ZDVW
//5 BMBT => 4 WPTQ
//189 ORE => 9 KTJDG
//1 MZWV, 17 XDBXC, 3 XCVML => 2 XMNCP
//12 VRPVC, 27 CNZTR => 2 XDBXC
//15 KTJDG, 12 BHXH => 5 XCVML
//3 BHXH, 2 VRPVC => 7 MZWV
//121 ORE => 7 VRPVC
//7 XCVML => 6 RJRHP
//5 BHXH, 4 VRPVC => 5 LTCX".ToStringList();
            var distinctChemicals = new List<Chemical>();
            CreateChemicals(input, distinctChemicals);
            CreateReactions(input, distinctChemicals);

            var resultForFuel = distinctChemicals.FirstOrDefault(f => f.Id == "FUEL")?.FindCheapestReactionByOre(1); // 165?

            Console.WriteLine(resultForFuel);
        }

        private static void CreateReactions(List<string> input, List<Chemical> distinctChemicals)
        {
            foreach (var distinctChemical in distinctChemicals)
            {
                var producers = input.Where(i => i.Split(' ').Last() == distinctChemical.Id).ToList();

                foreach (var producer in producers)
                {
                    var split = producer.Split(new[] {'=', '>'}, StringSplitOptions.RemoveEmptyEntries);
                    var inputs = split[0];
                    var output = split[1];

                    var reaction = new InputReaction();
                    reaction.OutputQuantity =
                        Convert.ToInt32(output.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)[0]);

                    foreach (var input1 in inputs.Split(','))
                    {
                        var inputChemical = new InputChemical();
                        var inputSplits = input1.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                        inputChemical.Chemical = distinctChemicals.FirstOrDefault(f => f.Id == inputSplits[1]);
                        inputChemical.InputQuantity = Convert.ToInt32(inputSplits[0]);
                        reaction.Inputs.Add(inputChemical);
                    }

                    distinctChemical.InputReactions.Add(reaction);
                }
            }
        }

        private static void CreateChemicals(List<string> input, List<Chemical> distinctChemicals)
        {
            distinctChemicals.Add(new Chemical("ORE"));

            foreach (var reaction in input)
            {
                var id = reaction.Split().Last();

                if (distinctChemicals.Any(d => d.Id == id))
                {
                    continue;
                }

                distinctChemicals.Add(new Chemical(id));
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day14.ToStringList();
            input = @"171 ORE => 8 CNZTR
            7 ZLQW, 3 BMBT, 9 XCVML, 26 XMNCP, 1 WPTQ, 2 MZWV, 1 RJRHP => 4 PLWSL
            114 ORE => 4 BHXH
            14 VRPVC => 6 BMBT
            6 BHXH, 18 KTJDG, 12 WPTQ, 7 PLWSL, 31 FHTLT, 37 ZDVW => 1 FUEL
            6 WPTQ, 2 BMBT, 8 ZLQW, 18 KTJDG, 1 XMNCP, 6 MZWV, 1 RJRHP => 6 FHTLT
            15 XDBXC, 2 LTCX, 1 VRPVC => 6 ZLQW
            13 WPTQ, 10 LTCX, 3 RJRHP, 14 XMNCP, 2 MZWV, 1 ZLQW => 1 ZDVW
            5 BMBT => 4 WPTQ
            189 ORE => 9 KTJDG
            1 MZWV, 17 XDBXC, 3 XCVML => 2 XMNCP
            12 VRPVC, 27 CNZTR => 2 XDBXC
            15 KTJDG, 12 BHXH => 5 XCVML
            3 BHXH, 2 VRPVC => 7 MZWV
            121 ORE => 7 VRPVC
            7 XCVML => 6 RJRHP
            5 BHXH, 4 VRPVC => 5 LTCX".ToStringList();
            var distinctChemicals = new List<Chemical>();
            CreateChemicals(input, distinctChemicals);
            CreateReactions(input, distinctChemicals);

            var ore = 0;
            var previousOre = 0;
            var fuel = 10;
            var increment = 10;
            var targetOre = 1e12;
            var chemical = distinctChemicals.First(f => f.Id == "FUEL");
            while (true)
            {
                previousOre = ore;
                ore = chemical.FindCheapestReactionByOre(fuel);

                if (previousOre >= targetOre && ore <= targetOre && increment == 1)
                {
                    break;
                }

                if (ore < targetOre)
                {
                    if (ore - previousOre > previousOre)
                    {
                        increment *= 2;
                    }
                    fuel += increment;
                }
                else
                {
                    increment = (int)Math.Ceiling((decimal)increment / 2);
                    fuel -= increment;
                }
            }

            Console.WriteLine(fuel);
        }
    }

    public class Chemical
    {
        public string Id { get; }
        public List<InputReaction> InputReactions { get; } = new List<InputReaction>();
        public int Wasted;

        public Chemical(string id)
        {
            Id = id;
        }

        public void AddReactionProducingChemical(InputReaction reaction)
        {
            InputReactions.Add(reaction);
        }

        public int FindCheapestReactionByOre(int quantityNeeded)
        {
            if (quantityNeeded - Wasted < 1)
            {
                Wasted -= quantityNeeded;
                return 0;
            }

            quantityNeeded -= Wasted;

            var firstReaction = InputReactions.First();
            var firstInputChemical = firstReaction.Inputs.First();
            if (firstInputChemical.Chemical.Id == "ORE")
            {
                var ore = firstInputChemical.InputQuantity;
                var quantityFromOre = firstReaction.OutputQuantity;
                while (quantityFromOre < quantityNeeded)
                {
                    ore += firstInputChemical.InputQuantity;
                    quantityFromOre += firstReaction.OutputQuantity;
                }

                Wasted = quantityFromOre - quantityNeeded;
                return ore;
            }

            var lowestOre = int.MaxValue;
            var tempWasted = 0;
            foreach (var ir in InputReactions)
            {
                var ore = ir.Inputs.Sum(sm => sm.Chemical.FindCheapestReactionByOre(sm.InputQuantity));
                var quantityFromOre = ir.OutputQuantity;

                while (quantityFromOre < quantityNeeded)
                {
                    ore += ir.Inputs.Sum(sm => sm.Chemical.FindCheapestReactionByOre(sm.InputQuantity));
                    quantityFromOre += ir.OutputQuantity;
                }

                if (ore < lowestOre)
                {
                    tempWasted = quantityFromOre - quantityNeeded;
                    lowestOre = ore;
                }
            }

            Wasted = tempWasted;
            return lowestOre;
        }

        public override string ToString()
        {
            return $"Chemical {Id}, ProducingReactions {InputReactions.Count}";
        }
    }

    public class InputReaction
    {
        public int OutputQuantity { get; set; }
        public List<InputChemical> Inputs { get; set; } = new List<InputChemical>();

        public override string ToString()
        {
            return $"OutputQuantity {OutputQuantity}, InputChemicals {Inputs.Count}";
        }
    }

    public class InputChemical
    {
        public int InputQuantity { get; set; }
        public Chemical Chemical { get; set; }

        public override string ToString()
        {
            return $"Chemical {Chemical.Id}, InputQuantity {InputQuantity}";
        }
    }
}