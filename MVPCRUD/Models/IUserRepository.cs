using DomainLayer.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ServiceLayers.Services.UserServices
{
    public interface IUsersRepository
    {
        void Add(UserModel userModel);
        void Update(UserModel userModel);
        void Delete(UserModel userModel);

        IEnumerable<UserModel> GetAll();

        UserModel Get(int id);

    }
}