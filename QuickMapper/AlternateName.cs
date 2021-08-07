using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMapper
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AlternateName : Attribute
    {
        public List<string> Names { get; set; }
        public AlternateName(string name)
        { 
            Names = new List<string>();
            Names.Add(name);
        }
        public AlternateName(List<string> names)
        { 
            Names = names;
        }
    }
}
