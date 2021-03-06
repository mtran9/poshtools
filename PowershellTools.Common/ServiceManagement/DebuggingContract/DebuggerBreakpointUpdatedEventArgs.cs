﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellTools.Common.ServiceManagement.DebuggingContract
{
    [DataContract]
    public class DebuggerBreakpointUpdatedEventArgs
    {
        [DataMember]
        public PowershellBreakpoint Breakpoint;

        [DataMember]
        public BreakpointUpdateType UpdateType;

        public DebuggerBreakpointUpdatedEventArgs(PowershellBreakpoint breakpoint, BreakpointUpdateType updateType)
        {
            Breakpoint = breakpoint;
            UpdateType = updateType;
        }
    }
}
