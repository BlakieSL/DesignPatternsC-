// In case you need some guidance: https://refactoring.guru/design-patterns/adapter
namespace DesignPattern.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem _thirdPartyBillingSystem = new();

        //public void ProcessCompanySalary(...)
        //{
        //    ...
        //}
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            var list = new List<Employee>();
            for (var i = 0; i < employeesArray.GetLength(0); i++)
            {
                var id = Convert.ToInt32(employeesArray[i, 0]);
                var name = employeesArray[i, 1];
                var something = employeesArray[i, 2];
                var number = Convert.ToInt32(employeesArray[i, 3]);
                list.Add(new Employee(id, name, something, number));
            }

            _thirdPartyBillingSystem.ProcessSalary(list);
        }
    }
}
