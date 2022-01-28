using APIpractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpractice.DataRepo
{
    public class MockCommandRepo : ICommandRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> 
            {
                new Command { ID = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Pot" },
                new Command { ID = 1, HowTo = "Foil an ogg", Line = "Foil Water", Platform = "Bot" },
                new Command { ID = 2, HowTo = "Doil an ugg", Line = "Coil Heater", Platform = "Mot" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { ID = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Pot" };
        }
    }
}
