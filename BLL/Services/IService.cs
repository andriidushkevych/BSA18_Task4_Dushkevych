using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTOs;

namespace BLL.Services
{
    public interface IService<EntityDTO> where EntityDTO : class
    {
        List<EntityDTO> FetchAll();
        EntityDTO GetById(Guid id);
        void Create(EntityDTO entity);
        void Update(EntityDTO newEntity);
        void Delete(Guid id);
    }
}
