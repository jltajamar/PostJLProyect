using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostJLProyect.Models
{
    public class RepositoryUser
    {

        UserContext context;

        public RepositoryUser()
        {

            this.context = new UserContext();

        }


        public List<User> GetUsers()
        {

            return this.context.Users.ToList();

        }


        public User BuscarUser(int id)
        {

            return this.context.Users.Single(z => z.id == id);

        }

        
        
        public void CreateUser(string name, string surname, string pw)
        {
            User u = new User();
            u.Name = name;
            u.Surname = surname;
            u.Password = pw;
            this.context.Users.Add(u);
            this.context.SaveChanges();
           
        }

        public int GetOdd()
        {

            Random rand = new Random((int)DateTime.Now.Ticks);
            int numIterations = 0;
            numIterations = rand.Next(0, 15);
            return numIterations;
            //Response.Write(numIterations.ToString());

        }
        
        public void EliminarUser(int id)
        {

            User user = this.BuscarUser(id);
            this.context.Users.Remove(user);
            this.context.SaveChanges();

        }
        
    }
}