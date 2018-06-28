using System;
using System.Collections.Generic;
using System.Text;

namespace Caf.Etl.Pipes
{
    public interface IPipeData
    {
        void Extract();
        void Transform();
        void Load();
    }
}
