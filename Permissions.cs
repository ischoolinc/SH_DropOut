using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DropOut
{
	class Permissions
	{
		public static bool 休學證明書權限
		{
			get
			{
				return FISCA.Permission.UserAcl.Current[休學證明書].Executable;
			}
		}

		public static string 休學證明書 = "InvitationParents-{1C8A94A3-749F-48F5-9B8D-ACD85B544C9A}";
	}
}
