using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Persistence.Constants
{
    public class AppUserConstant
    {
        public const string IdConst1 = "075c1072-92a2-4f99-ac11-bf985b23da6e"; 
        public static Guid AppUserId1 = new Guid(IdConst1);

        public const string IdConst2 = "075c1072-92a2-4f95-ac11-bf985b23da6e";
        public static Guid AppUserId2 = new Guid(IdConst2);
    }


    public class AppRoleConstant
    {
        public const string IdConst1 = "075c1072-92a2-4f99-ac11-bf985b13da6e";
        public static Guid AppUserId1 = new Guid(IdConst1);

        public const string IdConst2 = "075c1072-92a2-4f95-ac11-bf985b63da6e";
        public static Guid AppUserId2 = new Guid(IdConst2);
    }

    public class ControllerConstant
    {
        public const string IdConst1 = "BF29882E-E8D5-4F61-AB0B-0416748DC03D";
        public static Guid ControllerId1 = new Guid(IdConst1);
    }

    public class ActionConstant
    {
        public const string IdConst1 = "A784DBE7-95DE-4CE5-BD1D-2EC3EA1791B9";
        public static Guid ActionId1 = new Guid(IdConst1);
    }

    public class CommomConstants
    {
        public const string AdminRole = "Admin";
    }

    public class FooterConstant
    {
        public const string Id1 = "075c1071-92a2-4f49-ac11-bf985b13da6e";
        public static Guid FooterId1 = new Guid(Id1);
    }

    public class ColorConstant
    {
        public const string IdConst3 = "075c1071-92a2-4f49-ac11-bf987b13da6e";
        public static Guid ColorId3 = new Guid(IdConst3);

        public const string IdConst2 = "075c1071-92a2-4f49-ac11-bf285b13da6e";
        public static Guid ColorId2 = new Guid(IdConst2);

        public const string IdConst1 = "075c1071-92a2-4f49-ac11-bf985b15da6e";
        public static Guid ColorId1 = new Guid(IdConst1);

        public const string IdConst4 = "075c1071-92a2-4f49-ac31-bf985b15da6e";
        public static Guid ColorId4 = new Guid(IdConst4);
    }
}
