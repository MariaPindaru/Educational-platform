using SchoolPlatform.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.Models.Actions
{
    class AdminActions 
    {
        private schoolEntities context = new schoolEntities();

        private AdminLogVM adminContext;

        public AdminActions(AdminLogVM admin)
        {
            adminContext = admin;
        }

        public ObservableCollection<StudentVM> AllStudents()
        {
            var students = context.GetStudents();
            ObservableCollection<StudentVM> result = new ObservableCollection<StudentVM>();
            foreach (var s in students)
            {
                result.Add(new StudentVM()
                {

                    Person = new PersonVM()
                    {
                        Username = s.Username,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        PersonId = s.PersonID
                    },
                    ClassId = s.ClassID,
                    StudentId = s.StudentID,
                    ClassNumber = s.y,
                    ClassName = s.Letter,
                    Specialization = s.spec,
                    Password = s.Password
                });
            }
            return result;
        }
        public ObservableCollection<ProfessorVM> AllProffesors()
        {
            var profs = context.GetProfessors();
            ObservableCollection<ProfessorVM> result = new ObservableCollection<ProfessorVM>();
            foreach (var p in profs)
            {
                result.Add(new ProfessorVM()
                {

                    Person = new PersonVM()
                    {
                        Username = p.Username,
                        FirstName = p.FirstName,
                        LastName = p.LastName,
                        PersonId = p.PersonID
                    },
                    Password = p.Password,
                    SubjectsList = AllSubjectsForProfessor(p.PersonID)
                }) ;
            }
            return result;
        }
        public ObservableCollection<Year> AllYears()
        {
            var years = context.Years;
            ObservableCollection<Year> result = new ObservableCollection<Year>();
            foreach (var y in years)
            {
                result.Add(new Year()
                {
                    YearID = y.YearID,
                    Name = y.Name
                });
            }
            return result;
        }
        public ObservableCollection<Specialization> AllSpecializations()
        {
            var specs = context.Specializations;
            ObservableCollection<Specialization> result = new ObservableCollection<Specialization>();
            foreach (var s in specs)
            {
                result.Add(new Specialization()
                {
                    SecializationId = s.SecializationId,
                    Name = s.Name
                });
            }
            return result;
        }
        public ObservableCollection<ClassVM> AllClasses()
        {
            var classes = context.GetClasses();
            ObservableCollection<ClassVM> result = new ObservableCollection<ClassVM>();
            foreach (var c in classes)
            {
                result.Add(new ClassVM()
                {
                    ClassID = c.ClassID,
                    Letter = c.Letter,
                    YearName = c.YearName,
                    Specialization = c.SpecializationName,
                    HeadMaster = GetHeadMaster(c.ClassID)
                });
            }
            return result;
        }
        public ProfessorVM GetHeadMaster(int classID)
        {
            var cls = context.Classes.Where(c => c.ClassID == classID).FirstOrDefault();
            var prof = context.Professors.Where(p => p.ProfessorID == cls.HeadMasterID).FirstOrDefault();
            var person = context.People.Where(p => p.PersonID == prof.PersonID).FirstOrDefault();
            var reg = context.Registrations.Where(r => r.Username == person.Username).FirstOrDefault();
            return new ProfessorVM()
            {

                Person = new PersonVM()
                {
                    Username = reg.Username,
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    PersonId = person.PersonID
                },
                Password = reg.Password,
                SubjectsList = AllSubjectsForProfessor(person.PersonID)
            };
        }
        public ObservableCollection<Subject> AllSubjects()
        {
            var res = context.GetAllSubjects();
            ObservableCollection<Subject> result = new ObservableCollection<Subject>();
            foreach (var x in res)
            {
                result.Add(new Subject()
                {
                    SubjectID = x.SubjectID,
                    Name = x.Name
                }) ;
            }
            return result;
        }
        public ObservableCollection<Subject> AllSubjectsForProfessor(int personID)
        {
            var prof = context.Professors.Where(x => x.PersonID == personID).FirstOrDefault();
            var res = context.AllSubjectsForProfessor(prof.ProfessorID);
            ObservableCollection<Subject> result = new ObservableCollection<Subject>();
            foreach (var x in res)
            {
                result.Add(new Subject()
                {
                    SubjectID = x.SubjectID,
                    Name = x.Name
                });
            }
            return result;
        }
        public string GetSpecialization(string yearName, string letter)
        {
            var spec = context.GetSpecializationForClass(yearName, letter);
            ObservableCollection<string> result = new ObservableCollection<string>();
            foreach (var s in spec)
            {
                result.Add(s);
            }
            return result.FirstOrDefault();
        }
        public void AddNewStudent(object obj)
        {
            StudentVM student = obj as StudentVM;
            if (student == null)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (context.People.Where(p => p.Username == student.Person.Username).FirstOrDefault() != null)
            {
                adminContext.Message = "Username-ul exista deja in baza de date!";
                return;
            }
            if (string.IsNullOrEmpty(student.Person.Username) || string.IsNullOrEmpty(student.Password) || string.IsNullOrEmpty(student.Person.FirstName) ||
              string.IsNullOrEmpty(student.Person.LastName) || string.IsNullOrEmpty(student.ClassName) || string.IsNullOrEmpty(student.ClassNumber) || string.IsNullOrEmpty(student.Specialization))
            {
                adminContext.Message = "Exista campuri necompletate!";
                return;
            }
            context.AddStudent(student.Person.Username, student.Password, student.Person.FirstName, student.Person.LastName, student.ClassName, student.ClassNumber, student.Specialization);
            adminContext.Message = "Elev adaugat!";
            adminContext.StudentList = AllStudents();
        }
        public void AddNewSubject(object obj)
        {
            Subject subject = obj as Subject;
            if (string.IsNullOrEmpty(subject.Name))
            {
                adminContext.Message = "Exista campuri necompletate!";
                return;
            }
            if (context.Subjects.Where(s => s.Name == subject.Name).FirstOrDefault() != null)
            {
                adminContext.Message = "Materia exista deja!";
                return;
            }
            context.AddSubject(subject.Name);
            adminContext.Message = "Materia a fost adaugat adaugata!";
            adminContext.SubjectList = AllSubjects();
        }
        public void AddNewProfessor(object obj)
        {
            ProfessorVM prof = obj as ProfessorVM;
            if (string.IsNullOrEmpty(prof.Person.Username) || string.IsNullOrEmpty(prof.Password) || string.IsNullOrEmpty(prof.Person.FirstName) ||
               string.IsNullOrEmpty(prof.Person.LastName))
            {
                adminContext.Message = "Exista campuri necompletate!";
                return;
            }
            if (context.Professors.Where(p => p.Person.Username == prof.Person.Username).FirstOrDefault() != null)
            {
                adminContext.Message = "Username-ul exista deja!";
                return;
            }
            context.AddProfessor(prof.Person.Username, prof.Password, prof.Person.FirstName, prof.Person.LastName);
            adminContext.Message = "Profesorul a fost adaugat!";
            adminContext.ProfList = AllProffesors();
        }
        public void AddLinkProfSubj(object obj)
        {
            ProfessorSubjectVM ps = obj as ProfessorSubjectVM;
            if (ps.Prof.Person.PersonId == 0 || ps.Subj.SubjectID == 0)
            {
                adminContext.Message = "Profesor / materie inexistent(a)!";
                return;
            }
            var prof = context.Professors.Where(x => x.PersonID == ps.Prof.Person.PersonId).FirstOrDefault();
            if(context.Professor_Subject.Where(p => p.SubjectID == ps.Subj.SubjectID && p.ProfessorID == prof.ProfessorID).FirstOrDefault() != null)
            {
                adminContext.Message = "Legatura exista deja!";
                return;
            }
            context.AddProfessorSubject(ps.Subj.SubjectID, prof.ProfessorID);
            adminContext.Message = "Legatura a fost adaugata!";
            adminContext.ProfList = AllProffesors();
        }
        public void AddSubjectToSpecialization(object obj)
        {
            SubjectSpecializationVM ss = obj as SubjectSpecializationVM;
            if (ss.Houres <= 0 || ss.ProfPersonID == 0 || ss.SpecializationID == 0|| ss.SubjectID == 0 ||ss.YearID == 0)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            var prof = context.Professors.Where(x => x.PersonID == ss.ProfPersonID).FirstOrDefault();
            var sp = context.Professor_Subject.Where(p => p.SubjectID == ss.SubjectID && p.ProfessorID == prof.ProfessorID).FirstOrDefault();
            var ys = context.Year_Specializaion.Where(x => x.SepcializationId == ss.SpecializationID && x.YearID == ss.YearID).FirstOrDefault();
            var sm = context.Prof_Subj_Class.Where(p => p.ProfSubjID == sp.ProfSubjID && p.YearSpecID == ys.Year_specID).FirstOrDefault();
            if (sm != null)
            {
                adminContext.Message = "Legatura exista deja!";
                return;
            }
            context.AddSubjectToYearSpecialization(ss.YearID, ss.SpecializationID, ss.SubjectID, prof.ProfessorID, ss.Houres, ss.Final);
            adminContext.Message = "Materia a fost adaugata pentru an-specializare!";
            adminContext.ProfList = AllProffesors();
        }
        public void AddHeadMaster(object obj)
        {
            ClassVM c = obj as ClassVM;
            if (c.ClassID == 0 || c.HeadMasterID == 0)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            var prof = context.Professors.Where(x => x.PersonID == c.HeadMasterID).FirstOrDefault();
            if (context.Classes.Where(x => x.HeadMasterID == prof.ProfessorID && x.ClassID == c.ClassID).FirstOrDefault() != null)
            {
                adminContext.Message = "Legatura exista deja!";
                return;
            }
            context.SetHeadMaster(prof.ProfessorID, c.ClassID);
            adminContext.Message = "Dirigintele a fost adaugat cu succes!";
        }
        public void DeleteLinkProfSubj(object obj)
        {
            ProfessorSubjectVM ps = obj as ProfessorSubjectVM;
            if (ps.Prof.Person.PersonId == 0 || ps.Subj.SubjectID == 0)
            {
                adminContext.Message = "Profesor / materie inexistent(a)!";
                return;
            }
            var prof = context.Professors.Where(x => x.PersonID == ps.Prof.Person.PersonId).FirstOrDefault();
            if (context.Professor_Subject.Where(p => p.SubjectID == ps.Subj.SubjectID && p.ProfessorID == prof.ProfessorID).FirstOrDefault() == null)
            {
                adminContext.Message = "Legatura nu exista!";
                return;
            }
            context.DeleteLinkProfessorSubject(ps.Subj.SubjectID, prof.ProfessorID);
            adminContext.Message = "Legatura a fost stearsa!";
            adminContext.ProfList = AllProffesors();
        }
        public void UpdateStudent(object obj)
        {
            StudentVM student = obj as StudentVM;
            if(student == null)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (string.IsNullOrEmpty(student.Person.Username) || string.IsNullOrEmpty(student.Password) || string.IsNullOrEmpty(student.Person.FirstName) ||
                string.IsNullOrEmpty(student.Person.LastName) || string.IsNullOrEmpty(student.ClassName) || string.IsNullOrEmpty(student.ClassNumber) || string.IsNullOrEmpty(student.Specialization))
            {
                adminContext.Message = "Exista campuri necompletate!";
                return;
            }
            context.UpdateStudent(student.Person.PersonId, student.StudentId, student.Password, student.Person.FirstName, student.Person.LastName, student.Person.Username, student.ClassId);
            adminContext.Message = "Elevul a fost actualizat!";
            adminContext.StudentList = AllStudents();
        }
        public void UpdateProfessor(object obj)
        {
            ProfessorVM prof = obj as ProfessorVM;
            if (prof == null)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (string.IsNullOrEmpty(prof.Person.Username) || string.IsNullOrEmpty(prof.Password) || string.IsNullOrEmpty(prof.Person.FirstName) ||
                string.IsNullOrEmpty(prof.Person.LastName))
            {
                adminContext.Message = "Exista campuri necompletate!";
                return;
            }
            context.UpdateProfessor(prof.Person.PersonId, prof.Person.Username, prof.Password, prof.Person.FirstName, prof.Person.LastName);
            adminContext.Message = "Profesorul a fost actualizat!";
            adminContext.ProfList = AllProffesors();
        }
        public void UpdateSubject(object obj)
        {
            Subject s = obj as Subject;

            if (string.IsNullOrEmpty(s.Name))
            {
                adminContext.Message = "Exista campuri necompletate!";
                return;
            }
            if (s.SubjectID == 0)
            {
                adminContext.Message = "Selectati o materie!";
                return;
            }
            context.UpdateSubject(s.SubjectID.ToString(), s.Name);
            adminContext.Message = "Mateira a fost actualizata!";
            adminContext.SubjectList = AllSubjects();
        }
        public void DeleteStudent(object obj)
        {
            StudentVM student = obj as StudentVM;
            if (student == null)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if (context.People.Where(p => p.Username == student.Person.Username).FirstOrDefault() == null)
            {
                adminContext.Message = "Nu s-a putut efectua stergerea!";
                return;
            }
            context.DeletePerson(student.Person.Username);
            adminContext.Message = "Elevul a fost sters!";
            adminContext.StudentList = AllStudents();
        }
        public void DeleteProfessor(object obj)
        {
            ProfessorVM prof = obj as ProfessorVM;
            var x = context.Professors.Where(p => p.Person.PersonID == prof.Person.PersonId).FirstOrDefault();
            if (prof == null)
            {
                adminContext.Message = "Operatia nu s-a putut efectua!";
                return;
            }
            if(context.Classes.Where(c => c.HeadMasterID == x.ProfessorID).FirstOrDefault() != null)
            {
                adminContext.Message = "Profesorul este diriginte, nu poate fi sters!";
                return;
            }
            if (context.People.Where(p => p.Username == prof.Person.Username).FirstOrDefault() == null)
            {
                adminContext.Message = "Nu s-a putut efectua stergerea!";
                return;
            }
            context.DeletePerson(prof.Person.Username);
            adminContext.Message = "Profesorul  a fost sters!";
            adminContext.ProfList = AllProffesors();
        }
        public void DeleteSubject(object obj)
        {
            Subject subject = obj as Subject;
            if (subject.SubjectID == 0)
            {
                adminContext.Message = "Selectati o materie!";
                return;
            }
            if (context.Subjects.Where(s => s.Name == subject.Name).FirstOrDefault() == null)
            {
                adminContext.Message = "Nu s-a putut efectua stergerea!";
                return;
            }
            context.DeleteSubject(subject.Name);
            adminContext.Message = "Materia a fost stearsa!";
            adminContext.SubjectList = AllSubjects();
        }
        
    }
}
