namespace CarRental {
    public class VehicleManager {
        public double cr(Vehicle qh) {
            switch (qh.Type) {
                case 1: {
                        // range is calculated as: 
                        // electic charge / consumption per 100km * 100
                        return qh.ElectricCharge / qh.CPK * 100;
                    }
                case 2: {
                        // range is is calculated as: 
                        // fuel / consumption per 100km * 100
                        return qh.Fuel / qh.CPK * 100;
                    }
                case 3: {
                        // range is is calculated as: 
                        // fuel / consumption per 100km * 100
                        return qh.Fuel / qh.CPK * 100;
                    }
            }
            throw new ArgumentOutOfRangeException("x.Type is invalid");
        }
        public void pc(Vehicle lp) {
            // Prints the consumption to the console
            switch (lp.Type) {
                case 1: {
                        Console.WriteLine($"{lp.Model} needs {lp.CPK} kWh/100km");
                        break;
                    }
                case 2: {
                        Console.WriteLine($"{lp.Model} needs {lp.CPK} l/100km");
                        break;
                    }
                case 3: {
                        Console.WriteLine($"{lp.Model} needs {lp.CPK} l/100km");
                        break;
                    }
            }
        }

        public void SelectCarReservations(DateTime validFrom, DateTime validTo,
                                          int type, string model,
                                          double electricCharge, double fuel,
                                          double cpk) {
            if (validFrom > validTo) {
                throw new ArgumentOutOfRangeException(
                    "validFrom cannot be greater then validTo");
            }
            // selecting car reservations from database (code omitted)
        }

        public double CalculateYearlyCosts(Vehicle ug, double kilometers) {
            double costs = 0;
            double tax;
            var noTax = false;
            double pricePerLitrePetrol;
            double pricePerLitreDiesel;
            double pricePerKilowattHour;
            var insurance = (ug.Type == 1 ? 1500 : 1000);

            tax = 650;

            if (ug.Type == 1) {
                noTax = true;
            } else if (ug.Type == 2) {
                noTax = false;
            }
            pricePerLitrePetrol = 1.95;
            pricePerLitreDiesel = 2.10;
            pricePerKilowattHour = 0.27;

            // calculate the yearly costs. this is done with 
            // (insurance costs + tax costs + fuel costs)
            if (ug.Type == 1) {
                return insurance + (noTax ? 0 : tax) + (kilometers * ug.CPK / 100)
                          + pricePerKilowattHour;
            }
            if (ug.Type == 2) {
                return insurance + (noTax ? 0 : tax) + (kilometers * ug.CPK / 100)
                          + pricePerLitrePetrol;
            }
            if (ug.Type == 3) {
                return insurance + (noTax ? 0 : tax) + (kilometers * ug.CPK / 100)
                          + pricePerLitreDiesel;
            }

            throw new ArgumentOutOfRangeException("x.Type is invalid");
        }
    }

}
