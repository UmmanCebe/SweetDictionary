using Core.Exceptions;
using SweetDictionary.Repositories.Repositories.Abstracts;

namespace SweetDictionary.Services.Rules;
public class PostBusinessRules(IPostRepository _postRepository)
{
    public void PostIsPresent(Guid id)
    {
        var post = _postRepository.GetById(id);
        if (post is null)
        {
            throw new NotFoundException($"İlgili id ye göre post bulunamadı : {id}");
        }

    }
}