using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Movie
    {
        private string title;
        private string category;

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }

        public String GetTitle()
        {
            return title;
        }

        public String GetCategory()
        {
            return category;
        }

        public void SetTitle(string title1)
        {
            this.title = title1;
        }

        public void SetCategory(string category1)
        {
            this.category = category1;
        }
    }
}


