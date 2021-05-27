using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            var enumerableUsers = new EnumerableUsers { Users = new User[2] { new User { Name = "Hemanth", Age = 27 }, new User { Name = "Kumar", Age = 27 } } };
            enumerableUsers.Add(new User { Name = "HemanthKumar", Age = 27 });

            int i = 0;
            foreach (var user in enumerableUsers)
            {
                i++;
                Console.WriteLine(i);
                Console.WriteLine(user.Name);
            }
        }
    }

    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class EnumerableUsers : IEnumerable<User>, ICollection<User>
    {
        public User[] Users { private get; set; }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(User item)
        {
            var x = Users;
            Array.Resize(ref x, this.Users.Length + 1);
            x[this.Users.Length] = item;
            this.Users = x;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(User item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(User[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<User> GetEnumerator()
        {
            return new UsersEnumerator(this.Users);
        }

        public bool Remove(User item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new UsersEnumerator(this.Users);
        }
    }

    class UsersEnumerator : IEnumerator<User>
    {
        private User[] users;

        private int index = -1;

        public UsersEnumerator(User[] users)
        {
            this.users = users;
        }

        public User Current { get; private set; }

        object IEnumerator.Current => null;

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            this.index++;

            try
            {
                this.Current = this.users[index];
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                this.Current = null;
                this.index = -1;
            }

            return false;
        }

        public void Reset()
        {
            this.index = -1;
            this.Current = null;
        }
    }
}
