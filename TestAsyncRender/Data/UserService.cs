using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAsyncRender.Data
{
    public class UserService
    {

        public async Task<List<User>> GetUsersAsync()
        {
            await Task.Delay(1000);

            var users = new List<User>()
            {
                new(){Name = "Tom"},
                new(){Name = "Rick"},
                new(){Name = "Jones"}
            };

            return users;
        }

        public List<User> GetUsersSync()
        {
            var users = new List<User>()
            {
                new(){Name = "Tom"},
                new(){Name = "Rick"},
                new(){Name = "Jones"}
            };

            return users;
        }
    }
}
