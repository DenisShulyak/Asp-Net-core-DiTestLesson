using DiTestLesson.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiTestLesson.Servises
{
    public interface IEntityServies
    {
        Task SaveEntity(EntityDTO entity);
    }
}
