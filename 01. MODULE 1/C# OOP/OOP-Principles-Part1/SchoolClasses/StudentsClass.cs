namespace SchoolClasses
{
    using System.Collections;
    using System.Collections.Generic;

    public class StudentsClass
    {
        private string textIdentifier;
        private IList<Teacher> teachers = new List<Teacher>();

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            private set
            {
                this.textIdentifier = value;
            }
        }
    }
}
