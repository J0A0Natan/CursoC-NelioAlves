namespace _1_Cojuntos.Entities
{
    internal class Student
    {
        public int Code { get; set; }
        public string Course { get; set; }

        public Student(int code, string course)
        {
            Code = code;
            Course = course;
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
                return false;

            Student other = obj as Student;
            return Code.Equals(other.Code);
        }

        public override string ToString()
        {
            return $"{Code}, course {Course}";
        }
    }
}
