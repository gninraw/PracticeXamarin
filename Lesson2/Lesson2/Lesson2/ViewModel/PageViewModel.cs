using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class PageViewModel
    {
        private String _lab1;
        public String Lab1
        {
            get
            {
                return _lab1;
            }

            set
            {
                _lab1 = value;
            }
        }

        public String Lab1Text { get; set; }
        public String Lab2Text { get; set; }
        public String Lab3Text { get; set; }

        public PageViewModel()
        {
            Lab1Text = "label!!!!!";
            Lab2Text = "2 text";
            Lab3Text = "3 text!!!!!!!";
        }
    }
}
