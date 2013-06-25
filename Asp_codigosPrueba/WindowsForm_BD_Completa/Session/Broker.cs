using System;
using System.Collections.Generic;
using System.Data.OleDb; //añadidio para la conexion de Access
using System.Linq;
using System.Text;
using Domain; //añadido
using System.Data;
using System.IO;





namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void connectTo()
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Mi_Hogar\\Documents\\visual studio 2012\\Projects\\WindowsForm_BD_Completa\\Session\\databaseEjemplo.accdb");


            command = connection.CreateCommand();

        }

        public Broker()
        {
            connectTo();
        }

        #region Insertar
        public void Insert(Person p)    //add references domain
        {
            try
            {
                command.CommandText = "INSERT INTO Tperson(firstName,lastName) VALUES(' " + p.FirstName + " ',' " + p.LastName + " ' )";
                command.CommandType = CommandType.Text;

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        #endregion
        #region MostrarDatosCmb
        public List<Person> fillComboBox()      //fill Combo
        {
                            List<Person> personList = new List<Person>();
                            try
                            {
                                command.CommandText = "SELECT * FROM Tperson";
                                command.CommandType = CommandType.Text;
                                connection.Open();
                                System.Data.OleDb.OleDbDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    Person p = new Person();
                                    p.Id = Convert.ToInt32(reader["ID"].ToString());
                                    p.FirstName = reader["FirstName"].ToString();
                                    p.LastName = reader["LastName"].ToString();
                                    personList.Add(p);
                                }
                return personList;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        #endregion
        #region Update
        public void update( Person oldPerson, Person newPerson)
        {
            try
            {
                command.CommandText = "UPDATE  Tperson SET FirstName= ' "+newPerson.FirstName+ ", 'LastName=' " +newPerson.LastName+ ", ' WHERE ID= ' "+oldPerson.Id;
               
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
                }
      
            catch (Exception )
            {
                throw ;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        #endregion
        #region Delete
        public void Delete(Person p)
        { 
            try
            {
                command.CommandText = "DELETE FROM tperson WHERE ID="+p.Id;
               
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteNonQuery();
                }
      
            catch (Exception )
            {
                throw ;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        }
        #endregion
    }


