using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOperations
{
    public interface IMemberManager
    {
        Member GetMember(int memberId);
    }
}
