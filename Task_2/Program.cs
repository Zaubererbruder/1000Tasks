using System.Diagnostics.Metrics;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"клоун уклон {IsAnagramDictionary("клоун", "уклон")}");
            Console.WriteLine($"аааббб ббабаа {IsAnagramDictionary("аааббб", "ббабаа")}");
            Console.WriteLine($"абвгд дгвбй {IsAnagramDictionary("абвгд", "дгвбй")}");
            Console.WriteLine($"аааоо оооаа {IsAnagramDictionary("аааоо", "оооаа")}");

            Console.ReadLine();
        }

        public static bool IsAnagramDictionary(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> _map = new Dictionary<char, int>(s.Length);
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    continue;

                _map.TryAdd(s[i], 0);
                _map.TryAdd(t[i], 0);

                if(++_map[s[i]] == 0)
                    _map.Remove(s[i]);
                if (--_map[t[i]] == 0)
                    _map.Remove(t[i]);
            }

            return _map.Count == 0;
        }

        public static bool IsAnagramDictionary2(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> _map = new Dictionary<char, int>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    continue;

                _map.TryAdd(s[i], 0);
                _map.TryAdd(t[i], 0);

                _map[s[i]]++;
                _map[t[i]]--;
            }

            return _map.Values.Any(x => x != 0);
        }
    }
}
