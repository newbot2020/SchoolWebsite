using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace schoolwebsite.Models
{
    public class Attendance
    {
        public int id { get; set; }
        
        public string Absent { get; set; }

        public int Studentsid { get; set; }
        //[ForeignKey("Studentsid")]
        public Students Students { get; set; }
    }
}
