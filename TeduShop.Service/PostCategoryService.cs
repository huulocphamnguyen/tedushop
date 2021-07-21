using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);

        PostCategory Delete(int Id);
         
        void Update(PostCategory postCategory);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllParentById(int parentId);

        PostCategory GetById(int Id);
        void Save();
    }

    internal class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
           return _postCategoryRepository.Add(postCategory);
        }

        public PostCategory Delete(int Id)
        {
            return _postCategoryRepository.Delete(Id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllParentById(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ID == parentId);
        }

        public PostCategory GetById(int Id)
        {
            return _postCategoryRepository.GetSingleById(Id);
        }
        public void Save()
        {
            _unitOfWork.Commit();
        }
        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}