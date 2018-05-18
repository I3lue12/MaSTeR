using System;
using System.Collections.Generic;
using System.Text;

namespace Library_learning
{
    [Serializable()] 
    class SSNMalFormException :System.Exception
    {
        public SSNMalFormException() : base() { }
        public SSNMalFormException(string message) : base(message) { }
        public SSNMalFormException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected SSNMalFormException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
