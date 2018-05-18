using System;
using System.Collections.Generic;
using System.Text;

namespace Library_learning
{
    [Serializable()]
    class BalanceOverdrawException :System.Exception
    {
        public BalanceOverdrawException() : base() { }
        public BalanceOverdrawException(string message) : base(message) { }
        public BalanceOverdrawException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected BalanceOverdrawException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
