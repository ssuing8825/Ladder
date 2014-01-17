using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladder.Model
{
    public class Player
    {
        public static readonly string NodeTypeKey = "PERSON";

        public string Name { get; set; }
        public string NodeType
        {
            get { return NodeTypeKey; }
        }
    }
}
