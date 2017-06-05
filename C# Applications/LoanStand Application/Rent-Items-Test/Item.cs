﻿namespace Rent_Items_Test
{
    public enum Type
    {
        ELECTRONICS ,
        OTHER 
    }

        public class Item
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public double Fee { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Type Type { get; set; }
        public int LoanStand { get; set; }
        public Item()
        {
        }
        public string AsString()
        {
            return  "Name: " + Name + " Left in stock: " + Quantity;
        }
    }
}
