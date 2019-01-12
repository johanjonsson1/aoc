using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2018
{
    /*
    --- Day 24: Immune System Simulator 20XX ---
    After a weird buzzing noise, you appear back at the man's cottage. 
    He seems relieved to see his friend, but quickly notices that the little reindeer caught some kind of cold while out exploring.

    The portly man explains that this reindeer's immune system isn't similar to regular reindeer immune systems:

    The immune system and the infection each have an army made up of several groups; each group consists of one or more identical units. 
    The armies repeatedly fight until only one army has units remaining.

    Units within a group all have the same hit points (amount of damage a unit can take before it is destroyed), 
    attack damage (the amount of damage each unit deals), an attack type, an initiative (higher initiative units attack first and win ties), 
    and sometimes weaknesses or immunities. Here is an example group:

    18 units each with 729 hit points (weak to fire; immune to cold, slashing)
     with an attack that does 8 radiation damage at initiative 10
    Each group also has an effective power: the number of units in that group multiplied by their attack damage. 
    The above group has an effective power of 18 * 8 = 144. 
    Groups never have zero or negative units; instead, the group is removed from combat.

    Each fight consists of two phases: target selection and attacking.

    During the target selection phase, each group attempts to choose one target. 
    In decreasing order of effective power, groups choose their targets; in a tie, the group with the higher initiative chooses first. 
    The attacking group chooses to target the group in the enemy army to which it would deal the most damage (after accounting for weaknesses and immunities, 
    but not accounting for whether the defending group has enough units to actually receive all of that damage).

    If an attacking group is considering two defending groups to which it would deal equal damage, it chooses to target the defending group with the largest effective power; 
    if there is still a tie, it chooses the defending group with the highest initiative. 
    If it cannot deal any defending groups damage, it does not choose a target. Defending groups can only be chosen as a target by one attacking group.

    At the end of the target selection phase, each group has selected zero or one groups to attack, and each group is being attacked by zero or one groups.

    During the attacking phase, each group deals damage to the target it selected, if any. 
    Groups attack in decreasing order of initiative, regardless of whether they are part of the infection or the immune system. 
    (If a group contains no units, it cannot attack.)

    The damage an attacking group deals to a defending group depends on the attacking group's attack type and the defending group's immunities and weaknesses. 
    By default, an attacking group would deal damage equal to its effective power to the defending group. 
    However, if the defending group is immune to the attacking group's attack type, the defending group instead takes no damage;
    if the defending group is weak to the attacking group's attack type, the defending group instead takes double damage.

    The defending group only loses whole units from damage;
    damage is always dealt in such a way that it kills the most units possible, and any remaining damage to a unit that does not immediately kill it is ignored. 
    For example, if a defending group contains 10 units with 10 hit points each and receives 75 damage, it loses exactly 7 units and is left with 3 units at full health.

    After the fight is over, if both armies still contain units, a new fight begins; combat only ends once one army has lost all of its units.

    For example, consider the following armies:

    Immune System:
    17 units each with 5390 hit points (weak to radiation, bludgeoning) with
     an attack that does 4507 fire damage at initiative 2
    989 units each with 1274 hit points (immune to fire; weak to bludgeoning,
     slashing) with an attack that does 25 slashing damage at initiative 3

    Infection:
    801 units each with 4706 hit points (weak to radiation) with an attack
     that does 116 bludgeoning damage at initiative 1
    4485 units each with 2961 hit points (immune to radiation; weak to fire,
     cold) with an attack that does 12 slashing damage at initiative 4
    If these armies were to enter combat, the following fights, including details during the target selection and attacking phases, would take place:

    Immune System:
    Group 1 contains 17 units
    Group 2 contains 989 units
    Infection:
    Group 1 contains 801 units
    Group 2 contains 4485 units

    Infection group 1 would deal defending group 1 185832 damage
    Infection group 1 would deal defending group 2 185832 damage
    Infection group 2 would deal defending group 2 107640 damage
    Immune System group 1 would deal defending group 1 76619 damage
    Immune System group 1 would deal defending group 2 153238 damage
    Immune System group 2 would deal defending group 1 24725 damage

    Infection group 2 attacks defending group 2, killing 84 units
    Immune System group 2 attacks defending group 1, killing 4 units
    Immune System group 1 attacks defending group 2, killing 51 units
    Infection group 1 attacks defending group 1, killing 17 units
    Immune System:
    Group 2 contains 905 units
    Infection:
    Group 1 contains 797 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 184904 damage
    Immune System group 2 would deal defending group 1 22625 damage
    Immune System group 2 would deal defending group 2 22625 damage

    Immune System group 2 attacks defending group 1, killing 4 units
    Infection group 1 attacks defending group 2, killing 144 units
    Immune System:
    Group 2 contains 761 units
    Infection:
    Group 1 contains 793 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 183976 damage
    Immune System group 2 would deal defending group 1 19025 damage
    Immune System group 2 would deal defending group 2 19025 damage

    Immune System group 2 attacks defending group 1, killing 4 units
    Infection group 1 attacks defending group 2, killing 143 units
    Immune System:
    Group 2 contains 618 units
    Infection:
    Group 1 contains 789 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 183048 damage
    Immune System group 2 would deal defending group 1 15450 damage
    Immune System group 2 would deal defending group 2 15450 damage

    Immune System group 2 attacks defending group 1, killing 3 units
    Infection group 1 attacks defending group 2, killing 143 units
    Immune System:
    Group 2 contains 475 units
    Infection:
    Group 1 contains 786 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 182352 damage
    Immune System group 2 would deal defending group 1 11875 damage
    Immune System group 2 would deal defending group 2 11875 damage

    Immune System group 2 attacks defending group 1, killing 2 units
    Infection group 1 attacks defending group 2, killing 142 units
    Immune System:
    Group 2 contains 333 units
    Infection:
    Group 1 contains 784 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 181888 damage
    Immune System group 2 would deal defending group 1 8325 damage
    Immune System group 2 would deal defending group 2 8325 damage

    Immune System group 2 attacks defending group 1, killing 1 unit
    Infection group 1 attacks defending group 2, killing 142 units
    Immune System:
    Group 2 contains 191 units
    Infection:
    Group 1 contains 783 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 181656 damage
    Immune System group 2 would deal defending group 1 4775 damage
    Immune System group 2 would deal defending group 2 4775 damage

    Immune System group 2 attacks defending group 1, killing 1 unit
    Infection group 1 attacks defending group 2, killing 142 units
    Immune System:
    Group 2 contains 49 units
    Infection:
    Group 1 contains 782 units
    Group 2 contains 4434 units

    Infection group 1 would deal defending group 2 181424 damage
    Immune System group 2 would deal defending group 1 1225 damage
    Immune System group 2 would deal defending group 2 1225 damage

    Immune System group 2 attacks defending group 1, killing 0 units
    Infection group 1 attacks defending group 2, killing 49 units
    Immune System:
    No groups remain.
    Infection:
    Group 1 contains 782 units
    Group 2 contains 4434 units
    In the example above, the winning army ends up with 782 + 4434 = 5216 units.

    You scan the reindeer's condition (your puzzle input); the white-bearded man looks nervous. 
    As it stands now, how many units would the winning army have?

    --- Part Two ---
    Things aren't looking good for the reindeer. The man asks whether more milk and cookies would help you think.

    If only you could give the reindeer's immune system a boost, you might be able to change the outcome of the combat.

    A boost is an integer increase in immune system units' attack damage. 
    For example, if you were to boost the above example's immune system's units by 1570, the armies would instead look like this:

    Immune System:
    17 units each with 5390 hit points (weak to radiation, bludgeoning) with
     an attack that does 6077 fire damage at initiative 2
    989 units each with 1274 hit points (immune to fire; weak to bludgeoning,
     slashing) with an attack that does 1595 slashing damage at initiative 3

    Infection:
    801 units each with 4706 hit points (weak to radiation) with an attack
     that does 116 bludgeoning damage at initiative 1
    4485 units each with 2961 hit points (immune to radiation; weak to fire,
     cold) with an attack that does 12 slashing damage at initiative 4
    With this boost, the combat proceeds differently:

    Immune System:
    Group 2 contains 989 units
    Group 1 contains 17 units
    Infection:
    Group 1 contains 801 units
    Group 2 contains 4485 units

    Infection group 1 would deal defending group 2 185832 damage
    Infection group 1 would deal defending group 1 185832 damage
    Infection group 2 would deal defending group 1 53820 damage
    Immune System group 2 would deal defending group 1 1577455 damage
    Immune System group 2 would deal defending group 2 1577455 damage
    Immune System group 1 would deal defending group 2 206618 damage

    Infection group 2 attacks defending group 1, killing 9 units
    Immune System group 2 attacks defending group 1, killing 335 units
    Immune System group 1 attacks defending group 2, killing 32 units
    Infection group 1 attacks defending group 2, killing 84 units
    Immune System:
    Group 2 contains 905 units
    Group 1 contains 8 units
    Infection:
    Group 1 contains 466 units
    Group 2 contains 4453 units

    Infection group 1 would deal defending group 2 108112 damage
    Infection group 1 would deal defending group 1 108112 damage
    Infection group 2 would deal defending group 1 53436 damage
    Immune System group 2 would deal defending group 1 1443475 damage
    Immune System group 2 would deal defending group 2 1443475 damage
    Immune System group 1 would deal defending group 2 97232 damage

    Infection group 2 attacks defending group 1, killing 8 units
    Immune System group 2 attacks defending group 1, killing 306 units
    Infection group 1 attacks defending group 2, killing 29 units
    Immune System:
    Group 2 contains 876 units
    Infection:
    Group 2 contains 4453 units
    Group 1 contains 160 units

    Infection group 2 would deal defending group 2 106872 damage
    Immune System group 2 would deal defending group 2 1397220 damage
    Immune System group 2 would deal defending group 1 1397220 damage

    Infection group 2 attacks defending group 2, killing 83 units
    Immune System group 2 attacks defending group 2, killing 427 units
    After a few fights...

    Immune System:
    Group 2 contains 64 units
    Infection:
    Group 2 contains 214 units
    Group 1 contains 19 units

    Infection group 2 would deal defending group 2 5136 damage
    Immune System group 2 would deal defending group 2 102080 damage
    Immune System group 2 would deal defending group 1 102080 damage

    Infection group 2 attacks defending group 2, killing 4 units
    Immune System group 2 attacks defending group 2, killing 32 units
    Immune System:
    Group 2 contains 60 units
    Infection:
    Group 1 contains 19 units
    Group 2 contains 182 units

    Infection group 1 would deal defending group 2 4408 damage
    Immune System group 2 would deal defending group 1 95700 damage
    Immune System group 2 would deal defending group 2 95700 damage

    Immune System group 2 attacks defending group 1, killing 19 units
    Immune System:
    Group 2 contains 60 units
    Infection:
    Group 2 contains 182 units

    Infection group 2 would deal defending group 2 4368 damage
    Immune System group 2 would deal defending group 2 95700 damage

    Infection group 2 attacks defending group 2, killing 3 units
    Immune System group 2 attacks defending group 2, killing 30 units
    After a few more fights...

    Immune System:
    Group 2 contains 51 units
    Infection:
    Group 2 contains 40 units

    Infection group 2 would deal defending group 2 960 damage
    Immune System group 2 would deal defending group 2 81345 damage

    Infection group 2 attacks defending group 2, killing 0 units
    Immune System group 2 attacks defending group 2, killing 27 units
    Immune System:
    Group 2 contains 51 units
    Infection:
    Group 2 contains 13 units

    Infection group 2 would deal defending group 2 312 damage
    Immune System group 2 would deal defending group 2 81345 damage

    Infection group 2 attacks defending group 2, killing 0 units
    Immune System group 2 attacks defending group 2, killing 13 units
    Immune System:
    Group 2 contains 51 units
    Infection:
    No groups remain.
    This boost would allow the immune system's armies to win! It would be left with 51 units.

    You don't even know how you could boost the reindeer's immune system or what effect it might have, 
    so you need to be cautious and find the smallest boost that would allow the immune system to win.

    How many units does the immune system have left after getting the smallest boost it needs to win?
    */
    public class Day24 : Day
    {
        public override string Title => "2018 - Day 24: Immune System Simulator 20XX";

        public override void PartOne()
        {
            base.PartOne();
            var combatingGroups = new List<Group>();
            //GetTestGroups(combatingGroups);
            GetGroups(combatingGroups);

            while (true)
            {
                foreach (var group in combatingGroups
                    .Where(x => !x.Annihilated)
                    .OrderByDescending(o => o.EffectivePower)
                    .ThenByDescending(t => t.UnitInitiative))
                {
                    group.SelectTarget(combatingGroups
                        .Where(x => x.Type != group.Type && x.IsSelected == false && !x.Annihilated).ToList());
                }

                foreach (var group in combatingGroups
                    .Where(x => !x.Annihilated)
                    .OrderByDescending(o => o.UnitInitiative))
                {
                    group.Attack();
                }

                if (combatingGroups
                    .Where(x => !x.Annihilated)
                    .Select(s => s.Type)
                    .Distinct().Count() < 2)
                {
                    break;
                }
            }

            var res = combatingGroups
                    .Where(x => !x.Annihilated).Sum(s => s.Units);

            Console.WriteLine(res); // 23385
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var boost = 1;
            while (true)
            {
                var combatingGroups = new List<Group>();
                //GetTestGroups(combatingGroups); 
                GetGroups(combatingGroups);

                combatingGroups.Where(x => x.Type == GroupType.ImmuneSystem).ToList()
                    .ForEach(g => {
                        g.UnitAttackDamage += boost;
                    });

                var drawCounter = 0;
                while (true)
                {
                    var test = combatingGroups
                        .Where(x => !x.Annihilated)
                        .OrderByDescending(o => o.EffectivePower)
                        .ThenByDescending(t => t.UnitInitiative).ToList();
                    foreach (var group in test)
                    {
                        group.SelectTarget(combatingGroups
                            .Where(x => x.Type != group.Type && x.IsSelected == false && !x.Annihilated).ToList());
                    }

                    foreach (var group in combatingGroups
                        .Where(x => !x.Annihilated)
                        .OrderByDescending(o => o.UnitInitiative))
                    {
                        group.Attack();
                    }

                    if (combatingGroups
                        .Where(x => !x.Annihilated)
                        .Select(s => s.Type)
                        .Distinct().Count() < 2)
                    {
                        break;
                    }

                    drawCounter++;

                    if (drawCounter == 10000) // arbitrary abort
                    {
                        break;
                    }
                }

                if (drawCounter == 10000)
                {
                    boost++;
                    continue;
                }

                var unitLeft = combatingGroups
                        .Where(x => !x.Annihilated).Sum(s => s.Units);

                var type = combatingGroups.Where(x => !x.Annihilated).First().Type;

                //Console.WriteLine(type.ToString() + " wins with " + unitLeft + " units");
                //Console.WriteLine();

                if (type == GroupType.ImmuneSystem)
                {
                    Console.WriteLine(type.ToString() + " wins with " + unitLeft + " units"); // 2344
                    break;
                }

                boost++;
            }

            Console.WriteLine("Finished when boost = " + boost);
        }

        private static void GetTestGroups(List<Group> combatingGroups)
        {
            combatingGroups.Add(new Group
            {
                Id = 1,
                Units = 17,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 5390,
                Weaknesses = new List<BattleType> { BattleType.Radiation, BattleType.Bludgeoning },
                AttackType = BattleType.Fire,
                UnitAttackDamage = 4507,
                UnitInitiative = 2
            });
            combatingGroups.Add(new Group
            {
                Id = 2,
                Units = 989,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 1274,
                Immunities = new List<BattleType> { BattleType.Fire },
                Weaknesses = new List<BattleType> { BattleType.Bludgeoning, BattleType.Slashing },
                AttackType = BattleType.Slashing,
                UnitAttackDamage = 25,
                UnitInitiative = 3
            });

            combatingGroups.Add(new Group
            {
                Id = 3,
                Units = 801,
                Type = GroupType.Infection,
                UnitHitPoints = 4706,
                Weaknesses = new List<BattleType> { BattleType.Radiation },
                AttackType = BattleType.Bludgeoning,
                UnitAttackDamage = 116,
                UnitInitiative = 1
            });
            combatingGroups.Add(new Group
            {
                Id = 4,
                Units = 4485,
                Type = GroupType.Infection,
                UnitHitPoints = 2961,
                Immunities = new List<BattleType> { BattleType.Radiation },
                Weaknesses = new List<BattleType> { BattleType.Fire, BattleType.Cold },
                AttackType = BattleType.Slashing,
                UnitAttackDamage = 12,
                UnitInitiative = 4
            });
        }

        private static void GetGroups(List<Group> combatingGroups)
        {
            // 4400 units each with 10384 hit points (weak to slashing) 
            // with an attack that does 21 radiation damage at initiative 16
            combatingGroups.Add(new Group
            {
                Id = 1,
                Units = 4400,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 10384,
                //Immunities = new List<BattleType> { BattleType.Fire },
                Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Radiation,
                UnitAttackDamage = 21,
                UnitInitiative = 16
            });
            //974 units each with 9326 hit points(weak to radiation) 
            //with an attack that does 86 cold damage at initiative 19
            combatingGroups.Add(new Group
            {
                Id = 2,
                Units = 974,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 9326,
                //Immunities = new List<BattleType> { BattleType.Fire },
                Weaknesses = new List<BattleType> { BattleType.Radiation },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 86,
                UnitInitiative = 19
            });
            //543 units each with 2286 hit points with an attack that does 34 cold damage at initiative 13
            combatingGroups.Add(new Group
            {
                Id = 3,
                Units = 543,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 2286,
                //Immunities = new List<BattleType> { BattleType.Fire },
                //Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 34,
                UnitInitiative = 13
            });
            //47 units each with 4241 hit points (weak to slashing, cold; immune to radiation) 
            //with an attack that does 889 cold damage at initiative 10
            combatingGroups.Add(new Group
            {
                Id = 4,
                Units = 47,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 4241,
                Immunities = new List<BattleType> { BattleType.Radiation },
                Weaknesses = new List<BattleType> { BattleType.Slashing, BattleType.Cold },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 889,
                UnitInitiative = 10
            });
            //5986 units each with 4431 hit points with an attack that does 6 cold damage at initiative 8
            combatingGroups.Add(new Group
            {
                Id = 5,
                Units = 5986,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 4431,
                //Immunities = new List<BattleType> { BattleType.Fire },
                //Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 6,
                UnitInitiative = 8
            });
            //688 units each with 1749 hit points (immune to slashing, radiation) 
            //with an attack that does 23 cold damage at initiative 7
            combatingGroups.Add(new Group
            {
                Id = 6,
                Units = 688,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 1749,
                Immunities = new List<BattleType> { BattleType.Slashing, BattleType.Radiation },
                //Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 23,
                UnitInitiative = 7
            });
            //61 units each with 1477 hit points with an attack that does 235 fire damage at initiative 1
            combatingGroups.Add(new Group
            {
                Id = 7,
                Units = 61,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 1477,
                //Immunities = new List<BattleType> { BattleType.Fire },
                //Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Fire,
                UnitAttackDamage = 235,
                UnitInitiative = 1
            });
            //505 units each with 9333 hit points (weak to slashing, cold) 
            //with an attack that does 174 radiation damage at initiative 9
            combatingGroups.Add(new Group
            {
                Id = 8,
                Units = 505,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 9333,
                //Immunities = new List<BattleType> { BattleType.Fire },
                Weaknesses = new List<BattleType> { BattleType.Slashing, BattleType.Cold },
                AttackType = BattleType.Radiation,
                UnitAttackDamage = 174,
                UnitInitiative = 9
            });
            //
            //3745 units each with 8367 hit points(immune to fire, slashing, radiation; weak to cold) 
            //with an attack that does 21 bludgeoning damage at initiative 3
            combatingGroups.Add(new Group
            {
                Id = 9,
                Units = 3745,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 8367,
                Immunities = new List<BattleType> { BattleType.Fire, BattleType.Slashing, BattleType.Radiation },
                Weaknesses = new List<BattleType> { BattleType.Cold },
                AttackType = BattleType.Bludgeoning,
                UnitAttackDamage = 21,
                UnitInitiative = 3
            });
            //111 units each with 3482 hit points with an attack that does 311 cold damage at initiative 15
            combatingGroups.Add(new Group
            {
                Id = 10,
                Units = 111,
                Type = GroupType.ImmuneSystem,
                UnitHitPoints = 3482,
                //Immunities = new List<BattleType> { BattleType.Fire },
                //Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 311,
                UnitInitiative = 15
            });

            //INFECTION
            //2891 units each with 32406 hit points(weak to fire, bludgeoning) 
            //with an attack that does 22 slashing damage at initiative 2
            combatingGroups.Add(new Group
            {
                Id = 11,
                Units = 2891,
                Type = GroupType.Infection,
                UnitHitPoints = 32406,
                //Immunities = new List<BattleType> { BattleType. },
                Weaknesses = new List<BattleType> { BattleType.Fire, BattleType.Bludgeoning },
                AttackType = BattleType.Slashing,
                UnitAttackDamage = 22,
                UnitInitiative = 2
            });
            //1698 units each with 32906 hit points (weak to radiation) 
            //with an attack that does 27 fire damage at initiative 17
            combatingGroups.Add(new Group
            {
                Id = 12,
                Units = 1698,
                Type = GroupType.Infection,
                UnitHitPoints = 32906,
                //Immunities = new List<BattleType> { BattleType. },
                Weaknesses = new List<BattleType> { BattleType.Radiation },
                AttackType = BattleType.Fire,
                UnitAttackDamage = 27,
                UnitInitiative = 17
            });
            //395 units each with 37715 hit points (immune to fire) 
            //with an attack that does 183 cold damage at initiative 6
            combatingGroups.Add(new Group
            {
                Id = 13,
                Units = 395,
                Type = GroupType.Infection,
                UnitHitPoints = 37715,
                Immunities = new List<BattleType> { BattleType.Fire },
                //Weaknesses = new List<BattleType> { BattleType. },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 183,
                UnitInitiative = 6
            });
            //3560 units each with 45025 hit points (weak to radiation; immune to fire) 
            //with an attack that does 20 cold damage at initiative 14
            combatingGroups.Add(new Group
            {
                Id = 14,
                Units = 3560,
                Type = GroupType.Infection,
                UnitHitPoints = 45025,
                Immunities = new List<BattleType> { BattleType.Fire },
                Weaknesses = new List<BattleType> { BattleType.Radiation },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 20,
                UnitInitiative = 14
            });
            //2335 units each with 15938 hit points (weak to cold) 
            //with an attack that does 13 slashing damage at initiative 11
            combatingGroups.Add(new Group
            {
                Id = 15,
                Units = 2335,
                Type = GroupType.Infection,
                UnitHitPoints = 15938,
                //Immunities = new List<BattleType> { BattleType. },
                Weaknesses = new List<BattleType> { BattleType.Cold },
                AttackType = BattleType.Slashing,
                UnitAttackDamage = 13,
                UnitInitiative = 11
            });
            //992 units each with 19604 hit points (immune to slashing, bludgeoning, radiation) 
            //with an attack that does 38 radiation damage at initiative 5
            combatingGroups.Add(new Group
            {
                Id = 16,
                Units = 992,
                Type = GroupType.Infection,
                UnitHitPoints = 19604,
                Immunities = new List<BattleType> { BattleType.Slashing, BattleType.Bludgeoning, BattleType.Radiation },
                //Weaknesses = new List<BattleType> { BattleType. },
                AttackType = BattleType.Radiation,
                UnitAttackDamage = 38,
                UnitInitiative = 5
            });
            //5159 units each with 44419 hit points (immune to slashing; weak to fire) 
            //with an attack that does 13 bludgeoning damage at initiative 4
            combatingGroups.Add(new Group
            {
                Id = 17,
                Units = 5159,
                Type = GroupType.Infection,
                UnitHitPoints = 44419,
                Immunities = new List<BattleType> { BattleType.Slashing },
                Weaknesses = new List<BattleType> { BattleType.Fire },
                AttackType = BattleType.Bludgeoning,
                UnitAttackDamage = 13,
                UnitInitiative = 4
            });
            //2950 units each with 6764 hit points (weak to slashing) 
            //with an attack that does 4 radiation damage at initiative 18
            combatingGroups.Add(new Group
            {
                Id = 18,
                Units = 2950,
                Type = GroupType.Infection,
                UnitHitPoints = 6764,
                //Immunities = new List<BattleType> { BattleType. },
                Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Radiation,
                UnitAttackDamage = 4,
                UnitInitiative = 18
            });
            //6131 units each with 25384 hit points (weak to slashing; immune to bludgeoning, cold) 
            //with an attack that does 7 cold damage at initiative 12
            combatingGroups.Add(new Group
            {
                Id = 19,
                Units = 6131,
                Type = GroupType.Infection,
                UnitHitPoints = 25384,
                Immunities = new List<BattleType> { BattleType.Bludgeoning, BattleType.Cold },
                Weaknesses = new List<BattleType> { BattleType.Slashing },
                AttackType = BattleType.Cold,
                UnitAttackDamage = 7,
                UnitInitiative = 12
            });
            //94 units each with 29265 hit points (weak to cold, bludgeoning) 
            //with an attack that does 588 bludgeoning damage at initiative 20
            combatingGroups.Add(new Group
            {
                Id = 20,
                Units = 94,
                Type = GroupType.Infection,
                UnitHitPoints = 29265,
                //Immunities = new List<BattleType> { BattleType. },
                Weaknesses = new List<BattleType> { BattleType.Cold, BattleType.Bludgeoning },
                AttackType = BattleType.Bludgeoning,
                UnitAttackDamage = 588,
                UnitInitiative = 20
            });
        }
    }
}

