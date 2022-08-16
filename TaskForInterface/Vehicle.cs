using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForInterface
{
   abstract class Vehicle
    {
        static decimal _driveTime;
        static decimal _drivePath;
        public decimal DriveTime
        {
            get { return _driveTime; }
            set
            {
                if (value>=0)
                {
                    _drivePath = value;
                } 
            } 
        }
        public decimal DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value >= 0)
                {
                    _drivePath = value;
                }
            }
        }
       
        public virtual void AvarageSpeed(decimal DriveTime, decimal DrivePath) 
        {
            this.DrivePath = DrivePath;
            this.DriveTime = DriveTime;
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
        static decimal _wheelThick;
        public decimal WheelThick { 
            get 
            {
                return _wheelThick;
            } 
            set 
            {
                if (value>=0)
                {
                    WheelThick = value;
                }
            } 
        }
    }

    interface ITransmision 
    {
       
        static decimal _transmissionKind;
        public decimal TransmissionKind
        {
            get
            {
                return _transmissionKind;
            }
            set
            {
                if (value >= 0)
                {
                    _transmissionKind = value;
                }
            }
        }

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
        

        public override void AvarageSpeed(decimal DriveTime, decimal DrivePath)
        {
            Console.WriteLine(DrivePath/DriveTime); 
        }

        public void GetCurrentOil(decimal CurrentOil)
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


        
        


        private double _horsePower;
        public double HorsePower
        {
            get { return _horsePower; }
            set
            {
                if (value>=0)
                {
                    _horsePower = value;
                }
            } }

        public void GetRemainOilAmount(decimal RemainOilAmount)
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

        private decimal _tankSize;
        public decimal Tank
        {
            get { return _tankSize; }
            set
            {
                if (value >= 0)
                {
                    _tankSize = value;
                } 
            } 
        }
        private string _transkind;
        public string TransmisionKind
        {
            get { return _transkind; }
            set
            {
                if (value== "Automatic" || value=="Mechanic")
                {
                    _transkind = value;
                } } }

        public void WheelThickness(decimal WheelThick)
        {
            throw new NotImplementedException();
        }
    }
}
