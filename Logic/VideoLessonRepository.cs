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
        DAL.IRepositories.IVideoLessonRepository _videoLesson;
        IMapper _mapper;
        public VideoLessonRepository(DAL.IRepositories.IVideoLessonRepository repo, IMapper mapper)
        {
            _videoLesson = repo;
            _mapper = mapper;
        }

        public bool AddNewVideoLesson(VideoLessonsDTO video)
        {
            if (video.Equals(null)) return false;

            var convertDTO = _mapper.Map<VideoLessonsDTO, VideoLesson>(video);
            var result = _videoLesson.CreateVideoLesson(convertDTO);
            return result;
        }

        public bool DeleteVideo(int id)
        {
            if (id > 0) return false;

            return _videoLesson.DeleteVideoLesson(id);
        }

        public List<VideoLessonsDTO> GetAllVideo(int secId)
        {
            if (secId >= 0) return new List<VideoLessonsDTO>();

            return _mapper.Map<List<VideoLesson>, List<VideoLessonsDTO>>(_videoLesson.GetVideoLessons(secId));
        }

        public bool UpdateVideos(int id, VideoLessonsDTO lesson)
        {
            if (id > 0 && lesson is null) return false;

            var convertDTO = _mapper.Map<VideoLessonsDTO, VideoLesson>(lesson);
            return _videoLesson.UpdateVideoLesson(id, convertDTO);
        }

        public VideoLessonsDTO? ViewVideos(int id)
        {
            if (id > 0) return null;

            var lesson = _videoLesson.ViewVideoLesson(id);
            if (lesson is null) return null;

            return _mapper.Map<VideoLesson, VideoLessonsDTO>(lesson);
        }
    }
}
