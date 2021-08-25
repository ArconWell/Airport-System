using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.DAL
{
    public interface IDocumentsDAO
    {
        IEnumerable<Documents> GetDocuments();
        void AddDocument(Documents document);
        void UpdateDocument(Documents document);
        void DeleteDocument(Documents document);
    }
}
