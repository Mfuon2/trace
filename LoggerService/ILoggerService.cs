using System;
using System.Collections.Generic;
using System.Text;

namespace LibTest.LoggerService
{
    public interface ILoggerService
    {
        string Warn(string warning);
        string Error(string warning);
        string Info(string warning);
        string Default(string warning);
    }
}
