using SFFG.BAL.Models;
using SFFG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Interface
{
    public interface ILessonRepository
    {
        bool AddNewLesson(LessonDTO lesson);

        List<LessonDTO> GetAllLessons(int secId);

        LessonDTO? ViewLesson(int id);

        bool UpdateLesson(int id, LessonDTO lesson);

        bool DeleteLesson(int id);
    }
}
