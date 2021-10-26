using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc.Data.Abstract {
    public abstract class NamedItemData : UniqueItemData {
        public string Name { get; set; }
    }
}
