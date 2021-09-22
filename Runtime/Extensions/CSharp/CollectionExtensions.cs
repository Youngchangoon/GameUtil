using System;
using System.Collections.Generic;
using System.Linq;
using UMT;

namespace LongMan.GameUtil
{
    public static class CollectionExtensions
    {
        #region List<T>

        /// <summary>
        /// 마지막을 반환한다. ( 길이가 0인 경우 예외 )
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static T GetLast<T>(this List<T> list)
        {
            if (list.Count == 0)
                throw new System.IndexOutOfRangeException();
            
            return list[list.Count - 1];
        }

        /// <summary>
        /// 랜덤한 요소를 반환한다. ( 길이가 0인 경우 예외 )
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static T GetRandom<T>(this List<T> list)
        {
            if (list.Count == 0)
                throw new System.IndexOutOfRangeException("Cannot select a random item from an empty list");

            return list[UnityEngine.Random.Range(0, list.Count)];
        }
        
        /// <summary>
        /// 랜덤한 요소를 반환한다. ( 메르센 랜덤 적용 )
        /// </summary>
        /// <param name="list"></param>
        /// <param name="random"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static T GetRandom<T>(this List<T> list, MersenneTwister random)
        {
            if (list.Count == 0)
                throw new System.IndexOutOfRangeException("Cannot select a random item from an empty list");

            return list[random.Next(0, list.Count)];
        }
        
        
        /// <summary>
        /// 랜덤한 요소를 가져오고 삭제한다.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetRandomAndRemove<T>(this List<T> list)
        {
            var randomIndex = UnityEngine.Random.Range(0, list.Count);
            var ret = list[randomIndex];

            list.RemoveAt(randomIndex);

            return ret;
        }
        
        /// <summary>
        /// 랜덤한 요소를 가져오고 삭제한다. ( 메르센 랜덤 적용 )
        /// </summary>
        /// <param name="list"></param>
        /// <param name="random"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetRandomAndRemove<T>(this List<T> list, MersenneTwister random)
        {
            var randomIndex = random.Next(0, list.Count);
            var ret = list[randomIndex];

            list.RemoveAt(randomIndex);

            return ret;
        }

        /// <summary>
        /// 마지막 요소를 지운다.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        public static void RemoveLast<T>(this List<T> list)
        {
            list.RemoveAt(list.Count - 1);
        }

        /// <summary>
        /// 마지막 요소를 Get하고 지운다.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetLastAndRemove<T>(this List<T> list)
        {
            var ret = list.GetLast();
            list.RemoveLast();
            return ret;
        }

        /// <summary>
        /// 리스트를 셔플한다.
        /// </summary>
        /// <param name="list"></param>
        /// <typeparam name="T"></typeparam>
        public static void Shuffle<T>(this IList<T> list)
        {
            var rng = new System.Random();
            var n = list.Count;

            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// 리스트를 셔플한다. ( 메르센 랜덤 적용 )
        /// </summary>
        /// <param name="list"></param>
        /// <param name="mersenneRandom"></param>
        /// <typeparam name="T"></typeparam>
        public static void Shuffle<T>(this IList<T> list, MersenneTwister mersenneRandom)
        {
            var n = list.Count;

            while (n > 1)
            {
                n--;
                var k = mersenneRandom.Next(n + 1);
                var value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// 리스트의 요소를 스왑한다.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="indexA"></param>
        /// <param name="indexB"></param>
        /// <typeparam name="T"></typeparam>
        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        #endregion

        #region Dictionary<T>

        /// <summary>
        /// 랜덤한 KeyValuePair를 가져온다.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static KeyValuePair<TKey, TValue> GetRandomKvp<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return dictionary.ElementAtOrDefault(new Random().Next(dictionary.Count));
        }

        public static KeyValuePair<TKey, TValue> GetRandomKvp<TKey, TValue>(
            this Dictionary<TKey, TValue> dictionary, MersenneTwister random)
        {
            return dictionary.ElementAtOrDefault(random.Next(dictionary.Count));
        }


        /// <summary>
        /// 랜덤한 키를 가져온다.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TKey GetRandomKey<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return GetRandomKvp(dictionary).Key;
        }

        /// <summary>
        /// 랜덤한 값을 가져온다.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue GetRandomValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return GetRandomKvp(dictionary).Value;
        }
        
        
        public static TKey GetRandomKey<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, MersenneTwister random)
        {
            return GetRandomKvp(dictionary, random).Key;
        }

        public static TValue GetRandomValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, MersenneTwister random)
        {
            return GetRandomKvp(dictionary, random).Value;
        }
        
        public static void AddIfEmpty<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue item)
        {
            if (dic.ContainsKey(key))
                return;

            dic.Add(key, item);
        }

        #endregion
    }
}