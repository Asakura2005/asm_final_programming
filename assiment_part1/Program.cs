namespace assiment
{
    internal class Program
    {
        static List<string> customers = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                // Nhận thông tin khách hàng
                Console.WriteLine("======Monthly Water Bill Calculator!=====");
                Console.Write("|| Enter customer name: ");
                string customerName = Console.ReadLine();
                //
                Console.WriteLine("=========================================");
                Console.WriteLine("|| Select customer type: ");
                Console.WriteLine("|| 1. Household");
                Console.WriteLine("|| 2. Administrative agency");
                Console.WriteLine("|| 3. Public services");
                Console.WriteLine("|| 4. Production units");
                Console.WriteLine("|| 5. Business services");
                //
                int customerType;
                Console.Write("|| Enter your selection: ");
                while (!int.TryParse(Console.ReadLine(), out customerType) || customerType < 1 || customerType > 5)
                {
                    Console.WriteLine("Error: Invalid data type, please re-enter");
                    Console.Write("|| Enter your selection: ");
                }
                //
                Console.WriteLine("=========================================");
                int numberOfPeople = 0;
                if (customerType == 1)
                {
                    Console.WriteLine("|| Enter number of people (for household customers only): ");
                    Console.Write("|| Enter the number of people: ");
                    while (!int.TryParse(Console.ReadLine(), out numberOfPeople))
                    {
                        Console.WriteLine("|| Error: Invalid data type, please re-enter");
                        Console.Write("|| Enter the number of people: ");
                    }
                }
                // Nhận chỉ số đồng hồ nước của tháng trước và tháng này
                Console.Write("|| Enter last month's water meter reading: ");
                double lastMonthReading;
                while (!double.TryParse(Console.ReadLine(), out lastMonthReading))
                {
                    Console.WriteLine("|| Error: Invalid data type, please re-enter");
                    Console.Write("|| Enter last month's water meter reading: ");
                }
                //
                Console.Write("|| Enter this month's water meter reading: ");
                double thisMonthReading;
                while (!double.TryParse(Console.ReadLine(), out thisMonthReading) || lastMonthReading > thisMonthReading)
                {
                    Console.WriteLine("|| Error: Invalid data type or last month is greater than this month, please re-enter.");
                    Console.Write("|| Enter this month's water meter reading: ");
                }

                // Tính toán mức tiêu thụ và hóa đơn nước
                double consumption = thisMonthReading - lastMonthReading;
                double result = CalculateWaterBill(customerType, consumption);

                // Lưu trữ thông tin khách hàng
                string customerInfo = $"{customerName},{customerType},{numberOfPeople}," +
                    $"{lastMonthReading},{thisMonthReading},{consumption},{result}";
                customers.Add(customerInfo);

                // Tìm kiếm khách hàng đã lưu
                display_results(customerName, lastMonthReading, thisMonthReading, consumption, result);

                // Hiển thị danh sách khách hàng đã nhập
                Imported_customer_list();

                // Thoát hoặc tiếp tục
                Console.Clear();
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Do you want to exit or continue: ");
                    string outOrContinue = Console.ReadLine();
                    if (outOrContinue.ToLower() == "continue")
                    {
                        Console.WriteLine("Press any key to return to the information filling form...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (outOrContinue.ToLower() == "exit")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter exit or continue");
                    }
                }
            }
        }

        static double CalculateWaterBill(int customerType, double consumption)
        {
            double waterBill = 0;

            switch (customerType)
            {
                case 1:
                    if (consumption <= 10)
                    {
                        waterBill = consumption * 5.973;
                    }
                    else if (consumption <= 20)
                    {
                        waterBill = 10 * 5.973 + (consumption - 10) * 7.052;
                    }
                    else if (consumption <= 30)
                    {
                        waterBill = 10 * 5.973 + 10 * 7.052 + (consumption - 20) * 8.699;
                    }
                    else
                    {
                        waterBill = 10 * 5.973 + 10 * 7.052 + 10 * 8.699 + (consumption - 30) * 15.929;
                    }
                    break;
                case 2:
                case 3:
                    waterBill = consumption * 9.955;
                    break;
                case 4:
                    waterBill = consumption * 11.615;
                    break;
                case 5:
                    waterBill = consumption * 22.068;
                    break;
                default:
                    throw new ArgumentException("Error: Invalid customer type");
            }
            double environmentProtectionFee = waterBill / 10;
            double result = waterBill + environmentProtectionFee;
            return result;
        }

        static void Imported_customer_list()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Would you like to see a list of customers [y/n}?");
                string YesNo = Console.ReadLine();
                if (YesNo.ToLower() == "y")
                {
                    Console.Clear();
                    Console.WriteLine("List of customers:");
                    for (int i = 0; i < customers.Count; i++)
                    {
                        string[] customerInfo = customers[i].Split(',');
                        Console.WriteLine($"{i + 1}.{customerInfo[0]}");
                    }
                    SearchCustomer();
                    Console.Clear();
                    break;
                }
                else if (YesNo.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }
        //====================================
        static void display_results(string customerName, double lastMonthReading, double thisMonthReading, double consumption, double result)
        {
            // Hiển thị kết quả
            Console.Clear();
            Console.WriteLine("======Monthly Water Bill Calculator!=====");
            Console.WriteLine($"|| Customer Name: {customerName}");
            Console.WriteLine($"|| Last Month's Reading: {lastMonthReading} m3");
            Console.WriteLine($"|| This Month's Reading: {thisMonthReading} m3");
            Console.WriteLine($"|| Consumption: {consumption} m3");
            Console.WriteLine($"|| Total Water Bill: {result} VND", Math.Round(result, 3));
            Console.WriteLine("=========================================");
        }
        //=======================================================================================
        static void SearchCustomer()
        {
            while (true)
            {
                Console.Write("Enter customer number to select: ");
                int customerNumber;
                while (!int.TryParse(Console.ReadLine(), out customerNumber) || customerNumber < 1 || customerNumber > customers.Count)
                {
                    Console.WriteLine("Error: Invalid customer number, please re-enter");
                    Console.Write("Enter customer number to select: ");
                }

                string customerInfo = customers[customerNumber - 1];
                string[] customerData = customerInfo.Split(',');
                Console.Clear();
                Console.WriteLine("Selected customer:");
                Console.WriteLine("======Monthly Water Bill Calculator!=====");
                Console.WriteLine($"Name: {customerData[0]}");
                Console.WriteLine($"Customer Type: {customerData[1]}");
                Console.WriteLine($"Number of People: {customerData[2]}");
                Console.WriteLine($"Last Month's Reading: {customerData[3]} m3");
                Console.WriteLine($"This Month's Reading: {customerData[4]} m3");
                Console.WriteLine($"Consumption: {customerData[5]} m3");
                Console.WriteLine($"Total Water Bill: {customerData[6]} VND");
                Console.WriteLine("=========================================");
                //
                Console.WriteLine("Do you want to continue searching, enter new customer information, or exit: ");
                Console.WriteLine("1. Continue searching");
                Console.WriteLine("2. Other");
                Console.Write("Enter your option: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Imported_customer_list();
                    Console.Clear();
                    break;
                }
                else if (option == 2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }
        }
    }

}
