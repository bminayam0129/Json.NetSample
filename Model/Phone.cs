using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json.NetSample.Model
{
    public class Phone
    {
        public string name {  get; set; }
        public string number { get; set; }
        public string Number { get; internal set; }
    }
}
