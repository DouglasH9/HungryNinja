using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
        {
            public string Name;
            public int Calories;
            // Foods can be Spicy and/or Sweet
            public bool IsSpicy; 
            public bool IsSweet; 
            // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
            public Food(string name, int cals, bool isSpc, bool isSwt)
            {
                Name = name;
                Calories = cals;
                IsSpicy = isSpc;
                IsSweet = isSwt;
            }
        }

    class Buffet
        {
            public List<Food> Menu;
             
            //constructor
            public Buffet()
            {
                Menu = new List<Food>()
                {
                    new Food("Pizza", 500, false, false),
                    new Food("Taco", 450, true, false),
                    new Food("Sub", 650, false, false),
                    new Food("Cookie", 300, false, true),
                    new Food("Turkey", 325, false, false),
                    new Food("Meatloaf", 400, false, false),
                    new Food("Ramen", 500, true, false)
                };
            }
             
            public Food Serve()
            {
                Random rand = new Random();
                return Menu[rand.Next(Menu.Count)];
            }
        }
    class Ninja
        {
            private int calorieEaten;
            public List<Food> History;
            
            public Ninja()
            {
                caloriesEaten = 0;
                History = new List<Food>();
            }

            public bool IsFull
            {
                get {return caloriesEaten > 1200;}
            }

            public bool Eat(Food meal)
            {
                if (!IsFull)
                {
                    CaloriesEaten += meal.Calories;
                    History.Add(meal);
                    Console.WriteLine($"Eating some {meal}...");
                }
                else 
                {
                    Console.WriteLine("Ninja is stuffed! Can't eat anymore!");
                }
                return IsFull;
            }
        }
}