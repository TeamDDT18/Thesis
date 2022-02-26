using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThesisServer;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Mixing_OPCUA_Server
{
    [DataContract(Namespace = Namespaces.ThesisServer)]

    class ThesisServerConfiguration
    {
        public ThesisServerConfiguration()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
    }
}
