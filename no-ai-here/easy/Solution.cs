using System;

namespace no_ai_here
{
    public class Solution
    {
        

        public string convert_number_to_corresponding_month_name(int n)
        {
            string monthName = n switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April", 
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Invalid month number"
            };

            return monthName;
        }


        public int[] find_smallest_and_biggest_numbers_in_an_array(int[] arr)
        {
            if(arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Input array cannot be null or empty.");
            }

            int min = arr[0];
            int max = arr[0];

            foreach(int num in arr)
            {
                if(num < min)
                {
                    min = num;
                }

                if(num > max)
                {
                    max = num;
                }
            }

            return [min, max];
        }

        public int absolute_sum(int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentException("Input array cannot be null.");
            }

            int sum = 0;
            foreach(int num in arr)
            {
                sum += Math.Abs(num);
            }

            return sum;
        }


        public long to_the_power_of(int baseNum, int exponent)
        {
            if(exponent == 0)
            {
                return 1;
            }

            long result = 1;
            for(int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }

            return result;
        }


        public int[] multiply_by_length(int[] arr)
        {
            int multiplier = arr.Length;
            if(multiplier == 0)
            {
                throw new ArgumentException("Input array can not be null.");
            }

            int[] temp_array = new int[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                temp_array[i] = arr[i] * multiplier;
            }

            return temp_array;
        }


        public void int_array_to_string(int[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if(i < arr.Length-1)
                {
                    Console.Write(", ");
                }

            }
            Console.Write("]");
        }



        public int hamming_distance(string n, string m)
        {
            int n_length = n.Length;
            int m_length = m.Length;

            if(n_length != m_length)
            {
                throw new Exception("Both strings should have the same length.");
            }

            int num_differ = 0;
            for(int i = 0; i < n_length; i++)
            {
                if(n[i] != m[i])
                {
                    num_differ++;
                }
            }
            
            return num_differ;
        }

        public string shuffle_the_name(string m)
        {
            if(m.Length == 0 || m == null)
            {
                throw new Exception("Empty string was passed this function.");
            }

            string[] split_string = m.Split(" ");
            Array.Reverse(split_string);
            string reversed = string.Join(" ", split_string);
            return reversed;
        }

        public string smaller_num(string n, string m)
        {
            // Length comparison: fewer digits = smaller number
            if(n.Length < m.Length )  return n;
            if(n.Length > m.Length) return m;
           
            // 2. Equal length: compare digit by digit
            for(int i = 0; i < n.Length; i++)
            {
                if(n[i] < m[i]) return n;
                else if(n[i] > m[i]) return m;
            }

            // 3. If the loop completes without returning, the numbers are equal
            return m; // either n or m;
        }

        public long return_the_factorial(int n)
        {
            long factorial = 1;
            for(int i = n; i > 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }

        public int count_vowels(string n)
        {
            if(string.IsNullOrEmpty(n)) throw new ArgumentException("String cannot be null.");

            // Using a HashSet for 0(1) lookup
            var vowels = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

            int count = n.Count(x => vowels.Contains(x));
            return count;
        }


        public int[] sort_num_ascending(int[] arr)
        {
            if(arr.Length == 0 || arr == null)
            {
                return [];
            }

            // insertion sort
            for(int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;

                while(j > 0 && temp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j = j - 1;
                }
                
                arr[j] = temp;
            }
            return arr;
        }


        public string hacker_speak(string n)
        {
            if (string.IsNullOrEmpty(n))
            {
                throw new ArgumentException("String cannot be null.");
            }

            var charValue = new Dictionary<char, char>
            {
                {'a', '4'},
                {'e', '3'},
                {'i', '1'},
                {'o', '0'},
                {'s', '5'}
            };

            char[] chars = n.ToCharArray();            
            for(int i = 0; i < n.Length; i++)
            {
                if (charValue.ContainsKey(chars[i]))
                {
                    chars[i] = charValue[chars[i]];
                }
            }

            return new string(chars);
        }

        public int count_clap(string text)
        {
            char target = 'C';

            int count = text.Count(c => c == target);
            return count;
        }

        public string shape_with_n_sides(int side)
        {
            var shapes = new Dictionary<int, string>
            {
                {1, "circle"},
                {2, "semi-circle"},
                {3, "triangle"},
                {4, "square"},
                {5, "pentagon"},
                {6, "hexagon"},
                {7, "heptagon"},
                {8, "octagon"},
                {9, "nonagon"},
                {10, "decagon"},
            };

            return shapes[side];
        }

        public string remove_first_last(string text)
        {
            if(text.Length == 0 || text == null)
            {
                throw new ArgumentException("String cannot be null.");
            }

            if(text.Length <= 2) return text;

            string slice = text[1..^1];
            return slice;
        }

    }
}