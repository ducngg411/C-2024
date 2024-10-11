using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV7Encapsulation.Entities
{
    internal class Student
    {
        public string Id; // Privae thi _id
        public string Name;
        public int Yob;
        public double Gpa;

        // neu public thi khong can get set 

        // xai get() , set() khoi boiler-plate khong nham chan, ngan goi 
    }
}

// ta muon co 1 giai phap thiet ke class tot o:
// - dam bao tinh dong goi cua info cua object, tuc la private _field
// Che giau info gon gang ben trong object - encapsulation

// 2. ko co boiler-plate (code vo cam nham chan khong can tu duy)

// 3. khong duoc public cac private _field

// 4. Get(), Set() tu nhien, de dang nhu xai bien public 