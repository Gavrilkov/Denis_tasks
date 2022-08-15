namespace Compare
{
    class Animal
    {
        int age;
        int weight;
        public Animal(int a, int b)
        {
            age = a;
            weight = b;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;
            var f = obj as Animal;
            if (f == null) return false;
            if (this.age == f.age && this.weight == f.weight)
                return true;

            else return false;
        }

        public static bool operator == (Animal obj1, Animal obj2)
        {

            if (obj1 == null || obj2 == null) return false;
            if (obj2.age == obj1.age && obj2.weight == obj1.weight)
                return true;

            else return false;
        }
        public static bool operator !=(Animal obj1, Animal obj2)
        {

            if (obj1 == null || obj2 == null) return true;
            if (obj2.age == obj1.age && obj2.weight == obj1.weight)
                return false;

            else return true;
        }


    }

    //public override bool Equals(object obj)
    //{
    //    if (obj.GetType() != this.GetType())
    //        return false;
    //    if (this.age == obj.age && this.weight == obj.weight)
    //        return true;
    //    else return false;
    //}
    //public bool Equals1(Animal obj)
    //{
    //    if (this.age == obj.age && this.weight == obj.weight)
    //        return true;
    //    else return false;
}
