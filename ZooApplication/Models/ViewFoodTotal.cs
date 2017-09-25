using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooApplication.Models
{
    public class ViewFoodTotal
    {

        public ViewFoodTotal()
        {

        }

        public ViewFoodTotal(AnimalFood animalFood)
        {
            FoodName = animalFood.Food.Name;
            FoodPrice = animalFood.Food.Price;
            TotalQuantity = animalFood.Animal.Quantity * animalFood.Quantity;
            TotalPrice = animalFood.Food.Price * TotalQuantity;
            Id = animalFood.Id;
            FoodId = animalFood.FoodId;


        }

        public int FoodId { get; set; }

        public string FoodName { get; set; }

        public double FoodPrice { get; set; }

        public int Id { get; set; }

        public double TotalPrice { get; set; }

        public double TotalQuantity { get; set; }
    }
}