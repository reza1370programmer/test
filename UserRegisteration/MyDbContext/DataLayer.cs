

namespace UserRegisteration.MyDbContext
{
    public class DataLayer
    {
        public UserRegisterationContext _dbcontext { get; set; }
        public DataLayer()
        {
            _dbcontext = new UserRegisterationContext();
        }

        public List<Student> ReturnData()
        {
            return _dbcontext.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            _dbcontext.Students.Add(student);
            _dbcontext.SaveChanges();
        }
        public void UpdateStudent(Student student)
        {
            _dbcontext.Students.Update(student);
            _dbcontext.SaveChanges();
        }
        public void DeleteStudent(Student student)
        {
            _dbcontext.Students.Remove(student);
            _dbcontext.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            return _dbcontext.Students.Find(id);
        }

        public List<Student> SearchStudents(string searchKey)
        {
            return _dbcontext.Students.Where(p => p.FirstName.Contains(searchKey) || p.LastName.Contains(searchKey)).ToList();
        }
     

    }
}
