using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerApp.Data
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public interface IFoodService
    {
        IEnumerable<Food> GetFoods();
    }

    public class FoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>() {
                new Food() {Name="비빔밥", Price=7000},
                new Food() {Name="김밥", Price=3000},
                new Food() {Name="보쌈", Price=9000},
            };
            return foods;
        }
    }

    public class FastFoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>() {
                new Food() {Name="햄버거", Price=3000},
                new Food() {Name="튀김", Price=1000}
            };
            return foods;
        }
    }
}
