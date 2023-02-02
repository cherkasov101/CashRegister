using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    internal class Authorization
    {
        private string _id;
        private string _password;
        private string UserDB = "UserDB.txt";
        public UserClass _userClass;

        public Authorization(string id, string password) 
        { 
            _id = id;
            _password = password;
        }

        //Проверка штрих-кода и пароля сотрудника
        public bool Start()
        {
            string[] data = File.ReadAllLines(UserDB);
            List<UserClass> userList = new List<UserClass>();
            for (int i = 0; i < data.Length; i++)
            {
                string[] line = data[i].Split(';');
                string id = line[0];
                string password = line[1];
                string name = line[2];
                string admin = line[3];
                userList.Add(new UserClass(id, password, name, admin));
            }
            bool rights = false;
            for(int i = 0; i < userList.Count; i++)
            {
                if(userList[i].id == _id && userList[i].password == _password)
                {
                    rights = true;
                    _userClass = userList[i];
                }
            }
            return rights;
        }
    }
}
