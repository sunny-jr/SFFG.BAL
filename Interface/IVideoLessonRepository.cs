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
        bool AddNewSection(int secId, VideoLessonsDTO lesson);

        List<VideoLessonsDTO> GetAllSections(int secId);

        VideoLessonsDTO? ViewSection(int id);

        bool UpdateSection(int id, VideoLessonsDTO lesson);

        bool DeleteSection(int id);
    }
}
