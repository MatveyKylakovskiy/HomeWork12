
using System.Linq;

namespace HomeWork12.SecondTask
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public User(string firstName, string middleName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = "null";
        }

        public void GetFullName(List<User> users)
        {
            foreach (var user in users)
            {
                if(user.LastName == "null")
                {
                    Console.WriteLine($"FirstName: {user.FirstName}, MiddleName: {user.MiddleName}");
                }

                else { Console.WriteLine($"FirstName: {user.FirstName}, MiddleName: {user.MiddleName}, LastName: {user.LastName}"); }
            }
        }

        public List<User> SotredUsers(List<User> users)
        {   
           return users.OrderByDescending( u => u.LastName ).ToList();
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is User user)
            {
                return user.LastName == LastName;
            }

            return false;
        }
    }
}





/*дан класс
public class User
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public User(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
}
Напишите метод, который возвращает "<FirstName> <MiddleName>
<LastName>", если отчество присутствует Или "<FirstName> <LastName>", если
отчество отсутствует.
-Напишите метод, который возвращает предоставленный список пользователей,
упорядоченный по LastName в порядке убывания.*/