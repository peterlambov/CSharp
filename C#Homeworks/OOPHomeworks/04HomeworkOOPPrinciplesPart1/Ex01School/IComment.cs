using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface IComment
    {
        List<string> comments { get; set; }
        void AddComment(string text);
    }

