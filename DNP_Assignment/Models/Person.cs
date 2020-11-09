namespace DNP_Assignment.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }
        public string Sex { get; set; }


        public Person(string FirstName, string LastName, int Id, string HairColor, string EyeColor, int Age, double Weight, int Height, string Sex)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
            this.HairColor = HairColor;
            this.EyeColor = EyeColor;
            this.Age = Age;
            this.Weight = Weight;
            this.Height = Height;
            this.Sex = Sex;
        }
        public Person()
        {

        }



    }
}