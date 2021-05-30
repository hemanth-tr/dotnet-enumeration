using System;
using System.Collections;
using System.Collections.Generic;

namespace Enumeration
{
    internal class UsersEnumerator : IEnumerator<User>
    {
        private readonly User[] _users;

        private int _index = -1;

        public UsersEnumerator(User[] users)
        {
            this._users = users;
        }

        public User Current { get; private set; }

        object IEnumerator.Current => null;

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            this._index++;

            try
            {
                this.Current = this._users[_index];
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                this.Current = null;
                this._index = -1;
            }

            return false;
        }

        public void Reset()
        {
            this._index = -1;
            this.Current = null;
        }
    }
}