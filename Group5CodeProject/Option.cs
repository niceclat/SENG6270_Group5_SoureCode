using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /// <summary>
    /// Parent for all option classes
    /// </summary>
    public class Option
    {
        public List<string> items { get; set; }
        public string SelectedItem { get; set; }
    }
