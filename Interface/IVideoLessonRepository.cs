using SFFG.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Interface
{
    public interface IVideoLessonRepository
    {
        bool AddNewVideoLesson(VideoLessonsDTO video);

        List<VideoLessonsDTO> GetAllVideo(int secId);

        VideoLessonsDTO? ViewVideos(int id);

        bool UpdateVideos(int id, VideoLessonsDTO lesson);

        bool DeleteVideo(int id);
    }
}
