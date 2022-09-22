using System;

namespace HoistOpcServer
{
    public class OpcEventArgs : EventArgs
    {
        public uint? Value { get; }

        public OpcEventArgs()
        {
        }

        public OpcEventArgs(uint? value)
        {
            Value = value;
        }
    }
}
