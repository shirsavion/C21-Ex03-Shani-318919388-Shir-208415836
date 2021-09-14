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
            public interface ISubject
            {
                void Attach(IObserver i_Observer);
                void Detach(IObserver i_Observer);
            }
        }
    }
}
