namespace SchoolClasses
{
    public class Discipline
    {
        private string name;
        private uint numberOfLectures;
        private uint numberOfExercises;

        public string Name { get => name; set => name = value; }
        public uint NumberOfLectures { get => numberOfLectures; set => numberOfLectures = value; }
        public uint NumberOfExercises { get => numberOfExercises; set => numberOfExercises = value; }
    }
}
