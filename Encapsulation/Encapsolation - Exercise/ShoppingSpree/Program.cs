// Create two classes: 
// •	Person
// •	Product
// Each person should have a name, money, and a bag of products. Each product should have a name and a cost.
// The name cannot be an empty string. Money and cost cannot be negative numbers. 
// Create a program where each command corresponds to a person buying a product. If the person can afford a product, add it to his bag.
// If a person doesn’t have enough money, print an appropriate message ("{personName} can't afford {productName}").
// On the first two lines, you are given all people and all products.
// After all, purchases print every person in the order of appearance and all products that he has bought also in order of appearance.
// If nothing was bought, print the name of the person followed by "Nothing bought". 
// In case of invalid input (negative money Exception message: "Money cannot be negative")
// or an empty name (empty name Exception message: "Name cannot be empty") break the program with an appropriate message.
// See the examples below:

//     Input
// Peter = 11; George = 4
// Bread = 10; Milk = 2;
// Peter Bread
// George Milk
// George Milk
// Peter Milk
// END
//     Output
// Peter bought Bread
// George bought Milk
// George bought Milk
// Peter can't afford Milk
// Peter - Bread
// George - Milk, Milk


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        string[] peopleInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        try
        {
            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] currentPersonInfo = peopleInfo[i].Split('=');
                string name = currentPersonInfo[0];
                double money = double.Parse(currentPersonInfo[1]);
                Person person = new Person(name, money);
                people[name] = person;
            }

            string[] productsInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] currentProductInfo = productsInfo[i].Split('=');
                string name = currentProductInfo[0];
                double cost = double.Parse(currentProductInfo[1]);
                Product product = new Product(name, cost);
                products[name] = product;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = arguments[0];
                string product = arguments[1];
                double personMoney = people[name].Money;
                double cost = products[product].Cost;
                if (personMoney - cost < 0)
                {
                    Console.WriteLine($"{name} can't afford {product}");
                }
                else
                {
                    people[name].Money -= cost;
                    Console.WriteLine($"{name} bought {product}");
                    people[name].Products.Add(product);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        foreach (var person in people)
        {
            Console.Write($"{person.Key} - ");
            if (person.Value.Products.Count == 0)
            {
                Console.WriteLine("Nothing bought");
            }
            else
            {
                Console.WriteLine(string.Join(", ", person.Value.Products));
            }
        }
    }
}