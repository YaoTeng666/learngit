using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiuWriteAndReaderProject
{
    class Student
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        //重写tostring（）方法，指定格式字符串
        public override string ToString()
        {
            return string.Format("Name:{0},Sex:{1},Age:{2}", Name, Sex, Age);
        }


        /// <summary>
        /// 将字符串转换Student对象的方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Student ReturnStudent(string str)
        {
            //创建一个Student实例
            Student s = new Student();
            //将字符串以‘，’字符切割字符串
            string[] strs = str.Split(',');
            //处理数组中第一个元素以获取Name属性
            s.Name = strs[0].Split(':')[1];
            //处理数组中第二个元素以获取Sex属性
            s.Sex = strs[1].Split(':')[1];
            //处理数组中第三个元素以获取Age属性
            s.Age = int.Parse(strs[2].Split(':')[1]);
            //返回转换完成的对象
            return s;
        }
    }
}
