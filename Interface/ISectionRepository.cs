using SFFG.BAL.Models;
using SFFG.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFG.BAL.Interface
{
    public interface ISectionRepository
    {
        bool AddNewSection(int secId, SectionDTO lesson);

        List<SectionDTO> GetAllSections(int secId);

        SectionDTO? ViewSection(int id);

        bool UpdateSection(int id, SectionDTO lesson);

        bool DeleteSection(int id);
    }
}
