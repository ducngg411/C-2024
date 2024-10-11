﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUerManager.Entites
{
    public class Lecturer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Salary { get; set; }

        public override string? ToString() => $"Student: {Id} {Name} {Yob} {Salary}";

        public void ShowProfile() => Console.WriteLine(ToString());
    }
}
