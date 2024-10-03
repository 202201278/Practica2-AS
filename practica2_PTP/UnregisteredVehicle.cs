using System;
namespace practica2_PTP
{
    abstract class UnregisteredVehicle : Vehicle
    {
        private string typeOfVehicle;

        public UnregisteredVehicle(string typeOfVehicle) : base(typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} ";
        }


    }
}

