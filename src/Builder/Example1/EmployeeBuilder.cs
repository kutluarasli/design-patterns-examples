using System;

namespace DesignPatternExamples.Builder.Example1
{
    public class EmployeeBuilder
    {
        public static readonly decimal MinimumWage = 100;
        public static readonly EmployeeType DefaultType = EmployeeType.Internal;

        private string _fullName;
        private readonly DateTime _birthday;
        private decimal _salary = MinimumWage;
        private EmployeeType _type = DefaultType;
        private string _favoriteMovie;

        public EmployeeBuilder(string fullName, DateTime birthday)
        {
            _fullName = fullName;
            _birthday = birthday;
        }

        public EmployeeBuilder WithSalary(decimal salary)
        {
            _salary = salary;
            return this;
        }

        public EmployeeBuilder WithFavoriteMovie(string favoriteMovie)
        {
            _favoriteMovie = favoriteMovie;
            return this;
        }

        public EmployeeBuilder WithType(EmployeeType type)
        {
            _type = type;
            return this;
        }

        public Employee Build()
        {
            var employee = new Employee
            {
                Id = Guid.NewGuid(),
                Birthday = _birthday,
                Salary = _salary,
                Type = _type,
                FavoriteMovie = _favoriteMovie,
                FullName = _fullName
            };

            return employee;
        }

    }
}