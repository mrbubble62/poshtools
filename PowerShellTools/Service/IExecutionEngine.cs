﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellTools.Service
{
    internal interface IExecutionEngine
    {
        bool ExecutePowerShellCommand(string command);

        Task<bool> ExecutePowerShellCommandAsync(string command);
    }
}
