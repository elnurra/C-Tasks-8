using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForInterface
{
   abstract class Vehicle
    {
        public abstract void DriveTime(decimal DriveTime);
        public abstract void DrivePath(decimal DrivePath);
        public virtual void AvarageSpeed(decimal DriveTime, decimal DrivePath) 
        {
            Console.WriteLine(DrivePath/DriveTime);
        }
    }
    interface IEngine
    {
        static decimal _horsepower ;
        static decimal _tankSize;
        static decimal _currentOil;
        static string _fuelType;
        public decimal HorsePower {
            get 
            {
                return _horsepower;
            }
            set
            {
                if (value>=0)
                {
                    _horsepower = value;
                }
            }
        }
        public decimal TankSize
        {
            get
            {
                return _tankSize;
            }
            set
            {
                if (value >= 0)
                {
                    _tankSize = value;
                }
            }
        }
        public decimal CurrentOil
        {
            get
            {
                return _currentOil;
            }
            set
            {
                if (value >= 0)
                {
                    _currentOil = value;
                }
            }
        }
        public string FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (value == "Regular 92" || value == "Super 95" || value == "Premium 98" || value == "Diesel" )
                {
                    FuelType = value;
                }
            }
        }
        void RemainOilAmount(decimal RemainOilAmount) 
        {
            Console.WriteLine(TankSize-CurrentOil);

        }
    }

    interface IWhell
    {
        void WheelThickness(decimal WheelThick);
    }

    interface ITransmision 
    {
        void TransmissionKind(decimal TransmissionKind );

    }
    class Car :Vehicle ,IEngine, IWhell, ITransmision
    {
        private string _winCode;
        public string  WinCode { 
            get 
            {
                return _winCode;
            }
            set
            {
                if (value.Length==17 && HasUpper(value))
                {
                    _winCode = value;
                }
            } 
        }

        private bool HasUpper(string HasUpper)
        {

            foreach (char item in HasUpper)
            {
                if (char.IsUpper(item))
                {
                    return true;
                }

            }
            return false;
        }
        private int _doorCount = 0;

        public int DoorCount
        {
            get 
            { 
                return _doorCount;
            }
            set
            {
                if (value >= 0 && value <= 6)
                {
                    _doorCount = value;
                }
            }
        }
        public override void DrivePath(decimal DrivePath)
        {
            Console.WriteLine(DrivePath);
        }

        public override void DriveTime(decimal DriveTime)
        {
            Console.WriteLine(DriveTime);
        }

        public override void AvarageSpeed(decimal DriveTime, decimal DrivePath)
        {
            Console.WriteLine(DrivePath/DriveTime); 
        }

        public void CurrentOil(decimal CurrentOil)
        {
            if (CurrentOil>=0)
            {

            Console.WriteLine(CurrentOil);

            }
            else
            {
                Console.WriteLine("Wrong input data: " + CurrentOil);
            }
        }


        public void FuelType(string FuelType)
        {
            Console.WriteLine(FuelType);
        }

        public void HorsePower(decimal HorsePower)

        {
            if (HorsePower>=0)
            {
                Console.WriteLine(HorsePower);
            }
            else 
            {
                Console.WriteLine("Wrong input data: " + HorsePower);
            }
            
        }

        public void RemainOilAmount(decimal RemainOilAmount)
        {
            if (RemainOilAmount>=0)
            {
                Console.WriteLine(RemainOilAmount);
            }
            else
            {
                Console.WriteLine("wrong input data: " + RemainOilAmount);
            }
        }

        public void TankSize(decimal TankSize)
        {
            if (TankSize>=0)
            {

            }
        }

        public void TransmissionKind(decimal TransmissionKind)
        {
            Console.WriteLine();
        }

        public void WheelThickness(decimal WheelThick)
        {
            throw new NotImplementedException();
        }
    }
}
