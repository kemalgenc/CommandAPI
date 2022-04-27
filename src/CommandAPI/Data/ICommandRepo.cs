using CommandAPI.Models;

namespace CommandAPI.Data
{
    public interface ICommandRepo{
        IEnumerable<Command> GetAll();
        Command GetById(int id);
        void Create(Command cmd);
        void Update(Command cmd);
        void Delete(Command cmd);
        bool SaveChanges();
    }
}