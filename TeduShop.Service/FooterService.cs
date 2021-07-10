using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IFooterService
    {
        void Add(Footer post);
        void Update(Footer post);
        void Delete(int id);
        IEnumerable<Footer> GetAll();
        IEnumerable<Footer> GetAllPaging(int page, int pagesize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Footer> GetAllByTagPaging(string tag, int page, int pagesize, out int totalRow);
        void SaveChanges();
    }
    class FooterService : IFooterService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Footer footer)
        {
            _footerRepository.Add(footer);
        }

        public void Delete(int id)
        {
            _footerRepository.Delete(id);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public IEnumerable<Footer> GetAllByTagPaging(string tag, int page, int pagesize, out int totalRow)
        {
            totalRow = 0;
            return null;
        }

        public IEnumerable<Footer> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
    }
}
