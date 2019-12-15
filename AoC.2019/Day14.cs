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
            foreach (var distinctChemical in distinctChemicals)
            {
                if (distinctChemical.InputReaction == null)
                {
                    continue;
                }

                var firstInputChemical = distinctChemical.InputReaction.Inputs[0];
                if (firstInputChemical.Chemical.Id == "ORE")
                {
                    distinctChemical.GotOre = true;
                }
            }

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

                    if (distinctChemical.InputReaction != null)
                        throw new Exception("fail, det kan vara flera?!");
                    distinctChemical.InputReaction = reaction;
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
            //input = @"171 ORE => 8 CNZTR
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

            foreach (var distinctChemical in distinctChemicals)
            {
                if (distinctChemical.InputReaction == null)
                {
                    continue;
                }

                var firstInputChemical = distinctChemical.InputReaction.Inputs[0];
                if (firstInputChemical.Chemical.Id == "ORE")
                {
                    distinctChemical.GotOre = true;
                }
            }
            
            long maxOre = 1_000_000_000_000;
            long lastOre = 0;
            long fuelRequest = 1_000_000;
            long increment = 1_000_000;
            var chemical = distinctChemicals.First(f => f.Id == "FUEL");

            while (true)
            {
                distinctChemicals.ForEach(f => f.Wasted = 0);
                var currentOre = chemical.FindCheapestReactionByOre(fuelRequest);

                if (lastOre >= maxOre && currentOre <= maxOre && increment == 1)
                {
                    break;
                }

                if (currentOre < maxOre)
                {
                    if (currentOre - lastOre > lastOre)
                    {
                        increment *= 2;
                    }
                    fuelRequest += increment;
                }
                else
                {
                    increment = (int)Math.Ceiling((double)increment / 2);
                    fuelRequest -= increment;
                }

                lastOre = currentOre;
            }

            Console.WriteLine(fuelRequest);
        }
    }

    public class Chemical
    {
        public string Id;
        public InputReaction InputReaction;
        public long Wasted;
        public bool GotOre = false;

        public Chemical(string id)
        {
            Id = id;
        }

        public void AddReactionProducingChemical(InputReaction reaction)
        {
            InputReaction = reaction;
        }

        public long FindCheapestReactionByOre(long quantityNeeded)
        {
            if (quantityNeeded - Wasted < 1)
            {
                Wasted -= quantityNeeded;
                return 0;
            }

            quantityNeeded -= Wasted;
            if (GotOre)
            {
                var firstInputChemical = InputReaction.Inputs[0];
                var multiplier = (long)Math.Ceiling((double)quantityNeeded / InputReaction.OutputQuantity);
                var ore = firstInputChemical.InputQuantity * multiplier;
                var quantityFromOre = InputReaction.OutputQuantity * multiplier;
                while (quantityFromOre < quantityNeeded)
                {
                    ore += firstInputChemical.InputQuantity;
                    quantityFromOre += InputReaction.OutputQuantity;
                }

                Wasted = quantityFromOre - quantityNeeded;
                return ore;
            }

            //var lowestOre = int.MaxValue;
            //var tempWasted = 0;
            //foreach (var ir in InputReactions)
            {
                // här kan vi gångra som fan! varje sm
                // hitta gånger baserat på output
                // 10 2 => 5 11 
                var multiplier = (long)Math.Ceiling((double)quantityNeeded / InputReaction.OutputQuantity);
                var ore = InputReaction.Inputs.Sum(sm => sm.Chemical.FindCheapestReactionByOre(sm.InputQuantity * multiplier));
                var quantityFromOre = InputReaction.OutputQuantity * multiplier;

                while (quantityFromOre < quantityNeeded)
                {
                    ore += InputReaction.Inputs.Sum(sm => sm.Chemical.FindCheapestReactionByOre(sm.InputQuantity));
                    quantityFromOre += InputReaction.OutputQuantity;
                }

                //if (ore < lowestOre)
                //{
                Wasted = quantityFromOre - quantityNeeded;
                //lowestOre = ore;
                //}


                //Wasted = tempWasted;
                return ore;
            }
        }

        public override string ToString()
        {
            return $"Chemical {Id}, ReactionInputs {InputReaction?.Inputs.Count}";
        }
    }

    public class InputReaction
    {
        public int OutputQuantity;
        public List<InputChemical> Inputs { get; set; } = new List<InputChemical>();

        public override string ToString()
        {
            return $"OutputQuantity {OutputQuantity}, InputChemicals {Inputs.Count}";
        }
    }

    public class InputChemical
    {
        public int InputQuantity;
        public Chemical Chemical;

        public override string ToString()
        {
            return $"Chemical {Chemical.Id}, InputQuantity {InputQuantity}";
        }
    }
}