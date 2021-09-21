using System;
using System.Collections.Generic;
using UMT;
using UnityEngine;

namespace LongMan.GameUtil
{
    public static class MersenneRandom
    {
        public static Dictionary<int, MersenneTwister> RandomDic;
        
        public static int CurBaseSeed { get; private set; }
        
        private static bool _isInit;
        
        public static void InitRandoms(int seed, Array randomEnumArray, int randInterval = 1000)
        {
            CurBaseSeed = seed;
            RandomDic = new Dictionary<int, MersenneTwister>();

            var idx = 0;

            foreach (var curRandomIdxObj in randomEnumArray)
            {
                var newSeed = seed + (randInterval * idx++);
                var randomIdx = (int) curRandomIdxObj;

                if (RandomDic.ContainsKey(randomIdx))
                {
                    Debug.Log("RandomEnumArray is wrong..!");
                    continue;
                }
                
                RandomDic.Add(randomIdx, new MersenneTwister(newSeed));
            }

            _isInit = true;
        }

        public static int GetRange(int randomIdx, int min, int max)
        {
            if (_isInit == false)
                return 0;

            return RandomDic[randomIdx].Next(min, max);
        }

        public static void SetNextSeed(int randomIdx)
        {
            var curRandom = RandomDic[randomIdx];
            var nextSeed = curRandom.GetSeed() + 1;

            RandomDic[randomIdx] = new MersenneTwister(nextSeed);
        }
    }
}