using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Passengers
    {
        private int id;
        private string surname, name, patronymic;
        private DateTime dateOfBirth;

        public int Id { get => id; set => id = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    
        public Passengers(int id, DateTime dateOfBirth, string surname, string name, string patronymic = null)
        {
            this.id = id;
            this.surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.patronymic = patronymic;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
