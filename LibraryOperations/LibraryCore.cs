using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOperations
{
    public class LibraryCore
    {
        private IMemberManager memberManager;

        public LibraryCore(IMemberManager memberManager)
        {
            this.memberManager = memberManager;
        }

        public double CalculateMemberShipCost(int memberId)
        {
            Member member = memberManager.GetMember(memberId);
            return member.MaximumBookCanBorrow * 0.5 + 100;
        }
    }
}
