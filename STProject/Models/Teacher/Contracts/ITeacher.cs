﻿using STProject.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Interfaces
{
    public interface ITeacher
    {
        void InsertTeacher(Teacher teacher);
        int AdminNumber { get; set; }
        Teacher ReadFromData(string email, string password);
        List<Teacher> TeachersCollection();
    }
}
