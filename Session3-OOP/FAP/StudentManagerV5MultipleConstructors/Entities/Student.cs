using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV5MultipleConstructors.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        // 1 class co bao nhieu constructor la du ??
        // ko co cau tra loi, tuy cach ban muon do info vao cac field
        // form dang ki tren mang y chang: co field (*) required, co field la optional

        //1. neu ban khong tao constructor rong va class khong co constructor nao khac nua, thi runtime tu sinh gium (implicit)
        // Ta duoc 1 object chua default _field, sau do dung set() de chinh lai gia tri

        // 2. Ban co the chu dong tao constructor rong/default
        //tu khoa ctor tab tu generate, runtime khong can tao nua
        
        //3. Neu class co 1 constructor co tham so bat ki (vi du do duy nhat 1 ID) 
        // Runtime khong tao constructor default nua , do đã có cách đúc dữ liệu
        
        public Student(string id)
        {
            _id = id;
        }

        public Student(string id, string name) 
        {
            _id = id;
            _name = name;
        }

        public Student()
        {
            
        }
    }
}