public enum GroupType
{
    ImmuneSystem,
    Infection
}

public enum BattleType
{
    Fire,
    Cold,
    Radiation,
    Slashing,
    Bludgeoning
}

public class Group
{
    public int Id;
    public GroupType Type;
    public int Units;
    public int UnitHitPoints;
    public int UnitAttackDamage;
    public int UnitInitiative;
    public List<BattleType> Immunities = new List<BattleType>();
    public List<BattleType> Weaknesses = new List<BattleType>();
    public BattleType AttackType;
    public bool IsSelected = false;
    public bool HasSelected => Target != null;
    public bool Annihilated => Units <= 0;
    public Group Target;

    public int EffectivePower => Units * UnitAttackDamage;

    public void SelectTarget(List<Group> enemies)
    {
        var target = enemies.OrderByDescending(o => o.DamageDealtBy(this))
            .ThenByDescending(t => t.EffectivePower)
            .ThenByDescending(t2 => t2.UnitInitiative).FirstOrDefault();

        if (target == null)
        {
            return;
        }

        if (target.DamageDealtBy(this) == 0)
        {
            return;
        }

        Target = target;
        Target.IsSelected = true;
    }

    public void Attack()
    {
        if (Target == null)
        {
            return;
        }
        else if (Annihilated)
        {
            Target.IsSelected = false;
            Target = null;            
            return;
        }

        var unitsToKill = Target.DamageDealtBy(this) / Target.UnitHitPoints;
        Target.Units -= unitsToKill;

        Target.IsSelected = false;
        Target = null;        
    }

    public int DamageDealtBy(Group enemy)
    {
        if (Immunities.Contains(enemy.AttackType))
        {
            return 0;
        }

        if (Weaknesses.Contains(enemy.AttackType))
        {
            return enemy.EffectivePower * 2;
        }

        return enemy.EffectivePower;
    }
}