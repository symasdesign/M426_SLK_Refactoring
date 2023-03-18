namespace CarRental {
    internal class Program {
        static void Main(string[] args) {

            var v1 = new Vehicle {
                Type = 1,
                Model = "Audi etron",
                CPK = 20.1,
                ElectricCharge = 95,
                Unit = "kWh/100km"
            };
            var v2 = new Vehicle { 
                Type = 2, 
                Model = "Audi RSQ8", 
                CPK = 14.2, 
                Fuel = 87.5, 
                Unit = "l/100km" 
            };
            var v3 = new Vehicle { 
                Type = 2, 
                Model = "Toyota Yaris", 
                CPK = 3.8, 
                Fuel = 22.3, 
                Unit = "l/100km" 
            };
            var v4 = new Vehicle { 
                Type = 1, 
                Model = "Seat Cupra Born", 
                CPK = 15.5, 
                ElectricCharge = 58, 
                Unit = "kWh/100km" 
            };
            var v5 = new Vehicle { 
                Type = 3, 
                Model = "BMW X5M", 
                CPK = 12.5, 
                Fuel = 58, 
                Unit = "l/100km" 
            };

            var vl = new List<Vehicle>();
            vl.AddRange(new[] { v1, v2, v3, v4, v5 });

            var manager = new VehicleManager();
            foreach (var v in vl) {
                var costs = manager.CalculateYearlyCosts(v, 10000);
                Console.WriteLine($"yearly costs for 10000km {v.Model}: {costs}");
            }
        }
    }
}