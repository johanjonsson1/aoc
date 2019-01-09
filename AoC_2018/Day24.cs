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
    public class Day24 : Day
    {
        public override string Title => "2018 - Day 24";

        public override void PartOne()
        {
            base.PartOne();
            return;

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

            Console.WriteLine(res);
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
                    
                    if (drawCounter == 10000)
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
                    Console.WriteLine(type.ToString() + " wins with " + unitLeft + " units");
                    break;
                }

                boost++;
            }

            Console.WriteLine("Finished when boost = " + boost);
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

