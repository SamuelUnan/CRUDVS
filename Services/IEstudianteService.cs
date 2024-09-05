using Clase.Models;

namespace Clase.Service.Interface
{
    public interface IEstudianteService
    {
        public List<Estudiante> GetAll();
        public Estudiante GetByID(int id);
        public void Update(Estudiante estudiante);
        public void Add(Estudiante estudiante);
        public void Delete(int id);
    }
}