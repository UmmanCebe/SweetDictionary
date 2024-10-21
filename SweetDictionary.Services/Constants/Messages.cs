using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDictionary.Services.Constants
{
    public static class Messages
    {
        public const string PostAddedMessage = "Post Eklendi.";
        public const string PostUpdatedMessage = "Post Güncellendi.";
        public const string PostDeletedMessage = "Post Silindi.";
        public static string PostIsNotPresentMessage(Guid id)
        {
            return $"İlgili id li post bulunamadı";
        }
    }
}
