using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumeration
{
    internal class EnumerableUsers : IEnumerable<User>
    {
        public User[] Users { private get; init; }

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