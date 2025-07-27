namespace Assignment_2_oop
{
    internal struct Person
    {
        public string Name;
        public int Age;

        public override string ToString()
        {
            return $"Name:{Name}\nAge:{Age}";
        }
    }
}
