using dotnetwithmongo.Entities;

namespace dotnetwithmongo.IRepository
{
    public interface IStudentRepository
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id, Student student);
        void Remove(string id);
    }
}
