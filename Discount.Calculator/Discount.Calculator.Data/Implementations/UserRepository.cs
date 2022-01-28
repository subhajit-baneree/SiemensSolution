using Discount.Calculator.Data.Interfaces;
using Discount.Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Calculator.Data.Implementations
{
    public class UserRepository : IUserRepository
    {
        static List<UserModel> RegisteredUser;

        public UserRepository()
        {
            RegisteredUser = new List<UserModel>();
            LoadData();
        }
        
        public bool IsUserValid(UserModel userDetail)
        {
            if (RegisteredUser.Any(user => user.UserId.Equals(userDetail.UserId) && user.Password.Equals(userDetail.Password)))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void LoadData()
        {
            RegisteredUser.Add(new UserModel() 
            {
                UserId = "user1",
                Password = "1111"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "user2",
                Password = "2222"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "user3",
                Password = "3333"
            });

            RegisteredUser.Add(new UserModel()
            {
                UserId = "user4",
                Password = "4444"
            });           
        }
    }
}
