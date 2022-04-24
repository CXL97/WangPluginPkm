﻿using PKHeX.Core;

namespace WangPlugin

{
    /// <summary>
    /// Contains logic for the Generation 8 (SW/SH) overworld spawns that walk around the overworld.
    /// </summary>
    /// <remarks>
    /// Entities spawned into the overworld that can be encountered are assigned a 32bit seed, which can be immediately derived from the <see cref="PKM.EncryptionConstant"/>.
    /// </remarks>
    public static class Overworld8RNGM
    {
       
        private const int UNSET = 255;
        public static uint Next(uint seed) => (uint)new Xoroshiro128Plus(seed).Next();
        public static PKM GenPkm(PKM pk,uint seed, int TID, int SID)
        {
            var xoro = new Xoroshiro128Plus(seed);

            var ec= (uint)xoro.NextInt(uint.MaxValue);
            pk.EncryptionConstant = ec;
            // PID
            var pid = (uint)xoro.NextInt(uint.MaxValue);
            pk.PID = pid;
            // IVs
            var ivs = new int[6] { UNSET, UNSET, UNSET, UNSET, UNSET, UNSET };
           
            const int MAX = 31;
            for (int i = 0; i < 0; i++)
            {
                int index;
                do { index = (int)xoro.NextInt(6); }
                while (ivs[index] != UNSET);

                ivs[index] = MAX;
            }
            for (int i = 0; i < ivs.Length; i++)
            {
                if (ivs[i] == UNSET)
                    ivs[i] = (int) xoro.NextInt(32);
            }
            pk.IV_HP = ivs[0];
            pk.IV_ATK = ivs[1];
            pk.IV_DEF = ivs[2];
            pk.IV_SPA = ivs[3];
            pk.IV_SPD = ivs[4];
            pk.IV_SPE = ivs[5];
            // Remainder
            var ability =( 1 << (int)xoro.NextInt(2));
            var scale = (IScaledSize)pk;
            scale.HeightScalar = (byte)((int)xoro.NextInt(0x81) + (int)xoro.NextInt(0x80));
            scale.WeightScalar = (byte)((int)xoro.NextInt(0x81) + (int)xoro.NextInt(0x80));
            pk.AbilityNumber = ability;
            return pk;
        }
        private static uint GetShinyPID(int tid, int sid, uint pid, int type)
        {
            return (uint)(((tid ^ sid ^ (pid & 0xFFFF) ^ type) << 16) | (pid & 0xFFFF));
        }

        private static bool GetIsShiny(int tid, int sid, uint pid)
        {
            return GetShinyXor(pid, (uint)((sid << 16) | tid)) < 16;
        }

        private static uint GetShinyXor(uint pid, uint oid)
        {
            var xor = pid ^ oid;
            return (xor ^ (xor >> 16)) & 0xFFFF;
        }
        private static uint GetShinyNum(int tid, int sid, uint pid)
        {
            var oid =(uint)( (sid << 16) | tid);
            return GetShinyXor(pid, oid);
        }

        /// <summary>
        /// Obtains the original seed for the Generation 8 overworld wild encounter.
        /// </summary>
        /// <param name="trainer">Entity to check for</param>
        /// <returns>Seed</returns>
       
    }
}