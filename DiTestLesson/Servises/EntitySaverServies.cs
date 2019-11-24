using DiTestLesson.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiTestLesson.Servises
{
    public class EntitySaverServies : IEntityServies
    {
        public Task SaveEntity(EntityDTO entity)
        {
            var jsonResult = JsonConvert.SerializeObject(entity);
            return System.IO.File.WriteAllTextAsync("1.json", jsonResult);
        }
    }
}
