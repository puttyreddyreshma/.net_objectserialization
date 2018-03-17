using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;


namespace ClassLibrary12
{
    [Serializable]
    public class Class1
    {
        int i, j;
        public void set(int s, int r)
        {
            i = s;
            j = r;
        }
        public int sum()
        {
            return i + j;
        }
        public int product()
        {
            return i * j;
        }

    }
}
