/* C# 9 introduced the record type which defines a reference type with
value-based equality behavior. */

using static System.Console;

namespace Records
{
    /* They can be created in two different ways.
    First, in the same way as a class, but by using the record keyword instead. */

    public record Product // it's also possible: public record class Product
    {
        public string? title { get; init; }
        public int id { get; init; }
        public int price { get; init; }
    }

    /* The second way to create a record is using the so-called positional
    parameter form as shown in the following. When using this more concise
    syntax, the compiler will automatically generate the init-only properties as
    well as a constructor for those properties. */

    public record Buyer(string name, int phoneNumber, string address)
    {
        public string? email { get; init; }
    }

    // record inheritance
    public record ProductOwner(string name);
    public record ProductOwnerInfo(string name, int id) : ProductOwner(name);

    /* Like record classes, a record struct may be
    defined with the standard property syntax, positional parameters, or a
    combination of both. */

    public record struct Seller(string name, int id)
    {
        public int phoneNumber { get; init; } = 0;
    }

    class Program
    {
        static void Main()
        {
            WriteLine("--- The First Way To Create Record ---");

            var unitProdcut = new Product { title = "Mountain bike", id = 001, price = 1800 };
            string title = unitProdcut.title;
            int id = unitProdcut.id;
            int price = unitProdcut.price;

            WriteLine($"Title: {title}, Product ID: {id}, Price: {price}");

            WriteLine("--- Second Way To Create Record ---");

            var buyer = new Buyer("Silvia", 834559933, "Ecija, Cale Malaga, 21-1");

            string name = buyer.name;
            int pNumber = buyer.phoneNumber;
            string address = buyer.address;

            WriteLine($"Buyer's name: {name}, phone: {pNumber}, address: {address}");

            var buyer1 = new Buyer("Sandra", 834964948, "Alicante, Padre Espla, 14-7") { email = "sandrafromspain@gmail.com" };

            string name1 = buyer1.name;
            int pNumber1 = buyer1.phoneNumber;
            string address1 = buyer1.address;
            string email = buyer1.email;

            WriteLine($"Buyer's name: {name1}, phone: {pNumber1}, address: {address1}, email: {email}");

            WriteLine("--- Record Behavior ---");

            /* Although record is a reference type, the compiler automatically
            implements methods to enforce value-based equality. Two record
            instances are equal if the values of all of their fields and properties are
            equal. */

            var buyer2 = new Buyer("Jammy", 22338987, "Central str., NY");
            var buyer3 = new Buyer("Jammy", 22338987, "Central str., NY");
            bool bool1 = buyer2.Equals(buyer3); // true
            WriteLine(bool1);

            bool bool2 = (buyer2 == buyer3); // true
            WriteLine(bool2);

            bool bool3 = (buyer2 != buyer3); // false
            WriteLine(bool3);

            WriteLine("--- Records Inheritance ---");

            var productOwner = new ProductOwner("IT solutions");
            var productOwnerInfo = new ProductOwnerInfo("Clear Code Company", 1);

            WriteLine(productOwner);
            WriteLine(productOwnerInfo);

            WriteLine("--- With Expression ---");

            /* Properties of an immutable record instance cannot be modified, but
            they can be copied over to a new record by using a with expression. */

            var productOwnerInfo1 = new ProductOwnerInfo("Clear Code Company", 1);
            var poi1 = productOwnerInfo1 with { }; // copy record
            var poi2 = productOwnerInfo1 with { name = "Big Cloud", id = 3 }; // copy and alter record

            WriteLine(poi1);
            WriteLine(poi2);

            WriteLine("--- Record Structs ---");

            /*  As of C# 10, it is possible to declare value type records using a record struct
            declaration. */

            var seller = new Seller("Hose Ramon", 98) { phoneNumber = 234235234 };
            WriteLine(seller);
        }
    }
}
