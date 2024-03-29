﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolPlatform.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class schoolEntities : DbContext
    {
        public schoolEntities()
            : base("name=schoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceType> AttendanceTypes { get; set; }
        public virtual DbSet<AverageGrade> AverageGrades { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Prof_Subj_Class> Prof_Subj_Class { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<Professor_Subject> Professor_Subject { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Year> Years { get; set; }
        public virtual DbSet<Year_Specializaion> Year_Specializaion { get; set; }
    
        public virtual int AddAttendance(Nullable<int> profID, Nullable<int> studentID, Nullable<System.DateTime> date, Nullable<int> subjectID, Nullable<int> semesterId, string type)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var semesterIdParameter = semesterId.HasValue ?
                new ObjectParameter("semesterId", semesterId) :
                new ObjectParameter("semesterId", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAttendance", profIDParameter, studentIDParameter, dateParameter, subjectIDParameter, semesterIdParameter, typeParameter);
        }
    
        public virtual int AddAverageGrade(Nullable<int> studentID, Nullable<int> profID, Nullable<int> subjectID, Nullable<int> semesterID, Nullable<int> grade)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var semesterIDParameter = semesterID.HasValue ?
                new ObjectParameter("semesterID", semesterID) :
                new ObjectParameter("semesterID", typeof(int));
    
            var gradeParameter = grade.HasValue ?
                new ObjectParameter("grade", grade) :
                new ObjectParameter("grade", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddAverageGrade", studentIDParameter, profIDParameter, subjectIDParameter, semesterIDParameter, gradeParameter);
        }
    
        public virtual int AddGrade(Nullable<int> profID, Nullable<int> studentID, Nullable<int> grade, Nullable<System.DateTime> date, Nullable<int> subjectID, Nullable<int> semesterId, Nullable<bool> final)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var gradeParameter = grade.HasValue ?
                new ObjectParameter("grade", grade) :
                new ObjectParameter("grade", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var semesterIdParameter = semesterId.HasValue ?
                new ObjectParameter("semesterId", semesterId) :
                new ObjectParameter("semesterId", typeof(int));
    
            var finalParameter = final.HasValue ?
                new ObjectParameter("final", final) :
                new ObjectParameter("final", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddGrade", profIDParameter, studentIDParameter, gradeParameter, dateParameter, subjectIDParameter, semesterIdParameter, finalParameter);
        }
    
        public virtual int AddProfessor(string username, string password, string first_name, string last_name)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddProfessor", usernameParameter, passwordParameter, first_nameParameter, last_nameParameter);
        }
    
        public virtual int AddProfessorSubject(Nullable<int> subjectID, Nullable<int> profID)
        {
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddProfessorSubject", subjectIDParameter, profIDParameter);
        }
    
        public virtual int AddStudent(string username, string password, string first_name, string last_name, string class_name, string class_number, string specialization)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            var class_nameParameter = class_name != null ?
                new ObjectParameter("class_name", class_name) :
                new ObjectParameter("class_name", typeof(string));
    
            var class_numberParameter = class_number != null ?
                new ObjectParameter("class_number", class_number) :
                new ObjectParameter("class_number", typeof(string));
    
            var specializationParameter = specialization != null ?
                new ObjectParameter("specialization", specialization) :
                new ObjectParameter("specialization", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddStudent", usernameParameter, passwordParameter, first_nameParameter, last_nameParameter, class_nameParameter, class_numberParameter, specializationParameter);
        }
    
        public virtual int AddSubject(string subject_name)
        {
            var subject_nameParameter = subject_name != null ?
                new ObjectParameter("subject_name", subject_name) :
                new ObjectParameter("subject_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddSubject", subject_nameParameter);
        }
    
        public virtual int AddSubjectToYearSpecialization(Nullable<int> year_id, Nullable<int> spec_id, Nullable<int> subject_id, Nullable<int> prof_id, Nullable<int> nr_houres, Nullable<bool> final)
        {
            var year_idParameter = year_id.HasValue ?
                new ObjectParameter("year_id", year_id) :
                new ObjectParameter("year_id", typeof(int));
    
            var spec_idParameter = spec_id.HasValue ?
                new ObjectParameter("spec_id", spec_id) :
                new ObjectParameter("spec_id", typeof(int));
    
            var subject_idParameter = subject_id.HasValue ?
                new ObjectParameter("subject_id", subject_id) :
                new ObjectParameter("subject_id", typeof(int));
    
            var prof_idParameter = prof_id.HasValue ?
                new ObjectParameter("prof_id", prof_id) :
                new ObjectParameter("prof_id", typeof(int));
    
            var nr_houresParameter = nr_houres.HasValue ?
                new ObjectParameter("nr_houres", nr_houres) :
                new ObjectParameter("nr_houres", typeof(int));
    
            var finalParameter = final.HasValue ?
                new ObjectParameter("final", final) :
                new ObjectParameter("final", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddSubjectToYearSpecialization", year_idParameter, spec_idParameter, subject_idParameter, prof_idParameter, nr_houresParameter, finalParameter);
        }
    
        public virtual ObjectResult<AllGradesForStudent_Result> AllGradesForStudent(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllGradesForStudent_Result>("AllGradesForStudent", studentIDParameter);
        }
    
        public virtual ObjectResult<AllSubjectsForProfessor_Result> AllSubjectsForProfessor(Nullable<int> profID)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AllSubjectsForProfessor_Result>("AllSubjectsForProfessor", profIDParameter);
        }
    
        public virtual ObjectResult<AttendanceForStudent_Result> AttendanceForStudent(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AttendanceForStudent_Result>("AttendanceForStudent", studentIDParameter);
        }
    
        public virtual ObjectResult<AverageGradeSem_Result> AverageGradeSem(Nullable<int> studentID, Nullable<int> sem)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var semParameter = sem.HasValue ?
                new ObjectParameter("sem", sem) :
                new ObjectParameter("sem", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<AverageGradeSem_Result>("AverageGradeSem", studentIDParameter, semParameter);
        }
    
        public virtual int DeleteGrade(Nullable<int> profID, Nullable<int> studentID, Nullable<int> grade, Nullable<System.DateTime> date, Nullable<int> subjectID, Nullable<int> semesterId, Nullable<bool> final)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var gradeParameter = grade.HasValue ?
                new ObjectParameter("grade", grade) :
                new ObjectParameter("grade", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var semesterIdParameter = semesterId.HasValue ?
                new ObjectParameter("semesterId", semesterId) :
                new ObjectParameter("semesterId", typeof(int));
    
            var finalParameter = final.HasValue ?
                new ObjectParameter("final", final) :
                new ObjectParameter("final", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteGrade", profIDParameter, studentIDParameter, gradeParameter, dateParameter, subjectIDParameter, semesterIdParameter, finalParameter);
        }
    
        public virtual int DeleteLinkProfessorSubject(Nullable<int> subjectID, Nullable<int> profID)
        {
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteLinkProfessorSubject", subjectIDParameter, profIDParameter);
        }
    
        public virtual int DeletePerson(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePerson", usernameParameter);
        }
    
        public virtual int DeleteSubject(string subject_name)
        {
            var subject_nameParameter = subject_name != null ?
                new ObjectParameter("subject_name", subject_name) :
                new ObjectParameter("subject_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSubject", subject_nameParameter);
        }
    
        public virtual ObjectResult<GetAllProfessorSubject_Result> GetAllProfessorSubject()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllProfessorSubject_Result>("GetAllProfessorSubject");
        }
    
        public virtual ObjectResult<GetAllSubjects_Result> GetAllSubjects()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllSubjects_Result>("GetAllSubjects");
        }
    
        public virtual ObjectResult<Nullable<double>> GetAverageGrade(Nullable<int> studentID, Nullable<int> classID, Nullable<int> profID, Nullable<int> subjectID, Nullable<int> semesterID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var classIDParameter = classID.HasValue ?
                new ObjectParameter("classID", classID) :
                new ObjectParameter("classID", typeof(int));
    
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var semesterIDParameter = semesterID.HasValue ?
                new ObjectParameter("semesterID", semesterID) :
                new ObjectParameter("semesterID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("GetAverageGrade", studentIDParameter, classIDParameter, profIDParameter, subjectIDParameter, semesterIDParameter);
        }
    
        public virtual ObjectResult<GetAveragesForStudent_Result> GetAveragesForStudent(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAveragesForStudent_Result>("GetAveragesForStudent", studentIDParameter);
        }
    
        public virtual ObjectResult<GetClasses_Result> GetClasses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetClasses_Result>("GetClasses");
        }
    
        public virtual ObjectResult<GetProfessorByUsername_Result> GetProfessorByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProfessorByUsername_Result>("GetProfessorByUsername", usernameParameter);
        }
    
        public virtual ObjectResult<GetProfessors_Result> GetProfessors()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetProfessors_Result>("GetProfessors");
        }
    
        public virtual ObjectResult<string> GetSpecializationForClass(string year_name, string letter)
        {
            var year_nameParameter = year_name != null ?
                new ObjectParameter("year_name", year_name) :
                new ObjectParameter("year_name", typeof(string));
    
            var letterParameter = letter != null ?
                new ObjectParameter("letter", letter) :
                new ObjectParameter("letter", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetSpecializationForClass", year_nameParameter, letterParameter);
        }
    
        public virtual ObjectResult<GetStudentByUsername_Result> GetStudentByUsername(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentByUsername_Result>("GetStudentByUsername", usernameParameter);
        }
    
        public virtual ObjectResult<GetStudents_Result> GetStudents()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudents_Result>("GetStudents");
        }
    
        public virtual int MotivateAttendance(Nullable<int> profID, Nullable<int> studentID, Nullable<System.DateTime> date, Nullable<int> subjectID, Nullable<int> semesterId)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            var semesterIdParameter = semesterId.HasValue ?
                new ObjectParameter("semesterId", semesterId) :
                new ObjectParameter("semesterId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MotivateAttendance", profIDParameter, studentIDParameter, dateParameter, subjectIDParameter, semesterIdParameter);
        }
    
        public virtual int SetHeadMaster(Nullable<int> class_id, Nullable<int> prof_id)
        {
            var class_idParameter = class_id.HasValue ?
                new ObjectParameter("class_id", class_id) :
                new ObjectParameter("class_id", typeof(int));
    
            var prof_idParameter = prof_id.HasValue ?
                new ObjectParameter("prof_id", prof_id) :
                new ObjectParameter("prof_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetHeadMaster", class_idParameter, prof_idParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<StudentsByProfessorSubject_Result> StudentsByProfessorSubject(Nullable<int> profID, Nullable<int> subjectID)
        {
            var profIDParameter = profID.HasValue ?
                new ObjectParameter("profID", profID) :
                new ObjectParameter("profID", typeof(int));
    
            var subjectIDParameter = subjectID.HasValue ?
                new ObjectParameter("subjectID", subjectID) :
                new ObjectParameter("subjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<StudentsByProfessorSubject_Result>("StudentsByProfessorSubject", profIDParameter, subjectIDParameter);
        }
    
        public virtual ObjectResult<SubjectsWithFinals_Result> SubjectsWithFinals(Nullable<int> studentId)
        {
            var studentIdParameter = studentId.HasValue ?
                new ObjectParameter("studentId", studentId) :
                new ObjectParameter("studentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SubjectsWithFinals_Result>("SubjectsWithFinals", studentIdParameter);
        }
    
        public virtual int UpdateProfessor(Nullable<int> personId, string username, string password, string first_name, string last_name)
        {
            var personIdParameter = personId.HasValue ?
                new ObjectParameter("personId", personId) :
                new ObjectParameter("personId", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateProfessor", personIdParameter, usernameParameter, passwordParameter, first_nameParameter, last_nameParameter);
        }
    
        public virtual int UpdateStudent(Nullable<int> personID, Nullable<int> studentID, string password, string firstName, string lastName, string username, Nullable<int> classID)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("personID", personID) :
                new ObjectParameter("personID", typeof(int));
    
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("studentID", studentID) :
                new ObjectParameter("studentID", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var classIDParameter = classID.HasValue ?
                new ObjectParameter("classID", classID) :
                new ObjectParameter("classID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStudent", personIDParameter, studentIDParameter, passwordParameter, firstNameParameter, lastNameParameter, usernameParameter, classIDParameter);
        }
    
        public virtual int UpdateSubject(string subjectId, string name)
        {
            var subjectIdParameter = subjectId != null ?
                new ObjectParameter("subjectId", subjectId) :
                new ObjectParameter("subjectId", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateSubject", subjectIdParameter, nameParameter);
        }
    }
}
