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
    public class VideoLessonRepository : IVideoLessonRepository
    {
        DAL.IRepositories.IVideoLessonRepository _lesson;
        IMapper _mapper;
        public VideoLessonRepository(DAL.IRepositories.IVideoLessonRepository repo, IMapper mapper)
        {
            _lesson = repo;
            _mapper = mapper;
        }

        public bool AddNewSection(int secId, VideoLessonsDTO lesson)
        {
            if (secId >= 0 && lesson.Equals(null)) return false;

            var convertDTO = _mapper.Map<VideoLessonsDTO, VideoLesson>(lesson);
            var result = _lesson.CreateVideoLesson(secId, convertDTO);
            return result;
        }

        public bool DeleteSection(int id)
        {
            if (id > 0) return false;

            return _lesson.DeleteVideoLesson(id);
        }

        public List<VideoLessonsDTO> GetAllSections(int secId)
        {
            if (secId >= 0) return new List<VideoLessonsDTO>();

            return _mapper.Map<List<VideoLesson>, List<VideoLessonsDTO>>(_lesson.GetVideoLessons(secId));
        }

        public bool UpdateSection(int id, VideoLessonsDTO lesson)
        {
            if (id > 0 && lesson is null) return false;

            var convertDTO = _mapper.Map<VideoLessonsDTO, VideoLesson>(lesson);
            return _lesson.UpdateVideoLesson(id, convertDTO);
        }

        public VideoLessonsDTO? ViewSection(int id)
        {
            if (id > 0) return null;

            var lesson = _lesson.ViewVideoLesson(id);
            if (lesson is null) return null;

            return _mapper.Map<VideoLesson, VideoLessonsDTO>(lesson);
        }
    }
}
