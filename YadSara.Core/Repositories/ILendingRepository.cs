using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using YadSara.Core.Entities;
namespace YadSara.Core.Repositories
{
    public interface ILendingRepository
    {
        public List<Lending> GetAll();
        public Lending GetById(int id);
        public List<Lending> GetByDate(DateTime date);
        public List<Lending> GetByLAndB(string borrowId, string lenderId);
        public Lending Update(Lending lending);
        public Lending Add(Lending lending);
        public void Delete(int id);
    }
}
