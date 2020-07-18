using BLL.Interface;
using DTO;
using ISqlDataFactory;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.BusinessLogic
{
    public class AnoBLL : IAnoBLL
    {
        private readonly IBaseRepository<Ano> baseRepository;
        //private readonly IAnoRepository anoRepository;
        public AnoBLL(IBaseRepository<Ano> _baseRepository/*, IAnoRepository _anoRepository*/)
        {
            baseRepository = _baseRepository;
        }
        public void Add(Ano pAno)
        {
            baseRepository.Save(pAno);

        }

        public void Delete(Ano pAno)
        {
            baseRepository.Delete(pAno);
        }

        public List<Ano> GetAllAno(Ano pAno)
        {
            if (pAno == null)
            {
                pAno = Ano.getNew();
            }
            return baseRepository.GetAll(pAno);
        }

      
    }
}
