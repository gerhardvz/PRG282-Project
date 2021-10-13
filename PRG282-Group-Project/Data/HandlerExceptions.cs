using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Group_Project.Exeptions
{
    public class UserException : Exception
    {
        public UserException(string exception):base(exception)
        {
            
        }
        public UserException() : base("User Exception")
        {

        }
    }

    public class UserNotFoundException : UserException
    {
        public UserNotFoundException(string username): base($"User: \"{username}\" not found")
        {
           
        }
        public UserNotFoundException() : base($"Users not found")
        {

        }
    }

    public class DuplicateUserException:UserException
    {
        public DuplicateUserException():base("Duplicate user found")
        {

        }
        public DuplicateUserException(string username) : base($"Duplicate user found: {username}")
        {

        }
    }

    public class StudentException : Exception
    {
       public StudentException() : base("Student Exception")
        {

        }
        public StudentException(string exception) : base(exception)
        {

        }
    }

    public class StudentNotFoundException : StudentException
    {
       public StudentNotFoundException() : base("Students not found")
        {

        }
       public StudentNotFoundException(int studentid) : base($"Student with id: {studentid} not found")
        {

        }

       
    }

    public class DuplicateStudentException : StudentException
    {
        public DuplicateStudentException(int studentid) : base($"Duplicate students found with id : {studentid}")
        {

        }
        public DuplicateStudentException() : base($"Duplicate students found")
        {

        }
    }
}
