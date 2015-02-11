﻿using PowerShellTools.DebugEngine;
using PowerShellTools.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellTools.Test
{
    class TestExecutionEngine : IExecutionEngine
    {
        private ScriptDebugger _debugger;

        public TestExecutionEngine(ScriptDebugger debugger)
        {
            _debugger = debugger;
        }

        public bool ExecutePowerShellCommand(string command)
        {
            return _debugger.ExecuteInternal(command);
        }

        public Task<bool> ExecutePowerShellCommandAsync(string command)
        {
            return Task.Run(() => ExecutePowerShellCommand(command));
        }
    }
}
