using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookApp
{
    namespace Logic
    {
        namespace ObservantObservee
        {
            public interface IObserver
            {
                void UpdateByState(bool i_State);
            }
        }
    }
}
