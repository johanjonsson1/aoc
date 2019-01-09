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
    public class Day14 : Day
    {
        public override string Title => "2018 - Day 14";

        public override void PartOne()
        {
            base.PartOne();
            return;
            var initialScores = "37".ToInts();
            var manyRecipes = int.Parse("030121");
            var recipes = new CircularRecipes();
            for (int i = 0; i < initialScores.Count; i++)
            {
                recipes.Add(new Recipe { Id = i, Score = initialScores[i] });
            }

            var elfes = new List<KitchenElf> { new KitchenElf(1, recipes._recipes[0]), new KitchenElf(2, recipes._recipes[1]) };

            for (int i = 0; i < manyRecipes+10; i++)
            {
                //Print(recipes, elfes);
                var sum = elfes.Sum(s => s.CurrentRecipe.Score);
                AddNewRecipes(sum, recipes);

                elfes.ForEach(e => e.Step(recipes));
            }

            var result = string.Join("", recipes._recipes.Skip(manyRecipes).Take(10).Select(s => s.Score));
            Console.WriteLine();
            Console.WriteLine(result);
        }

        private void Print(CircularRecipes recipes, List<KitchenElf> elfes)
        {
            foreach (var rec in recipes._recipes)
            {
                if (elfes[0].CurrentRecipe.Equals(rec))
                {
                    Console.Write("(" + rec.Score + ")");
                }
                else if (elfes[1].CurrentRecipe.Equals(rec))
                {
                    Console.Write("[" + rec.Score + "]");
                }
                else
                {
                    Console.Write(" " + rec.Score + " ");
                }
            }

            Console.WriteLine();
        }

        private void AddNewRecipes(int sum, CircularRecipes recipes)
        {
            var ssum = sum.ToString();

            var maxId = recipes._recipes.Max(m => m.Id);

            foreach (var score in ssum)
            {
                recipes.Add(new Recipe { Id = ++maxId, Score = (int)Char.GetNumericValue(score) });
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var initialScores = "37".ToInts();
            var input = "030121";
            var recipes = new FastCircularRecipes();
            for (int i = 0; i < initialScores.Count; i++)
            {
                recipes.Add(initialScores[i]);
            }

            var elfes = new List<FastKitchenElf> { new FastKitchenElf(1, 0, recipes._recipes[0]), new FastKitchenElf(2, 1,recipes._recipes[1]) };

            var breakOut = false;
            while (breakOut == false)
            {           
                //Print(recipes, elfes);
                var sum = elfes.Sum(s => s.CurrentRecipeScore);
                //AddNewRecipes(sum, recipes);
                foreach (var score in sum.ToString())
                {
                    recipes.Add((int)Char.GetNumericValue(score));
                    if (input == recipes.GetLastSix())
                    {
                        breakOut = true;
                        break;
                    }
                }

                elfes[0].Step(recipes);
                elfes[1].Step(recipes);
            }

            var result = recipes._recipes.Count-6;
            Console.WriteLine();
            Console.WriteLine(result);

            Console.WriteLine();
        }
    }

    public class KitchenElf
    {
        public int Id;
        public Recipe CurrentRecipe;

        public KitchenElf(int id, Recipe recipe)
        {
            Id = id;
            CurrentRecipe = recipe;
        }

        public void Step(CircularRecipes cr)
        {
            CurrentRecipe = cr.GetNext(CurrentRecipe, 1 + CurrentRecipe.Score);
        }
    }

    public class FastKitchenElf
    {
        public int Id;
        public int CurrentRecipeIndex;
        public int CurrentRecipeScore;

        public FastKitchenElf(int id, int recipeIndex, int score)
        {
            Id = id;
            CurrentRecipeIndex = recipeIndex;
            CurrentRecipeScore = score;
        }

        public void Step(FastCircularRecipes cr)
        {
            CurrentRecipeIndex = cr.GetNext(CurrentRecipeIndex, 1 + CurrentRecipeScore);
            CurrentRecipeScore = cr._recipes[CurrentRecipeIndex];
        }
    }

    public class FastCircularRecipes
    {
        public List<int> _recipes = new List<int>();

        public void Add(int score)
        {
            _recipes.Add(score);
        }

        public int GetNext(int currentIndex, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                currentIndex = NextIndex(currentIndex);
            }

            return currentIndex;
        }

        public string GetLastSix()
        {
            if (_recipes.Count < 6)
            {
                return string.Empty;
            }

            var s = "";

            for (int i = _recipes.Count - 6; i < _recipes.Count; i++)
            {
                s += _recipes[i];
            }

            return s;
        }

        private int NextIndex(int index)
        {
            index++;
            index %= _recipes.Count;

            return index;
        }

        private int PreviousIndex(int index)
        {
            index--;
            if (index < 0)
            {
                index = _recipes.Count - 1;
            }

            return index;
        }
    }

    public class CircularRecipes
    {
        public List<Recipe> _recipes = new List<Recipe>();
        
        public void Add(Recipe newRecipe)
        {
            _recipes.Add(newRecipe);
        }   

        public Recipe GetNext(Recipe current, int steps)
        {
            var currentIndex = _recipes.IndexOf(current);

            for (int i = 0; i < steps; i++)
            {
                currentIndex = NextIndex(currentIndex);
            }

            return _recipes[currentIndex];
        }

        public string GetLastSix()
        {
            if (_recipes.Count < 6)
            {
                return string.Empty;
            }

            var s = "";

            for (int i = _recipes.Count-6; i < _recipes.Count; i++)
            {
                s += _recipes[i].Score;
            }

            return s;
        }

        private int NextIndex(int index)
        {
            index++;
            index %= _recipes.Count;

            return index;
        }

        private int PreviousIndex(int index)
        {
            index--;
            if (index < 0)
            {
                index = _recipes.Count - 1;
            }

            return index;
        }
    }

    public class Recipe
    {
        public int Id;
        public int Score;
    }
}
