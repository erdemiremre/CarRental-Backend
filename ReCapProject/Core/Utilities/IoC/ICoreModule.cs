using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    //Bizim Core katmanımız için(.NetCore değil)
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
