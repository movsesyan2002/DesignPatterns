interface ICarParts {
    IEngine CreateEngine(double LiterOrKw);
    IFuelSystem CreateFuelSystem();
}

interface IEngine {
    void GetInfo();
}

interface IFuelSystem {
    void GetInfo();
}


class DieselCarParts : ICarParts {
    public IEngine CreateEngine(double LiterOrKw) {
        return new DieselEngine(LiterOrKw);
    }

    public IFuelSystem CreateFuelSystem() {
        return new DieselFuelSystem();
    }
}


class ElectricCarParts : ICarParts {
    public IEngine CreateEngine(double LiterOrKw) {
        return new ElectricEngine(LiterOrKw);
    }

    public IFuelSystem CreateFuelSystem() {
        return new ElectricFuelSystem();
    }
}

class DieselEngine : IEngine {

    public double Liter {get; set;}

    public DieselEngine (double LiterOrKw) {
        this.Liter = LiterOrKw;
    }

    public void GetInfo() {

        Console.WriteLine($"The motor liter is {this.Liter}");
        Console.WriteLine("The Engine is diesel");

    }

}


class ElectricEngine : IEngine {

    public double KW {get; set;}

    public ElectricEngine (double LiterOrKw) {
        this.KW = LiterOrKw;
    }
    public void GetInfo() {

        Console.WriteLine($"The motor liter is {this.KW}");
        Console.WriteLine("The Engine is electric");
        
    }

}

class DieselFuelSystem : IFuelSystem {

    public void GetInfo() {
        Console.WriteLine("This is a diesel car fuel system");
    }
}


class ElectricFuelSystem : IFuelSystem {

    public void GetInfo() {
        Console.WriteLine("This is a electric car fuel system");
    }
}