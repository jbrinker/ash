using ASH.API.Models;
using ASH.DataAccess;

namespace ASH.API.Mappings
{
    public class EmployeeMapping
    {
        public Person ToEntity(Employee employee)
        {
            Person person = new Person
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address1 = employee.Address1,
            };

            if (employee.Role == EmployeeTypes.Employee)
            {
                NonExemptPay nonExemptPay = new NonExemptPay
                {
                    PayPerHour = employee.PaymentAmount,
                    Person = person
                };
                person.NonExemptPay = nonExemptPay;
            }
            else if (employee.Role == EmployeeTypes.Supervisor || employee.Role == EmployeeTypes.Manager)
            {
                ExemptPay exemptPay = new ExemptPay
                {
                    AnnualSalary = employee.PaymentAmount,
                    Person = person
                };
                person.ExemptPay = exemptPay;
            }
            else
                throw new NotImplementedException("Unknown Role.");

            if(employee.Role == EmployeeTypes.Manager)
            {
                Expenses expenses = new Expenses
                {
                     MaxExpenseAmount = employee.PaymentAmount,
                     Person = person
                };
                person.Expenses = expenses;
            }

            return person;
        }

        public Employee ToModel(Person person) 
        {
            Employee employee = new Employee
            {
                 PersonId = person.PersonId,
                 FirstName = person.FirstName,
                 LastName = person.LastName,
                 Address1 = person.Address1,
            };

            if (person.NonExemptPay != null && person.ExemptPay != null)
                throw new InvalidOperationException("An employee cannot be Exempt and NonExempt for a single payment.");
            else if(person.NonExemptPay != null)
            {
                employee.Role = EmployeeTypes.Employee;
                employee.PaymentAmount = person.NonExemptPay.PayPerHour;
            }
            else if(person.ExemptPay != null)
            {
                employee.PaymentAmount = person.ExemptPay.AnnualSalary;

                if (person.Expenses != null)
                {
                    employee.Role = EmployeeTypes.Manager;
                    employee.MaxExpenseAmount = person.Expenses.MaxExpenseAmount;
                }
                else
                    employee.Role = EmployeeTypes.Supervisor;
            }
            else
                throw new InvalidOperationException("An employee must have a payment type.");

            return employee;
        }
    }
}
