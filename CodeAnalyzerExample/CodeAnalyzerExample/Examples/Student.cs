
using Dawn;

namespace CodeAnalyzerExample.Examples
{
    public class Student
    {
        public string FirstName { get; }
        public string LastName { get; }

        public bool IsActive { get; private set; }
        public int RegisteredExams { get; private set; }
        public Student(string firstName, string lastName)
        {
            Guard.Argument(firstName, nameof(firstName)).NotNull().NotEmpty();
            Guard.Argument(lastName, nameof(lastName)).NotNull().NotEmpty();

            FirstName = firstName;
            LastName = lastName;
        }

        // Primjer enkapsulacije.
        public void Disable()
        {
            IsActive = false;
            RegisteredExams = 0;
        }
    }
}
