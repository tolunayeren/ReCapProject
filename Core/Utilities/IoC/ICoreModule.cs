using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    //Bizim core katmanımızdaki bağımlılıkları yönetebilmek adına oluşturduk.
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection); //bağımlılıkları yüklemek için oluşturdum.

    }
}
