using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Nonlinear.Graphs
{
    public interface IGraphSearch
    {
        IEnumerable<int> GetPathTo(int toVertexIndex);

        bool HasPathTo(int toVertexIndex);
    }
}
