namespace Compare
{
    class Animal
    {
        int _age;
        int _weight;
        public Animal(int a, int b)
        {
            _age = a;
            _weight = b;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            { return false; }
            var f = obj as Animal;
            if (f == null) 
            { return false; }
            if (this._age == f._age && this._weight == f._weight)
            { return true; }
            return false;
        }

        public static bool operator ==(Animal obj1, Animal obj2)
        {
            if ((object)obj1 == null || (object)obj2 == null)
            {return false;}
            if (obj2._age == obj1._age && obj2._weight == obj1._weight)
            { return true; }
            return false;
        }

        public static bool operator !=(Animal obj1, Animal obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
