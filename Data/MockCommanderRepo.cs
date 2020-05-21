using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
             var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Strech", Line="Lower Back", Platform = "Floor"},
                new Command{Id=1, HowTo="Strengh", Line="Lower Back", Platform = "Floor"},
                new Command{Id=2, HowTo="Relax", Line="Lower Back", Platform = "Floor"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
             return new Command{Id=0, HowTo="Strech", Line="Lower Back", Platform = "Floor"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}