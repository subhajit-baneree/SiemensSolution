using Discount.Calculator.Models;
using Discount.Calculator.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Service.Implementations
{
    public class InputService : IInputService
    {
        public CalculationInputModel GetCalculationDetails()
        {
            var calculationInputModel = new CalculationInputModel();
            while (true) 
            {
                Console.WriteLine("Enter price of Gold*:");
                var price = Console.ReadLine();
                if (string.IsNullOrEmpty(price) || string.IsNullOrWhiteSpace(price))
                {
                    Console.WriteLine("Price of Gold cannot be empty.");
                }
                else
                {
                    try
                    {
                        calculationInputModel.Price = Convert.ToDouble(price);
                        break;
                    }
                    catch (Exception) { }
                }
                
            }

            while (true)
            {
                Console.WriteLine("Enter quantity of Gold*:");
                var quantity = Console.ReadLine();
                if (string.IsNullOrEmpty(quantity) || string.IsNullOrWhiteSpace(quantity))
                {
                    Console.WriteLine("Quantity of Gold cannot be empty.");
                }
                else
                {
                    try
                    {
                        calculationInputModel.Quantity = Convert.ToDouble(quantity);
                        break;
                    }
                    catch (Exception) { }
                }
            }

            while (true) 
            {
                Console.WriteLine("Enter discount percentage:");
                var discount = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(discount) || string.IsNullOrEmpty(discount))
                {
                    break;
                }
                else 
                {
                    try
                    {
                        if (Convert.ToDouble(discount) > 100) 
                        {
                            throw new Exception();
                        }
                        calculationInputModel.DiscountPercentage = Convert.ToDouble(discount);
                        break;
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("Inalid discount");
                        break;
                    }
                }
            }

            return calculationInputModel;
        }


        public UserModel GetLoginDetails()
        {
            var userModel = new UserModel();
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter UserID*:");
                    var userId = Console.ReadLine();
                    if (string.IsNullOrEmpty(userId) || string.IsNullOrWhiteSpace(userId))
                    {
                        Console.WriteLine("UserID cannot be empty.");
                    }
                    else
                    {
                        userModel.UserId = userId;
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter Password*:");
                    var password = Console.ReadLine();
                    if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
                    {
                        Console.WriteLine("Password cannot be empty.");
                    }
                    else
                    {
                        userModel.Password = password;
                        break;
                    }

                }

                return userModel;
            }
            catch (Exception) 
            {
                return null;
            }
        }
    }
}
