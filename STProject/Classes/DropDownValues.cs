﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STProject.Classes
{
    public class DropDownValues
    {
        public void getDepartments(List<string> arr)
        {
            arr.Add("ФПМИ");
            arr.Add("КСИ");
            arr.Add("ФТ");
        }

        public void getSubjects(List<string> arr)
        {
            arr.Add("ИСН");
            arr.Add("ПМИ");
            arr.Add("КСИ");
            arr.Add("Телекомуникации");
        }
    }
}
