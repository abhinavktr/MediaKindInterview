using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOne
{
    public class IQueryableSample
    {
        public Expression<Func<User, bool>> FilterUsersExpression(int age, string startsWith) //Expression<Func<User, bool>>
        {
            return u => u.Age > age && u.Surname.StartsWith(startsWith);
        }

        public IEnumerable<User> ReturnsUsers(IDbContext dbContext)
        {
            IQueryable<User> users = dbContext.GetUsers(FilterUsersExpression(30, "V"));

            Console.WriteLine(users.Expression);

            MyList<User> usersList = new MyList<User>();

            IQueryable<User> filterQuery = from user in users
                                           select user;
            //where user.Age > 30 && user.Surname.StartsWith("V")
            //select user;

            IQueryable<User> filterMore = filterQuery.Where(user => user.Age > 30 && user.Surname.StartsWith("V"));

            return users.ToList();
        }
    }

    public class User
    {
        public string Name;
        public string Surname;
        public int Age;
    }
    public interface IDbContext
    {
        IQueryable<User> GetUsers(Expression<Func<User, bool>> filter);
    }

    //public class DbContext : IDbContext
    //{
    //    public IQueryable<User> GetUsers(Expression<Func<User, bool>> filter)
    //    {
    //        List<User> user = new List<User>()

    //        return usersQuery;
    //    }
    //}
}
