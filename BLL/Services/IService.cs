using System;
using System.Collections.Generic;
using System.Text;
using Shared.DTOs;

namespace BLL.Services
{
    interface IService
    {
        List<EntityDTO> FetchAll();
        void Create(EntityDTO entity);
        void Update(Guid entityId, EntityDTO newEntity);
        void Delete(Guid id);
        void Save();
    }
}
