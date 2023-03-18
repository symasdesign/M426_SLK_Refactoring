namespace CarRental {
    public class Vehicle {
        public int Type { get; set; } // 1 = electric, 2 = petrol, 3 = diesel
        public string Model { get; set; }
        public double ElectricCharge { get; set; } // in kWh
        public double Fuel { get; set; }

        // Consumption per 100 kilometer (kWh/100km or l/100km)
        public double CPK { get; set; }
        public string Unit { get; set; } // Unit of cpk e.g. l/100km
    }
}
