using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.ConsoleApp
{
    public interface IAdopter
    {
        public bool pass { get; }
        void AgeCriterion();
    }
}
