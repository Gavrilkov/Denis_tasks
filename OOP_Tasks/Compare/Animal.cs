namespace Compare
{
    class Animal
    {
        int age;
        int weight;
        public bool Equals(Animal obj)
        {
            if (this.age == obj.age && this.weight == obj.weight)
                return true;
            else return false;
        }

        public Animal(int a, int b)
        {
            age = a;
            weight = b;
        }
    }
}
