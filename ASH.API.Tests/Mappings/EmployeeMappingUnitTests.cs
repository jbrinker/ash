using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASH.API.Tests.Mappings
{
    public class EmployeeMappingUnitTests
    {
        [Fact]
        public void EmployeeMapping_WhenToEmployeeIsCalled_AndPersonHasExemptPay_AndPersonHasExpensesInfo_ThenEmployeeIsReturned_AndTheRoleIsManager()
        {

        }

        [Fact]
        public void EmployeeMapping_WhenToEmployeeIsCalled_AndPersonHasExemptPay_AndPersonHasNoExpensesInfo_ThenEmployeeIsReturned_AndTheRoleIsSupervisor()
        {

        }

        [Fact]
        public void EmployeeMapping_WhenToEmployeeIsCalled_AndPersonHasNonExemptPay_ThenEmployeeIsReturned_AndTheRoleIsEmployee()
        {

        }
    }
}
