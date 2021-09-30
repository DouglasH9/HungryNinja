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
                object randFood = Menu[rand.Next(1,8)];
                return randFood;

            }
        }
    class Ninja
        {
            private int calorieIntake;
            public List<Food> FoodHistory;
            
            public Ninja()
            
            public void Eat(Food item)
            {
            }
        }

cop

}