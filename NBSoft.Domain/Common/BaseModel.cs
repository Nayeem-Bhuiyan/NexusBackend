using NBSoft.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBSoft.Domain.Common
{
    public class BaseModel: IEntity
    {
        public int Id { get; set; }
    }
}
