using clinicProject.Entities;

namespace clinicProject
{
    public class DataContext
    {

        public List<ClassDoctor> doctors { get; set; }
        public List<ClassRoutes> routes { get; set; }
        public List<ClassPatient> patients { get; set; }
        public DataContext()
        {
            routes = new List<ClassRoutes> {
            new ClassRoutes{Dname="doctor1",idname=4455 },
            new ClassRoutes{Dname="doctor2",idname=44 }
        };
            patients = new List<ClassPatient> {
            new ClassPatient { address="address1",age=111 ,email="ff"},
            new ClassPatient { address="address2",age=111 ,email="ff"}
            };
            doctors = new List<ClassDoctor> {
           new ClassDoctor{name="name1",id=12345678},
           new ClassDoctor{name="name2",id=12345678}
            };
        }
    }

}
