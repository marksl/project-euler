// 
//     Copyright 2013 Mark Lamley
//  
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
//  
//         http://www.apache.org/licenses/LICENSE-2.0
//  
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.

using System.Collections.Generic;

namespace Problems
{
    public class Permute
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static List<string> GetPermutations(string characters)
        {
            var perms = new List<string>();
            
            char[] list = characters.ToCharArray();
            int x = list.Length - 1;
            Go(perms, list, 0, x);

            return perms;
        }

        private static void Go(List<string> perms, char[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                perms.Add(new string(list));
            }
            else
                for (i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    Go(perms, list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
    }
}