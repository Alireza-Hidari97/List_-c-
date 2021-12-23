using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject
{
    class Pet
    {
        public string Name { get; }

        public string Owner { get; private set; }

        public int Age { get; }

        public string Description { get; }

        public bool IsHouseTrained { get; private set; }

        public Pet(string name,
            int age,
            string description)
        {
            Name = name;
            Age = age;
            Description = description;
            Owner = "no one";
            IsHouseTrained = false;
        }

        public override string ToString()
        {
            string fullDescription;

            fullDescription = $"Pet's Name: {Name}, owner: {Owner}, age: {Age}, ";
            fullDescription += $"the pet is{(IsHouseTrained ? "" : " not")} trained, {Description}";

            return fullDescription;
        }

        public void SetOwner(string owner)
        {
            Owner = owner;
        }

        public void Train()
        {
            IsHouseTrained = true;
        }
    }
}
