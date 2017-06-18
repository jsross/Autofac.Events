﻿using System;
using System.Linq;
using Autofac.EventBus.Models;

namespace Autofac.EventBus.Configuration.Attributes
{
    public class StringMatchListenerAttribute : EventListenerAttribute
    {
        private readonly string[] _toMatch;

        public StringMatchListenerAttribute(params string[] toMatch)
        {
            if (toMatch == null)
            {
                throw new ArgumentNullException("toMatch");
            }
            
            _toMatch = toMatch;
        }

        public override bool Evaluate(Event @event)
        {
            return _toMatch.Contains(@event.EventName);
        }

    }
}