using System;

namespace CW_Beach
{
    internal class AdressOffset
    {
        //-------------------------------------------------Adress update 1.25.2.11487422--------------------------------------------

        public static IntPtr PlayerBase = (IntPtr)0x10A5F758; //G_Client
        public static IntPtr CMDBufferBase = (IntPtr)0xD7F7910;
        public static IntPtr XPScaleBase = (IntPtr)0x10A8F748;

        //--------------------------------------------------------Offset------------------------------------------------------------
        // If after change adress your game crash it's because offset change probably

        public const int PlayerXP = 0x20;
        public const int PlayerXP2 = 0x28;
        public const int WeaponXP = 0x30;

        public const int PC_ArraySize_Offset = 0xB970;
        public const int PC_CurrentUsedWeaponID = 0x28;
        public const int PC_SetWeaponID = 0xB0; // +(1-5 * 0x40 for WP2 to WP6)
        public const int PC_InfraredVision = 0xE66; // (byte) On=0x10|Off=0x0
        public const int PC_GodMode = 0xE67; // (byte) On=0xA0|Off=0x20
        public const int PC_RapidFire1 = 0xE6C;
        public const int PC_RapidFire2 = 0xE80;
        public const int PC_MaxAmmo = 0x1360; // +(1-5 * 0x8 for WP1 to WP6)
        public const int PC_Ammo = 0x13D4; // +(1-5 * 0x4 for WP1 to WP6)
        public const int PC_Points = 0x5D24;
        public const int PC_Name = 0x605C;
        public const int PC_RunSpeed = 0x5C70;
        public const int PC_ClanTags = 0x605C;
        public const int PC_autoFire = 0xE70;
        public const int PC_Coords = 0xDE8; // writeable only

        public const int KillCount = 0x5CE8;
        public const int CritKill8 = 0x10DA;

        public const int PP_ArraySize_Offset = 0x5E8;

        public const int PP_Health = 0x398;
        public const int PP_MaxHealth = 0x39C;
        public const int PP_Coords = 0x2D4; // read only
        public const int PP_Heading_Z = 0x34;
        public const int PP_Heading_XY = 0x38;

        public const int ZM_Global_MovedOffset = 0x0;
        public const int ZM_Global_ZombiesIgnoreAll = 0x14;

        public const int ZM_Bot_List_Offset = 0x8;

        public const int ZM_Bot_ArraySize_Offset = 0x5E8;

        public const int ZM_Bot_Health = 0x390;
        public const int ZM_Bot_MaxHealth = 0x39C;
        public const int ZM_Bot_Coords = 0x2D4;
    }
}
