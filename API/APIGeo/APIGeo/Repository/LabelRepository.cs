using APIGeo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGeo.Repository
{
    public class LabelRepository: Base<Label>
    {
        public Label Save(Label label)
        {
            if (label.Id == 0)
                label.Id = this.Add(label);
            else
                this.Update(label);
            return label;
        }
    }
}
