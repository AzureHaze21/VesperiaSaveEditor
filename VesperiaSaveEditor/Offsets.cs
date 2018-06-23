using System;

namespace VesperiaSE
{
    internal class Offsets
    {
        public struct Misc
        {
            public struct Gald
            {
                public const UInt32 startAddr = 0x0A3F78;
            }

            public struct Dlc
            {
                public const UInt32 startAddr = 0xA5814;
                public const UInt32 endAddr = 0xA5A2C;
            }
        }

        public struct Characters
        {
            public struct Yuri
            {
                public const UInt32 lvlAddr = 0x0A8970;
                public const UInt32 currHPAddr = 0xA8974;
                public const UInt32 maxHPAddr = 0xA897C;
                public const UInt32 maxTPAddr = 0xA8980;
                public const UInt32 expAddr = 0xA8988;
                public const UInt32 pAtkAddr = 0xA8A60;
                public const UInt32 mAtkAddr = 0xA8A64;
                public const UInt32 pDefAddr = 0xA8A68;
                public const UInt32 mDefAddr = 0xA8A6C;
                public const UInt32 agiAddr = 0xA8A74;
                public const UInt32 luckAddr = 0xA8A78;
                public const UInt32 spAddr = 0xAAE20;
                public const UInt32 maxSpAddr = 0xAAE24;
            }

            public struct Estelle
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x4010;
                public const UInt32 currHPAddr = 0xA8974 + 0x4010;
                public const UInt32 maxHPAddr = 0xA897C + 0x4010;
                public const UInt32 maxTPAddr = 0xA8980 + 0x4010;
                public const UInt32 expAddr = 0xA8988 + 0x4010;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x4010;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x4010;
                public const UInt32 pDefAddr = 0xA8A68 + 0x4010;
                public const UInt32 mDefAddr = 0xA8A6C + 0x4010;
                public const UInt32 agiAddr = 0xA8A74 + 0x4010;
                public const UInt32 luckAddr = 0xA8A78 + 0x4010;
                public const UInt32 spAddr = 0xAAE20 + 0x4010;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x4010;
            }

            public struct Karol
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x8020;
                public const UInt32 currHPAddr = 0xA8974 + 0x8020;
                public const UInt32 maxHPAddr = 0xA897C + 0x8020;
                public const UInt32 maxTPAddr = 0xA8980 + 0x8020;
                public const UInt32 expAddr = 0xA8988 + 0x8020;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x8020;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x8020;
                public const UInt32 pDefAddr = 0xA8A68 + 0x8020;
                public const UInt32 mDefAddr = 0xA8A6C + 0x8020;
                public const UInt32 agiAddr = 0xA8A74 + 0x8020;
                public const UInt32 luckAddr = 0xA8A78 + 0x8020;
                public const UInt32 spAddr = 0xAAE20 + 0x8020;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x8020;
            }

