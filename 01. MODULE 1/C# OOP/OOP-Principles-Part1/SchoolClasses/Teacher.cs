namespace SchoolClasses
{
    using System.Collections.Generic;

    public class Teacher : IPerson
    {
        private string name;
        private IList<Discipline> disciplines = new List<Discipline>();

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
    }
}
