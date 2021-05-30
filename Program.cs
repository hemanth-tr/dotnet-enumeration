using System;

namespace Enumeration
{
    internal static class Program
    {
        private static void Main()
        {
            var enumerableUsers = new EnumerableUsers { Users = new[] { new User { Name = "name1"}, new User { Name = "name2"} } };

            var i = 0;
            foreach (var user in enumerableUsers)
            {
                i++;
                Console.WriteLine(i);
                Console.WriteLine(user.Name);
            }
        }
    }
}
