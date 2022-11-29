namespace FactoryPattern {
    class Bike:IVehicle {
        private readonly int _wheels;
        public Bike() {
            this._wheels = 2;
        }

        public int NumberOfWheels()
        {
            return this._wheels;
        }

        public string VehicleType()
        {
            return "Bike class";
        }
    }
}