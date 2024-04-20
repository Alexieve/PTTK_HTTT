using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViTriUngTuyenDTO
    {
        private string _MAHOPDONG;
        private string _TENDN;
        private string _CAPBACTD;
        private string _VITRITD;

        public string MAHOPDONG { get => _MAHOPDONG; set => _MAHOPDONG = value; }
        public string TENDN { get => _TENDN; set => _TENDN = value; }
        public string CAPBACTD { get => _CAPBACTD; set => _CAPBACTD = value; }
        public string VITRITD { get => _VITRITD; set => _VITRITD = value; }

        public ViTriUngTuyenDTO(string MAHOPDONG, string TENDN, string CAPBACTD, string VITRITD)
        {
            this.MAHOPDONG = MAHOPDONG;
            this.TENDN = TENDN;
            this.CAPBACTD = CAPBACTD;
            this.VITRITD = VITRITD;
        }


    }
}
