interface IEmployeeClonable {
    IEmployeeClonable EmployeeClone();
}

class Employee : IEmployeeClonable {

    public string Name {get;set;}
    public string Proffesion {get;set;}

    
    
    public Employee(string name, string proffesion) {
        this.Name = name;
        this.Proffesion = proffesion;
    }

    public IEmployeeClonable EmployeeClone() {
        Employee employee = new Employee(this.Name,this.Proffesion);
        return employee;
    }
    
}