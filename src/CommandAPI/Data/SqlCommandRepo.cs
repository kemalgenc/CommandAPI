using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandRepo : ICommandRepo
    {
        CommandContext db;
        public SqlCommandRepo(CommandContext db)
        {
            this.db = db;
        }

        public void Create(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void Delete(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAll()
        {
            return db.CommandItems.ToList();
        }

        public Command GetById(int id)
        {
            return db.CommandItems.Find(id);
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}