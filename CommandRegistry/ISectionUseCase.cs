using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAS_TERRAIN
{
    interface ISectionUseCase
    {
        string Name { get; }          
        void Run(SectionEnv env);
    }
}
