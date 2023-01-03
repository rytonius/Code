using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsNameCustom
{
    class Employee
    {
        public delegate void PropertyChangedHandler(object sender, PropertyChangeEventArgs args);
        public event PropertyChangedHandler PropertyChange;

        public void OnPropertyChange(object sender, PropertyChangeEventArgs args) {
            //if there exist any subscribers call the event 
            if (PropertyChange != null) {
                PropertyChange(this, args);
            }
        }

        public string Name {get;set;}
        private int _salary = 5000;
        public int Salary {
            get { return _salary; }
            set {
                int oldValue = _salary;
                _salary = value;
                OnPropertyChange(this, new PropertyChangeEventArgs("Salary", value - oldValue));
            }
        }

    }

    public class PropertyChangeEventArgs : EventArgs {
        public string PropertyName {get; internal set;}
        public int Difference {get; internal set;}

        public PropertyChangeEventArgs(string propertyName, int difference) {
            PropertyName = propertyName;
            Difference = difference;
        }
    }

    public static class Program {
        public static void Main() {
            Employee employee = new Employee();
            employee.PropertyChange += new Employee.PropertyChangedHandler(PropertyChanged);
            employee.Salary = 8000;
        }

        public static void PropertyChanged(object sender, PropertyChangeEventArgs args) {
            if (args.PropertyName == "Salary") {
                Console.WriteLine("Salary amount has changed! Salary difference is : " + args.Difference.ToString());
            }
        }
    }
}