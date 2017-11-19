using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFulfilment
{
    public interface IApplicationState
    {
        bool Validate();
        void Create();
        void Exit();
    }
}
