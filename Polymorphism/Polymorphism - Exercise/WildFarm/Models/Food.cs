﻿namespace WildFarm.Models
{
    public class Food
    {
        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get;  set; }
    }
}
