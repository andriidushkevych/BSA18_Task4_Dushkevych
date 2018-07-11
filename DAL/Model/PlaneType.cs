using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    public class PlaneType : Entity
    {
        public PlaneType(string model, int capacity, int cargoKg)
        {
            Model = model;
            Capacity = capacity;
            CargoKg = cargoKg;
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public int CargoKg { get; set; }
    }
}
