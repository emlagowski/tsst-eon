﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("127.0.0.5");
            Thread t = new Thread(delegate()
            {
                UserForm uf = new UserForm(user);
                uf.Show();
                Application.Run();
            });
            t.Start();

            User user2 = new User("127.0.0.7");
            Thread t2 = new Thread(delegate()
            {
                UserForm uf = new UserForm(user2);
                uf.Show();
                Application.Run();
            });
            t2.Start();
        }
    }
}
