using System;
using System.Collections.Generic;
using UMT;
using UnityEngine;

namespace YoungPackage.GameUtil.Random
{
    public static class MersenneRandom
    {
        public static Dictionary<int, MersenneTwister> RandomDic;

        private static bool _isInit;
        public static int curBaseSeed { get; private set; }
        
        public static void InitRandoms(int seed, Array randomEnumArray, int randInterval = 1000)
        {
            curBaseSeed = seed;
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