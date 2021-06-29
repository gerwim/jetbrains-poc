using System.Collections.Generic;

namespace JetbrainsAsyncPoc
{
    public class MyModelComparer : IEqualityComparer<MyModel>
    {
        public bool Equals(MyModel x, MyModel y) {
            return x.Name == y.Name &&
                   x.Text == y.Text;
        }

        public int GetHashCode(MyModel obj)
        {
            return obj.Name.GetHashCode() ^
                   obj.Text.GetHashCode();
        }
    }
}