using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy
{
    public class DTO
    {
        string site_name;
        string site_link;
        string id;
        string pw;
        public string getSite_name()
        {
            return site_name;
        }
        public string getSite_link()
        {
            return site_link;
        }
        public string getId()
        {
            return id;
        }
        public string getPw()
        {
            return pw;
        }
        public void setSite_name(string site_name)
        {
            this.site_name = site_name;
        }
        public void setSite_link(string site_link)
        {
            this.site_link = site_link;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setPw(string pw)
        {
            this.pw = pw;
        }
    }
}
