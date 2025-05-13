interface IComputerBuilder {
    
    IComputerBuilder CpuCreate(string cpu);
    IComputerBuilder RamCreate(string ram);
    IComputerBuilder StorageCreate(string storage);
    IComputerBuilder GpuCreate(string gpu);
    void Reset();
    Computer GetComputer();

}

class Computer {

    public string? Cpu { get; set;}
    public string? Ram { get; set;}
    public string? Storage { get; set;}
    public string? Gpu { get; set;}

    public void ShowComputerInfo() {
        
        if (string.IsNullOrEmpty (Cpu) == false) {
            Console.WriteLine ($"Cpu is {this.Cpu}");
        }

        if (string.IsNullOrEmpty (Ram) == false) {
            Console.WriteLine ($"Ram is {this.Ram}");
        }

        if (string.IsNullOrEmpty (Storage) == false) {
            Console.WriteLine ($"Storage is {this.Storage}");
        }

        if (string.IsNullOrEmpty (Gpu) == false) {
            Console.WriteLine ($"Gpu is {this.Gpu}");
        }

    }

}


class ComputerBuilder : IComputerBuilder {

    private Computer _computer = new Computer();

    public IComputerBuilder CpuCreate(string CpuParameter) {
        _computer.Cpu = CpuParameter;
        return this;
    }

    public IComputerBuilder RamCreate(string RamParameter) {
        _computer.Ram = RamParameter;
        return this;
    }

    public IComputerBuilder StorageCreate(string StorageParameter) {
        _computer.Storage = StorageParameter;
        return this;
    }

    public IComputerBuilder GpuCreate(string GpuParameter) {
        _computer.Gpu = GpuParameter;
        return this;
    }

    public void Reset() {
        _computer = new Computer();
    }

    public Computer GetComputer() {
        Computer computer = new Computer() ;
        computer.Cpu = this._computer.Cpu;
        computer.Ram = this._computer.Ram;
        computer.Storage = this._computer.Storage;
        computer.Gpu = this._computer.Gpu;
        Reset();
        return computer;
    }

}