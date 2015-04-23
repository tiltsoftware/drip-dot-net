﻿using Drip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropDotNetTests
{
    public class SubscriberFactoryFixture
    {
        public string GetRandomEmailAddress()
        {
            return Guid.NewGuid().ToString("n") + "@" + Guid.NewGuid().ToString("n") + ".com";
        }

        public ModifyDripSubscriberRequest CreateComplexUniqueModifyDripSubscriber()
        {
            var result = new ModifyDripSubscriberRequest
            {
                Email = GetRandomEmailAddress(),
                CustomFields = new Dictionary<string, object>
                { 
                    {"Name", "Foo Example"},
                    {"SomeDate", DateTime.UtcNow},
                    {"AnInt", 123},
                },
                PotentialLead = true,
                Tags = new List<string> { Guid.NewGuid().ToString("n"), "test" }
            };

            return result;
        }
    }
}