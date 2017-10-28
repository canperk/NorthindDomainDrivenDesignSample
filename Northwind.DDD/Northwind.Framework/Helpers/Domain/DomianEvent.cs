using System;
using System.Collections.Generic;

namespace Northwind.Framework.Helpers
{
    public abstract class DomainEvent
    {
        public string Type => GetType().Name;
        public DateTime Created { get; private set; }
        public Dictionary<string, Object> Parameters { get; private set; }
        public string CorrelationID { get; set; }

        public DomainEvent()
        {
            Created = DateTime.Now;
            Parameters = new Dictionary<string, Object>();
        }
        public abstract void Simplify();
    }
}
