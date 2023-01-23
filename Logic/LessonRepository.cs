using AutoMapper;
using SFFG.BAL.Interface;
using SFFG.BAL.Models;
using SFFG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Logic
{
    public class LessonRepository : ILessonRepository
    {
        private DAL.IRepositories.ILessonRepository _lesson;
        private IMapper _mapper;
        public LessonRepository(DAL.IRepositories.ILessonRepository repo, IMapper mapper)
        {
            _lesson = repo;
            _mapper = mapper;
        }
        public bool AddNewLesson(int secId, LessonDTO lessons)
        {
            if (secId >= 0 && lessons.Equals(null)) return false;

            var lesson = _mapper.Map<LessonDTO,Lesson>(lessons);

  
            var result = _lesson.CreateLesson(secId, lesson);
            
            return result;
            //throw new NotImplementedException();
        }

        public bool DeleteLesson(int id)
        {
            if (id > 0) return false;

            return _lesson.DeleteLesson(id);

        }

        public List<LessonDTO> GetAllLessons(int secId)
        {
            if (secId >= 0) return new List<LessonDTO>();

            return _mapper.Map<List<Lesson>,List<LessonDTO>>(_lesson.GetLessons(secId));
            //throw new NotImplementedException();
        }

        public bool UpdateLesson(int id, LessonDTO lesson)
        {
            if(id > 0 && lesson is null) return false;

            var convertDTO = _mapper.Map<LessonDTO, Lesson>(lesson);
            return _lesson.UpdateLesson(id, convertDTO);    
            //throw new NotImplementedException();
        }

        public LessonDTO? ViewLesson(int id)
        {
            if (id > 0) return null;

            var lesson = _lesson.ViewLesson(id);
            if(lesson is null) return null;

            return _mapper.Map<Lesson,LessonDTO>(lesson);
            //throw new NotImplementedException();
        }

 
    }
}
