using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4.Models;
public class BlogsEntity
{
    public string Article { get; set; }
    public List<string> Paragraphs { get; set; }
    public string ImagePath { get; set; }
    public List<string> Tags { get; set; }
}
