using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCopyDeepCopy
{
    public class Class1
    {
        public int İd { get; set; }
        public string Ad { get; set; }

        public Class1 Clone()
        {
            //MemberWiseClone bir sınıfın içerisinde o sınıftan üretilmiş olan o anki nesneyi clonlamamızı sağlayan bir fonksiyondur
            return (Class1)this.MemberwiseClone();

        }
    }
}
