using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MOD.TrainingService.Models;

namespace MOD.TrainingService.Repositories
{
    public interface ITrainingRepository
    {
        void add(Training Item);
        IEnumerable<Training> GetAll();
        void UpdateR(Training item);
        void Delete(int id);
    }
}
