using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.DAL;
using Entities;

namespace Department.BLL
{
    public class DocumentsBL
    {
        private IDocumentsDAO documentsDAO;

        public DocumentsBL(IDocumentsDAO documentsDAO)
        {
            this.documentsDAO = documentsDAO;
        }

        public IEnumerable<Entities.Documents> GetDocuments()
        {
            return documentsDAO.GetDocuments();
        }

        public void AddDocument(Documents document)
        {
            documentsDAO.AddDocument(document);
        }

        public void UpdateDocument(Documents document)
        {
            documentsDAO.UpdateDocument(document);
        }

        public void DeleteDocument(Documents document)
        {
            documentsDAO.DeleteDocument(document);
        }
    }
}
