using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bank
{
    class Connection
    {
        //Строка подключения к базе данных
        string conStr = @"Data Source=10.10.1.24;Initial Catalog=;Persist Security Info=True;User ID=pro-41;Password=IsPro-41";
        public SqlConnection Connect()//Метод для подключения
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conStr;
            return connection;
        }
        //Метод для обновления данных в таблице "Users"
        public void UpdateUser(int id, string login, string password, string name, string surname, string patronomic, string series, string number, string phone, string adress, string email, string dateOfIssue, string issued, string dateOfBirth, string placeOfBirth)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conStr;
            connection.Open();
            SqlCommand updateUser = new SqlCommand($@"UPDATE User$ SET Login='{login}', Password='{password}', Name='{name}', Surname='{surname}', Patronymic='{patronomic}', Series='{series}', Number='{number}', Phone='{phone}', Adress='{adress}', eMail='{email}', DateOfIssue='{dateOfIssue}', Issued='{issued}', DateOfBirth='{dateOfBirth}', PlaceOfBirth='{placeOfBirth}' WHERE UserID = {id}",connection);
            int update = updateUser.ExecuteNonQuery();
            connection.Close();
        }
        //Метод для добавления данных в таблицу "Users"
        public void AddUser(string login, string password, string name, string surname, string patronomic, string series, string number, string phone, string adress, string email, string dateOfIssue, string issued, string dateOfBirth, string placeOfBirth)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conStr;
            connection.Open();
            SqlCommand addUser = new SqlCommand($@"INSERT INTO User$ (Login, Password, Name, Surname, Patronymic, Series, Number, Phone, Adress, eMail, DateOfIssue, Issued, DateOfBirth, PlaceOfBirth) VALUES ('{login}','{password}','{name}','{surname}','{patronomic}','{series}','{number}','{phone}','{adress}','{email}','{dateOfIssue}','{issued}','{dateOfBirth}','{placeOfBirth}')", connection);
            int add = addUser.ExecuteNonQuery();
            connection.Close();
        }
        //Метод для добавления данных в таблицу "Contracts"
        public void DelContract(long id)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = conStr;
            connection.Open();
            SqlCommand delContract = new SqlCommand($@"DELETE FROM Contract$ WHERE Account = '{id}'", connection);
            int del = delContract.ExecuteNonQuery();
            connection.Close();
        }
    }
}
