using Lesson_01_Pr_01.Helpers;
using Lesson_01_Pr_01.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_Pr_01.ViewModel
{
    public class EmployeeListViewModel : ObservableObject
    {
        private Employee selectedEmployee;
        public ObservableCollection<Employee> Employees { get; set; }

        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(obj =>
                {
                    Employee emp = new Employee();
                    Employees.Insert(0 ,emp);
                    SelectedEmployee = emp;
                }));
            }
        }

        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ?? (deleteCommand = new RelayCommand(obj =>
                {
                    Employee emp = new Employee();
                    Employees.Remove(emp);
                    
                }));
            }
        }

        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            }
        }

        public EmployeeListViewModel()
        {
            Employees = new ObservableCollection<Employee>
            {
                new Employee {FirstName = "Ivan", LastName = "Ivanov", Age = 25},
                new Employee {FirstName = "Sergey", LastName = "Sergeev", Age = 29},
                new Employee {FirstName = "Wan", LastName = "Uo", Age = 15}
            };
        }
    }
}
