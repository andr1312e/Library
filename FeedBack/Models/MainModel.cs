using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeedBack.Models
{
    public class MainModel
    {
        public List<Variant> Variants= new List<Variant>();
        public string Answers;

        public MainModel(List<Variant> variants, string answers) 
        {
            this.Answers = answers;
            Variants.AddRange(variants);
        }
    }
}
