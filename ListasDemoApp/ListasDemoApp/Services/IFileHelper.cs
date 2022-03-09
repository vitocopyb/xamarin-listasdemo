using System;
using System.Collections.Generic;
using System.Text;

namespace ListasDemoApp.Services
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
