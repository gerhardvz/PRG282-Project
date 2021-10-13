using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.Business_Layer;
using System.IO;
using PRG282_Group_Project.Exeptions;

namespace PRG282_Group_Project.Data
{
   public class FileHandler
    {

        string filename = "Users";
       public FileHandler()
        {

        }

        public User getUser(string username)
        {
            string[] userstrings = new string[0];
            
            try
            {
                userstrings = File.ReadAllLines(filename);

            }catch(FileNotFoundException ex)
            {
                throw new UserNotFoundException();
            }
            foreach (string userString in userstrings)
            {
                string[] parsedUsername = userString.Split(';');
                if (parsedUsername[0] == username)
                {
                    User user = new User(parsedUsername[0], parsedUsername[1], parsedUsername[2]);
                    return user;
                }
            }
            throw new  UserNotFoundException("User: \""+ username+"\" not found");
        }

        internal string addUser(string nuser)
        {
            throw new NotImplementedException();
        }

        public void addUser(User newUser)
        {
            string[] userList = File.ReadAllLines(filename);
            int duplicate = userList.Where(val => val.StartsWith(newUser.UserName)).Count();
            if (duplicate > 0)
            {
                throw new DuplicateUserException(newUser.UserName);
            }
            File.WriteAllLines(filename, new String[] { newUser.ToString() });
        }

        public void updateUser(User user)
        {
            string[] userList = File.ReadAllLines(filename);

            int duplicate = userList.Where(val => val.StartsWith(user.UserName)).Count();
            if (duplicate <= 0)
            {
                throw new UserNotFoundException(user.UserName);
            }

            for (int i=0; i<userList.Count();i++)
            {
                if (userList[i].StartsWith(user.UserName))
                {
                    userList[i] = user.ToString();
                    break;
                }
            }
            File.WriteAllLines(filename, userList);
        }
        public void deleteUser(User user)
        {
            string[] userList = File.ReadAllLines(filename);

            int duplicate = userList.Where(val => val.StartsWith(user.UserName)).Count();
            if (duplicate <= 0)
            {
                throw new UserNotFoundException(user.UserName);
            }
            userList = userList.Where(val => !val.StartsWith(user.UserName)).ToArray(); //Removes each element that has the same username
            File.WriteAllLines(filename, userList);
        }
    }
}
