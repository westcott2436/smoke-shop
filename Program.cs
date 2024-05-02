namespace SmokeShop.Console
{
    internal class Program
    {
        const string MARLBORO = "Marlboro";
        static void Main(string[] args)
        {
            List<string> MyBrands = new List<string>();
            MyBrands.Add("Camel"); //Todo: Turn this into a const for all brands
            MyBrands.Add("Kool");  //Todo: Turn this into a const for all brands
            MyBrands.Add(MARLBORO);
            bool IsOver18 = false;
            System.Console.WriteLine("Would you like to buy smokes? Y/N");
            var ValidInput = false;
            while (ValidInput == false) 
            {
                string? CustomerAnswer = System.Console.ReadLine().ToLower();
                if (CustomerAnswer != null && CustomerAnswer == "y")
                {
                    ValidInput = true;
                    System.Console.WriteLine("You need to be at least 18 to buy smokes. What is your age?");
                    var CustomerAge = System.Console.ReadLine();
                    if (CustomerAge != null)
                    {
                        var customerAgeAsNumber = int.Parse(CustomerAge);
                        if (customerAgeAsNumber >= 18)
                        {
                            IsOver18 = true;
                        }

                    }

                }
                else if (CustomerAnswer != null && CustomerAnswer == "n")
                {
                    ValidInput = true;
                    System.Console.WriteLine("We only sell smokes fuck off.");
                }
                else 
                
                {
                    System.Console.WriteLine("The only acceptable answers are 'y' or 'n'!");
                }
            }
            
            if (IsOver18)  
            {
                System.Console.WriteLine("Looks like you are old enough to buy smokes");
                System.Console.WriteLine("Which brand would you like?");
                System.Console.WriteLine("We offer the following brands...");
                ListMyBrands(MyBrands);
                System.Console.WriteLine("Which brand would you like?");
                bool ValidSelection = false;
                while (ValidSelection == false) 
                {
                    string? SmokesBrand = System.Console.ReadLine();

                    switch (SmokesBrand)
                    {
                        case "Camel": //ref the const once it is made on line 5,6,7
                            ValidSelection = true;
                            System.Console.WriteLine($"The {SmokesBrand} are going to be $5.00");
                            break;
                        case "Kool":  //ref the const once it is made on line 5,6,7
                            ValidSelection = true;
                            System.Console.WriteLine($"The {SmokesBrand} are going to be $5.50");
                            break;
                        case MARLBORO:
                            ValidSelection = true;
                            System.Console.WriteLine($"The {SmokesBrand} are going to be $5.25");
                            break;
                        default:
                            System.Console.WriteLine($"Sorry we do not sell {SmokesBrand}, but the breads we carry are");
                            ListMyBrands(MyBrands);
                            break;
                    }
                }
                System.Console.WriteLine("Thank you for your purchase!");   
            }
            else
            {
                System.Console.WriteLine("You are not old enough to purchase smokes");
            }
            
        }
        public static void ListMyBrands(List<string> Brands) 
        {
            foreach (var Brand in Brands)
            {
                System.Console.WriteLine(Brand);
            }
        }
    }
}
