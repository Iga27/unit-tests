using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOperations
{
    public class MemberManager: IMemberManager
    {

        List<Member> memberList;

        public MemberManager()
        {
            memberList = new List<Member>() {
                new Member { MemberID=1,MaximumBookCanBorrow=45},
                new Member { MemberID=2,MaximumBookCanBorrow=54 } };
        }

        public Member GetMember(int memberId)
        {
            //throw new NotImplementedException();
           return memberList.Find(x => x.MemberID == memberId);
        }
    }
}
