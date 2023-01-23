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
    public class SectionRepository : ISectionRepository
    {
        DAL.IRepositories.ISectionRepository _section;
        IMapper _mapper;

        public SectionRepository(DAL.IRepositories.ISectionRepository repo, IMapper mapper)
        {
            _section = repo;
            _mapper = mapper;
        }
        public bool AddNewSection(int secId, SectionDTO lesson)
        {
            if (secId >= 0 && lesson.Equals(null)) return false;

            var convertDTO = _mapper.Map<SectionDTO, MisSection>(lesson);
            var result = _section.CreateSection(secId, convertDTO);
            return result;

            //throw new NotImplementedException();
        }

        public bool DeleteSection(int id)
        {
            if (id > 0) return false;

            return _section.DeleteSection(id);
        }

        public List<SectionDTO> GetAllSections(int secId)
        {

            if (secId >= 0) return new List<SectionDTO>();

            return _mapper.Map<List<MisSection>, List<SectionDTO>>(_section.GetSections(secId));
        }

        public bool UpdateSection(int id, SectionDTO section)
        {
            if (id > 0 && section is null) return false;

            var convertDTO = _mapper.Map<SectionDTO, MisSection>(section);
            return _section.UpdateSection(id, convertDTO);
        }

        public SectionDTO? ViewSection(int id)
        {
            if (id > 0) return null;

            var section = _section.ViewSection(id);
            if (section is null) return null;

            return _mapper.Map<MisSection, SectionDTO>(section);
        }
    }
}
