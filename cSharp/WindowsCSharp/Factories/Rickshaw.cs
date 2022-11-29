namespace FactoryPattern
{
    class Rickshaw : IVehicle
    {
        int _wheels;
        public int NumberOfWheels()
        {
            return this._wheels = 3;
        }

        public string VehicleType()
        {
            return "Rickshaw class";
        }
    }
}