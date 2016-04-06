using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encriptado_v1
{
    interface encriptor
    {
       int[] keyfix(String key);
       int getbyte(int[] key);
       String encripting(int[] key, String subject);
       String decripting(int[] key, String subject);
       void mask(int key, ref char[] subject);
    }
}
