﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Design_Example
{
    public class Student
    {
        private String rollNo;
        private String name;

        public String getRollNo()
        {
            return rollNo;
        }

        public void setRollNo(String rollNo)
        {
            this.rollNo = rollNo;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
    }
}
