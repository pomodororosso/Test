using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace JustEat.Web.Tests
{
    [Binding]
    public class StepArgumentTransformations
    {
        [StepArgumentTransformation("should")]
        public bool Should()
        {
            return true;
        }
        
        [StepArgumentTransformation("should not")]
        public bool ShouldNot()
        {
            return false;
        }
    }
}
