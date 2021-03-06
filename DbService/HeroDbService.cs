﻿using Interfaces.DbService;
using System;

namespace DbService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HeroDbService : IHeroDbService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string DbProjectServiceCall()
        {
            return "Hello, i am service that will return data from database.";
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Heeeeeeellooooooooo {name}! How ya doin?");
        }
    }
}
