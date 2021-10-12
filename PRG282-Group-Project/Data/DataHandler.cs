using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Group_Project.DataTypes;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;


namespace PRG282_Group_Project.NewFolder1
{
    public class DataHandler
    {
        string connectionPath = "Data Source= (local); Initial Catalog= BC_Informatics; Integrated Security=True";

        public Student getStudent(Student student)
        {
            return getStudent(student.getStudentNumber());
        }

        public Student getStudent(int id)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionPath))
                {
                    Student stud;
                    string command = $"Select id,name,surname,image,dob,gender,phone,address FROM Student WHERE id={id}";

                    string modulescmd = $"Select module FROM StudentModules WHERE id={id}";
                    conn.Open();



                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        throw new Exception("No students found with id");
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        throw new Exception("To many students with same ID.");
                    }
                    else
                    {
                        SqlDataAdapter modulesAdapter = new SqlDataAdapter(modulescmd, conn);
                        DataTable modulesDt = new DataTable();
                        modulesAdapter.Fill(modulesDt);
                        List<String> moduleList = new List<String>();

                        foreach (DataRow dataRow in modulesDt.Rows)
                        {
                            moduleList.Add((string)dataRow["module"]);
                        }
                        byte[] imgBytes = (byte[])dt.Rows[0]["image"];
                        MemoryStream ms = new MemoryStream(imgBytes);
                        Image img = Image.FromStream(ms);
                        string format = "ddd MMM dd yyyy 'GMT'zzz '(GMT Daylight Time)'";

                        DateTime dob = DateTime.ParseExact((string)dt.Rows[0]["dob"], format, System.Globalization.CultureInfo.InvariantCulture);

                        stud = new Student(Convert.ToInt32(dt.Rows[0]["id"]), (string)dt.Rows[0]["name"], (string)dt.Rows[0]["surname"], img, dob, (char)dt.Rows[0]["gender"], (string)dt.Rows[0]["phone"], (string)dt.Rows[0]["address"], moduleList);
                    }
                    return stud;
                }
            }
            catch (SqlException e)
            {

            }
            throw new NotImplementedException();
        }

        public DataTable getStudents()
        {
           
                using (SqlConnection conn = new SqlConnection(connectionPath))
                {
                    string cmd = $"Select * FROM student";
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    return dt;
                }

        }

        public List<Student> getStudentList()
        {
            
            DataTable dt = getStudents();
            List<Student> studentList = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                
                
                byte[] imgBytes = (byte[])dt.Rows[0]["image"];
                MemoryStream ms = new MemoryStream(imgBytes);
                Image img = Image.FromStream(ms);
                string format = "ddd MMM dd yyyy 'GMT'zzz '(GMT Daylight Time)'";

                DateTime dob = DateTime.ParseExact((string)dt.Rows[0]["dob"], format, System.Globalization.CultureInfo.InvariantCulture);

                Student student = new Student(Convert.ToInt32(dt.Rows[0]["id"]), (string)dt.Rows[0]["name"], (string)dt.Rows[0]["surname"], img, dob, (char)dt.Rows[0]["gender"], (string)dt.Rows[0]["phone"], (string)dt.Rows[0]["address"], moduleList);
                 List<string> moduleList = getStudentModuleList(student);
                student.setModules(moduleList);
                studentList.Add(student);
            
            }

                //TODO
                return studentList;
        }


        public DataTable getStudentModules(Student student)
        {
            using (SqlConnection conn = new SqlConnection(connectionPath))
            {
                string modulescmd = $"Select module FROM StudentModules WHERE id={student.getStudentNumber()}";
                SqlDataAdapter modulesAdapter = new SqlDataAdapter(modulescmd, conn);
                DataTable modulesDt = new DataTable();
                modulesAdapter.Fill(modulesDt);

                return modulesDt;
            }

            }
      
        public List<string> getStudentModuleList(Student student)
        {
            DataTable dt = getStudentModules(student);
            List<string> moduleList = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
               
                moduleList.Add((string)row["code"]);
            }

            return moduleList;
        }

        public void addStudent(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string addStudentCmd = $"Insert into student(name,surname,dob,gender) values ({student.getName()},{student.getSurname()},{student.getDateOfBirth()},{student.getGender()})";

                SqlCommand sqlCommand = new SqlCommand(addStudentCmd, connection);
                sqlCommand.BeginExecuteNonQuery();
                if (student.GetImage() != null)
                {
                    //UPDATE Student image
                    updateStudentImage(student);
                    
                }
                if (student.getPhone() != "")
                {
                    //UPDATE Student Phone
                    updateStudentPhone(student);
                }
                if (student.getAddress() != "")
                {
                    //UPDATE Student Phone
                    updateStudentAddress(student);
                }
            }
        }

        public void updateStudentImage(Student student)
        {
           

            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                using (MemoryStream imageStream = new MemoryStream()) { 
                student.GetImage().Save(imageStream, student.GetImage().RawFormat);


                string updateStudentCmd = $"Update student image={imageStream} {SQLWhereClauseStudent(student)}";
                imageStream.Close();
                SqlCommand sqlCommand = new SqlCommand(updateStudentCmd, connection);
                sqlCommand.BeginExecuteNonQuery();
            }
            }
           

        }

        public void updateStudentPhone(Student student)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string updateStudentCmd = $"Update student phone={student.getPhone()} {SQLWhereClauseStudent(student)}";
                SqlCommand sqlCommand = new SqlCommand(updateStudentCmd, connection);
                sqlCommand.BeginExecuteNonQuery();
            }

        }

        public void updateStudentAddress(Student student)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string updateStudentCmd = $"Update student address={student.getAddress()}  {SQLWhereClauseStudent(student)}";
                SqlCommand sqlCommand = new SqlCommand(updateStudentCmd, connection);
                sqlCommand.BeginExecuteNonQuery();
            }
        }

        private string SQLWhereClauseStudent(Student student)
        {
            string whereclause = "";
            if (student.getStudentNumber() > 0)
            {
                whereclause = $" where id = {student.getStudentNumber()}";
            }
            else
            {
                whereclause = $" where name = {student.getName()} , surname = {student.getSurname()},dob = {student.getDateOfBirth()}";

            }
            return whereclause;
        }

        //Modules

        public void addModule(Module module)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string addStudentCmd = $"Insert into module(code,name,description) values ({module.getCode()},{module.getName()},{module.getDescription()})";


                SqlCommand sqlCommand = new SqlCommand(addStudentCmd, connection);
                sqlCommand.BeginExecuteNonQuery();
               
            }
        }

        public void updateDescription(Module module)
        {
            using (SqlConnection connection = new SqlConnection(connectionPath))
            {
                connection.Open();

                string addStudentCmd = $"Update module description={module.getDescription()} where code={module.getCode()})";


                SqlCommand sqlCommand = new SqlCommand(addStudentCmd, connection);
                sqlCommand.BeginExecuteNonQuery();

            }
        }
        public DataTable getModules()
        {
            using (SqlConnection conn = new SqlConnection(connectionPath))
            {
                string cmd = $"Select * FROM module";
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
        }

        public List<Module> getModuleList()
        {
            DataTable dt = getModules();
            List<Module> moduleList = new List<Module>();

            foreach(DataRow row in dt.Rows)
            {
                Module module = new Module((string)row["code"], (string)row["name"], (string)row["description"]);
                moduleList.Add(module);
            }

            return moduleList;
        }

       

    }   
   
}