            public struct Rita
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0xC030;
                public const UInt32 currHPAddr = 0xA8974 + 0xC030;
                public const UInt32 maxHPAddr = 0xA897C + 0xC030;
                public const UInt32 maxTPAddr = 0xA8980 + 0xC030;
                public const UInt32 expAddr = 0xA8988 + 0xC030;
                public const UInt32 pAtkAddr = 0xA8A60 + 0xC030;
                public const UInt32 mAtkAddr = 0xA8A64 + 0xC030;
                public const UInt32 pDefAddr = 0xA8A68 + 0xC030;
                public const UInt32 mDefAddr = 0xA8A6C + 0xC030;
                public const UInt32 agiAddr = 0xA8A74 + 0xC030;
                public const UInt32 luckAddr = 0xA8A78 + 0xC030;
                public const UInt32 spAddr = 0xAAE20 + 0xC030;
                public const UInt32 maxSpAddr = 0xAAE24 + 0xC030;
            }

            public struct Raven
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x10040;
                public const UInt32 currHPAddr = 0xA8974 + 0x10040;
                public const UInt32 maxHPAddr = 0xA897C + 0x10040;
                public const UInt32 maxTPAddr = 0xA8980 + 0x10040;
                public const UInt32 expAddr = 0xA8988 + 0x10040;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x10040;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x10040;
                public const UInt32 pDefAddr = 0xA8A68 + 0x10040;
                public const UInt32 mDefAddr = 0xA8A6C + 0x10040;
                public const UInt32 agiAddr = 0xA8A74 + 0x10040;
                public const UInt32 luckAddr = 0xA8A78 + 0x10040;
                public const UInt32 spAddr = 0xAAE20 + 0x10040;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x10040;
            }

            public struct Judith
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x14050;
                public const UInt32 currHPAddr = 0xA8974 + 0x14050;
                public const UInt32 maxHPAddr = 0xA897C + 0x14050;
                public const UInt32 maxTPAddr = 0xA8980 + 0x14050;
                public const UInt32 expAddr = 0xA8988 + 0x14050;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x14050;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x14050;
                public const UInt32 pDefAddr = 0xA8A68 + 0x14050;
                public const UInt32 mDefAddr = 0xA8A6C + 0x14050;
                public const UInt32 agiAddr = 0xA8A74 + 0x14050;
                public const UInt32 luckAddr = 0xA8A78 + 0x14050;
                public const UInt32 spAddr = 0xAAE20 + 0x14050;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x14050;
            }

            public struct Repede
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x18060;
                public const UInt32 currHPAddr = 0xA8974 + 0x18060;
                public const UInt32 maxHPAddr = 0xA897C + 0x18060;
                public const UInt32 maxTPAddr = 0xA8980 + 0x18060;
                public const UInt32 expAddr = 0xA8988 + 0x18060;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x18060;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x18060;
                public const UInt32 pDefAddr = 0xA8A68 + 0x18060;
                public const UInt32 mDefAddr = 0xA8A6C + 0x18060;
                public const UInt32 agiAddr = 0xA8A74 + 0x18060;
                public const UInt32 luckAddr = 0xA8A78 + 0x18060;
                public const UInt32 spAddr = 0xAAE20 + 0x18060;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x18060;
            }

            public struct Flynn
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x1C070;
                public const UInt32 currHPAddr = 0xA8974 + 0x1C070;
                public const UInt32 maxHPAddr = 0xA897C + 0x1C070;
                public const UInt32 maxTPAddr = 0xA8980 + 0x1C070;
                public const UInt32 expAddr = 0xA8988 + 0x1C070;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x1C070;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x1C070;
                public const UInt32 pDefAddr = 0xA8A68 + 0x1C070;
                public const UInt32 mDefAddr = 0xA8A6C + 0x1C070;
                public const UInt32 agiAddr = 0xA8A74 + 0x1C070;
                public const UInt32 luckAddr = 0xA8A78 + 0x1C070;
                public const UInt32 spAddr = 0xAAE20 + 0x1C070;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x1C070;
            }

            public struct Patty
            {
                public const UInt32 lvlAddr = 0x0A8970 + 0x20080;
                public const UInt32 currHPAddr = 0xA8974 + 0x20080;
                public const UInt32 maxHPAddr = 0xA897C + 0x20080;
                public const UInt32 maxTPAddr = 0xA8980 + 0x20080;
                public const UInt32 expAddr = 0xA8988 + 0x20080;
                public const UInt32 pAtkAddr = 0xA8A60 + 0x20080;
                public const UInt32 mAtkAddr = 0xA8A64 + 0x20080;
                public const UInt32 pDefAddr = 0xA8A68 + 0x20080;
                public const UInt32 mDefAddr = 0xA8A6C + 0x20080;
                public const UInt32 agiAddr = 0xA8A74 + 0x20080;
                public const UInt32 luckAddr = 0xA8A78 + 0x20080;
                public const UInt32 spAddr = 0xAAE20 + 0x20080;
                public const UInt32 maxSpAddr = 0xAAE24 + 0x20080;
            }
        }

        public struct Items
        {
            public struct Consumables
            {
                public const UInt32 startAddr = 0x0A3F8;
                public const UInt32 endAddr = 0x0A4B67;
            }

            public struct Weapons
            {
                public struct Swords
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct Axes
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct Hammers
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct Clubs
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct Staves
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct Scrolls
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct LightBows
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct HeavyBows
                {
                    public const UInt32 startAddr = 0x0A402F;
                    public const UInt32 endAddr = 0x0A4B6B;
                }

                public struct Daggers
                {
                    public const UInt32 startAddr = 0x0A430B;
                    public const UInt32 endAddr = 0x0A435B;
                }
            }

            public struct SubWeapons
            {
                public struct Shield
                {
                    public const UInt32 startAddr = 0x0A439B;
                    public const UInt32 endAddr = 0x0A43C7;
                }

                public struct Gloves
                {
                    public const UInt32 startAddr = 0x0A43CF;
                    public const UInt32 endAddr = 0x0A43DF;
                }

                public struct Books
                {
                    public const UInt32 startAddr = 0x0A43E3;
                    public const UInt32 endAddr = 0x0A43FB;
                }

                public struct Knives
                {
                    public const UInt32 startAddr = 0x0A43FF;
                    public const UInt32 endAddr = 0x0A440B;
                }

                public struct Boots
                {
                    public const UInt32 startAddr = 0x0A440F;
                    public const UInt32 endAddr = 0x0A4B57;
                }

                public struct Bags
                {
                    public const UInt32 startAddr = 0x0A441F;
                    public const UInt32 endAddr = 0x0A4423;
                }

                public struct Collars
                {
                    public const UInt32 startAddr = 0x0A4427;
                    public const UInt32 endAddr = 0x0A443B;
                }
                /* WIP
                public struct Guns
                {
                    public const UInt32 startAddr = 0x0A43FF;
                    public const UInt32 endAddr = 0x0A440B;
                }
                */
            }
            /* WIP
            public struct Costumes
            {
                public struct Yuri
                {
                    public const UInt32 maxValue = 0x0FFFFEFE;
                }
            }
            */
        }

    }
}
