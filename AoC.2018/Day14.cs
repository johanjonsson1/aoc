using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2018
{
    /*
    --- Day 14: Chocolate Charts ---
    You finally have a chance to look at all of the produce moving around. 
    Chocolate, cinnamon, mint, chili peppers, nutmeg, vanilla... the Elves must be growing these plants to make hot chocolate! 
    As you realize this, you hear a conversation in the distance. 
    When you go to investigate, you discover two Elves in what appears to be a makeshift underground kitchen/laboratory.

    The Elves are trying to come up with the ultimate hot chocolate recipe; 
    they're even maintaining a scoreboard which tracks the quality score (0-9) of each recipe.

    Only two recipes are on the board: the first recipe got a score of 3, the second, 7. 
    Each of the two Elves has a current recipe: the first Elf starts with the first recipe, and the second Elf starts with the second recipe.

    To create new recipes, the two Elves combine their current recipes. 
    This creates new recipes from the digits of the sum of the current recipes' scores. 
    With the current recipes' scores of 3 and 7, their sum is 10, and so two new recipes would be created: the first with score 1 and the second with score 0. 
    If the current recipes' scores were 2 and 3, the sum, 5, would only create one recipe (with a score of 5) with its single digit.

    The new recipes are added to the end of the scoreboard in the order they are created. 
    So, after the first round, the scoreboard is 3, 7, 1, 0.

    After all new recipes are added to the scoreboard, each Elf picks a new current recipe. 
    To do this, the Elf steps forward through the scoreboard a number of recipes equal to 1 plus the score of their current recipe. 
    So, after the first round, the first Elf moves forward 1 + 3 = 4 times, while the second Elf moves forward 1 + 7 = 8 times. 
    If they run out of recipes, they loop back around to the beginning. 
    After the first round, both Elves happen to loop around until they land on the same recipe that they had in the beginning; in general, they will move to different recipes.

    Drawing the first Elf as parentheses and the second Elf as square brackets, they continue this process:

    (3)[7]
    (3)[7] 1  0 
     3  7  1 [0](1) 0 
     3  7  1  0 [1] 0 (1)
    (3) 7  1  0  1  0 [1] 2 
     3  7  1  0 (1) 0  1  2 [4]
     3  7  1 [0] 1  0 (1) 2  4  5 
     3  7  1  0 [1] 0  1  2 (4) 5  1 
     3 (7) 1  0  1  0 [1] 2  4  5  1  5 
     3  7  1  0  1  0  1  2 [4](5) 1  5  8 
     3 (7) 1  0  1  0  1  2  4  5  1  5  8 [9]
     3  7  1  0  1  0  1 [2] 4 (5) 1  5  8  9  1  6 
     3  7  1  0  1  0  1  2  4  5 [1] 5  8  9  1 (6) 7 
     3  7  1  0 (1) 0  1  2  4  5  1  5 [8] 9  1  6  7  7 
     3  7 [1] 0  1  0 (1) 2  4  5  1  5  8  9  1  6  7  7  9 
     3  7  1  0 [1] 0  1  2 (4) 5  1  5  8  9  1  6  7  7  9  2 
    The Elves think their skill will improve after making a few recipes (your puzzle input). 
    However, that could take ages; you can speed this up considerably by identifying the scores of the ten recipes after that. 
    
    For example:

    If the Elves think their skill will improve after making 9 recipes, 
    the scores of the ten recipes after the first nine on the scoreboard would be 5158916779 (highlighted in the last line of the diagram).
    After 5 recipes, the scores of the next ten would be 0124515891.
    After 18 recipes, the scores of the next ten would be 9251071085.
    After 2018 recipes, the scores of the next ten would be 5941429882.
    What are the scores of the ten recipes immediately after the number of recipes in your puzzle input?

    --- Part Two ---
    As it turns out, you got the Elves' plan backwards. 
    They actually want to know how many recipes appear on the scoreboard to the left of the first recipes whose scores are the digits from your puzzle input.

    51589 first appears after 9 recipes.
    01245 first appears after 5 recipes.
    92510 first appears after 18 recipes.
    59414 first appears after 2018 recipes.
    How many recipes appear on the scoreboard to the left of the score sequence in your puzzle input?
    */
    public class Day14 : Day
    {
        public override string Title => "2018 - Day 14: Chocolate Charts";

        public override void PartOne()
        {
            base.PartOne();
            var initialScores = "37".ToInts();
            var manyRecipes = int.Parse("030121");
            var recipes = new CircularRecipes();
            for (int i = 0; i < initialScores.Count; i++)
            {
                recipes.Add(new Recipe { Id = i, Score = initialScores[i] });
            }

            var elfes = new List<KitchenElf> { new KitchenElf(1, recipes.Recipes[0]), new KitchenElf(2, recipes.Recipes[1]) };

            for (int i = 0; i < manyRecipes+10; i++)
            {
                //Print(recipes, elfes);
                var sum = elfes.Sum(s => s.CurrentRecipe.Score);
                AddNewRecipes(sum, recipes);

                elfes.ForEach(e => e.Step(recipes));
            }

            var result = string.Join("", recipes.Recipes.Skip(manyRecipes).Take(10).Select(s => s.Score));
            Console.WriteLine();
            Console.WriteLine(result);
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

            var elfes = new List<FastKitchenElf> { new FastKitchenElf(1, 0, recipes.Recipes[0]), new FastKitchenElf(2, 1, recipes.Recipes[1]) };

            var breakOut = false;
            while (breakOut == false)
            {
                var sum = elfes.Sum(s => s.CurrentRecipeScore);
                foreach (var score in sum.ToString())
                {
                    recipes.Add((int)char.GetNumericValue(score));
                    if (input == recipes.GetLastSix())
                    {
                        breakOut = true;
                        break;
                    }
                }

                elfes[0].Step(recipes);
                elfes[1].Step(recipes);
            }

            var result = recipes.Recipes.Count - 6;
            Console.WriteLine(result); // 20287556
        }

        private void Print(CircularRecipes recipes, List<KitchenElf> elfes)
        {
            foreach (var rec in recipes.Recipes)
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
            var sumString = sum.ToString();
            var maxId = recipes.Recipes.Max(m => m.Id);

            foreach (var score in sumString)
            {
                recipes.Add(new Recipe { Id = ++maxId, Score = (int)char.GetNumericValue(score) });
            }
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
            CurrentRecipeScore = cr.Recipes[CurrentRecipeIndex];
        }
    }

    public class FastCircularRecipes
    {
        public List<int> Recipes = new List<int>();

        public void Add(int score)
        {
            Recipes.Add(score);
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
            if (Recipes.Count < 6)
            {
                return string.Empty;
            }

            var s = "";

            for (int i = Recipes.Count - 6; i < Recipes.Count; i++)
            {
                s += Recipes[i];
            }

            return s;
        }

        private int NextIndex(int index)
        {
            index++;
            index %= Recipes.Count;

            return index;
        }

        private int PreviousIndex(int index)
        {
            index--;
            if (index < 0)
            {
                index = Recipes.Count - 1;
            }

            return index;
        }
    }

    public class CircularRecipes
    {
        public List<Recipe> Recipes = new List<Recipe>();
        
        public void Add(Recipe newRecipe)
        {
            Recipes.Add(newRecipe);
        }   

        public Recipe GetNext(Recipe current, int steps)
        {
            var currentIndex = Recipes.IndexOf(current);

            for (int i = 0; i < steps; i++)
            {
                currentIndex = NextIndex(currentIndex);
            }

            return Recipes[currentIndex];
        }

        public string GetLastSix()
        {
            if (Recipes.Count < 6)
            {
                return string.Empty;
            }

            var s = "";

            for (int i = Recipes.Count-6; i < Recipes.Count; i++)
            {
                s += Recipes[i].Score;
            }

            return s;
        }

        private int NextIndex(int index)
        {
            index++;
            index %= Recipes.Count;

            return index;
        }

        private int PreviousIndex(int index)
        {
            index--;
            if (index < 0)
            {
                index = Recipes.Count - 1;
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