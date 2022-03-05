using fmt = go.fmt_package;
using sort = go.sort_package;

namespace go
{
    public static partial class main_package
    {
        public partial struct Person
        {
            public @string Name;
            public nint Age;
            public float ShoeSize;
        }

        public partial struct PeopleByShoeSize // : slice<Person>
        {
        }

        public partial struct PeopleByAge // : slice<Person>
        {
        }

        public static nint Len(this PeopleByShoeSize p)
        {
            return len(p);
        }

        public static void Swap(this PeopleByShoeSize p, nint i, nint j)
        {
            (p[i], p[j]) = (p[j], p[i]);
        }

        public static bool Less(this PeopleByShoeSize p, nint i, nint j)
        {
            return (p[i].ShoeSize < p[j].ShoeSize);
        }

        public static nint Len(this PeopleByAge p)
        {
            return len(p);
        }

        public static void Swap(this PeopleByAge p, nint i, nint j)
        {
            (p[i], p[j]) = (p[j], p[i]);
        }

        public static bool Less(this PeopleByAge p, nint i, nint j)
        {
            return (p[i].Age < p[j].Age);
        }

        private static void Main()
        {
            Person people = new slice<Person>(new Person[] { {Name:"Person1",Age:26,ShoeSize:8,}, {Name:"Person2",Age:21,ShoeSize:4,}, {Name:"Person3",Age:15,ShoeSize:9,}, {Name:"Person4",Age:45,ShoeSize:15,}, {Name:"Person5",Age:25,ShoeSize:8.5,} });

            fmt.Println(people);

            sort.Sort(PeopleByShoeSize(people));
            fmt.Println(people);

            sort.Sort(PeopleByAge(people));
            fmt.Println(people);
        }
    }
}
