using System;

namespace InventorySystem.CoreBusiness
{
    public class Inventory
    {
        public int ID { get; set; } 
        public string Name { get; set; }  = string.Empty;
        public DateTime dateEntered {get;set;} = DateTime.UtcNow;
}}