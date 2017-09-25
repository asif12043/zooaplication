using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZooApplication.Models
{
    public class ViewFoodAnimalTotal
    {

        public ViewFoodAnimalTotal()
        {

        }

        public ViewFoodAnimalTotal(AnimalFood animalFood)
        {
            Id = animalFood.Id;
            AnimalName = animalFood.Animal.Name;
            TotalQuantity = animalFood.Quantity * animalFood.Animal.Quantity;
            TotalPrice = animalFood.Quantity * animalFood.Animal.Quantity * animalFood.Food.Price;

        }

        public string AnimalName { get; set; }
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public double TotalQuantity { get; set; }
    }
}