using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // This interface defines a contract that any implementing class must follow.
    public interface IQuittable
    {
        // This method must be implemented by any class that inherits this interface.
        void Quit();
    }
}
