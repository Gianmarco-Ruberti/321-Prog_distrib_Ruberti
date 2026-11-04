using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODrills
{
    public class Car
    {
        //Brand, Count, Drive, Mileage, Owner, RemainingOwnerChanges, TotalKilometers
        public string Brand { get; }
        public static int Count { get; private set; }
        public void Drive(int Km)
        {
            Mileage += Km;
            TotalKilometers += Km;
        }
        public int Mileage { get; private set; }
        private string _owner;
        public string Owner
        {
            get => _owner;
            set
            {
                if (_ownerChanges >= _maxOwnerChanges)
                    throw new InvalidOperationException($"La voiture ne peut plus changer ({_maxOwnerChanges} changements max)");
                _owner = value;
                _ownerChanges++;
            }
        }
        private readonly int _maxOwnerChanges;
        private int _ownerChanges;
        public int RemainingOwnerChanges => _maxOwnerChanges - _ownerChanges;
        public static int TotalKilometers { get; private set; }

        public Car (string brand, string owner, int maxOwnerChanges):this (brand)
        {
            if (maxOwnerChanges < 0)
                throw new ArgumentOutOfRangeException(nameof(maxOwnerChanges), "Le nombre max de changements ne peut pas être négatif.");

            _maxOwnerChanges = maxOwnerChanges;
            _owner = owner;
        }

        public Car (string brand)
        {
            Brand = brand;
            Count++;
        }
    }
}
