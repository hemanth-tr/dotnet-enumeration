using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumeration
{
    internal class EnumerableUsers : IEnumerable<User>, ICollection<User>
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
}