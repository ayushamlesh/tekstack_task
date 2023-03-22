using LitwareLib;

namespace LitwareLib
{
    public class Employee
    {
        private int _empNo;
        private string _empName;
        private double _salary;
        private double _hra;
        private double _ta;
        private double _da;
        private double _pf;
        private double _tds;
        private double _netSalary;
        private double _grossSalary;

        public Employee(int empNo, string empName, double salary)
        {
            _empNo = empNo;
            _empName = empName;
            _salary = salary;
            CalculateSalary();
        }


        private void CalculateSalary()
        {
            if (_salary < 5000)
            {
                _hra = _salary * 0.10;
                _ta = _salary * 0.05;
                _da = _salary * 0.15;
            }
            else if (_salary < 10000)
            {
                _hra = _salary * 0.15;
                _ta = _salary * 0.10;
                _da = _salary * 0.20;
            }
            else if (_salary < 15000)
            {
                _hra = _salary * 0.20;
                _ta = _salary * 0.15;
                _da = _salary * 0.25;
            }
            else if (_salary < 20000)
            {
                _hra = _salary * 0.25;
                _ta = _salary * 0.20;
                _da = _salary * 0.30;
            }
            else
            {
                _hra = _salary * 0.30;
                _ta = _salary * 0.25;
                _da = _salary * 0.35;
            }

            _grossSalary = _salary + _hra + _ta + _da;
            _pf = _grossSalary * 0.10;
            _tds = _grossSalary * 0.18;
            _netSalary = _grossSalary - (_pf + _tds);
        }

        public int EmpNo
        {
            get { return _empNo; }
        }

        public string EmpName
        {
            get { return _empName; }
        }

        public double Salary
        {
            get { return _salary; }
        }

        public double HRA
        {
            get { return _hra; }
        }

        public double TA
        {
            get { return _ta; }
        }

        public double DA
        {
            get { return _da; }
        }

        public double PF
        {
            get { return _pf; }
        }

        public double TDS
        {
            get { return _tds; }
        }

        public double NetSalary
        {
            get { return _netSalary; }
        }

        public double GrossSalary
        {
            get { return _grossSalary; }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Employee Management System");
        Console.WriteLine("=========================");
        Console.WriteLine();

        try
        {
            Console.Write("Enter Employee Number: ");
            int empNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Employee employee = new Employee(empNo, empName, salary);

            Console.WriteLine();
            Console.WriteLine("Employee Information");
            Console.WriteLine("--------------------");
            Console.WriteLine("Employee Number: " + employee.EmpNo);
            Console.WriteLine("Employee Name: " + employee.EmpName);
            Console.WriteLine("Gross Salary: " + employee.GrossSalary);
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

