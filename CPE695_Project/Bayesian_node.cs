using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE695_Project
{
    class Bayesian_node
    {
        public enum status{STATUS_TARGET,STATUS_INTERVEND,STATUS_OBSERVED,STATUS_UNKNOWN};
        public static List<Bayesian_node> map = new List<Bayesian_node>();
        public static List<int[]> event_table = new List<int[]>();
        public static int event_count = 0;
        public int index;
        public int time_order;
        public int positionX = 0;
        public int positionY = 0;
        public status type = status.STATUS_UNKNOWN;
        public bool set_value = false;
        public string str;
        public List<int> parents=new List<int>();
        public Bayesian_node() { }
        public Bayesian_node(int index, int time_order, string str)
        {
            this.time_order = time_order;
            this.index = index;
            this.str = str;
            positionX = 50 + (index % 12) * 50;
            positionY = time_order * 50 + 50;
        }
        public override string ToString()
        {
            return str.ToString() + "-" + index.ToString() + ":" + time_order.ToString();
        }
        public static float posibility(int target1, int target2)
        {
            int pn = 0;
            foreach (int[] ele in event_table)
            {
                if (ele[target1] == 1 && ele[target2]==1) pn++;
            }
            return (float)pn / event_count;
        }
        public static float posibility(int target, bool conditional = false)
        {
            if (conditional)
            {
                int pn = 0;
                int pd = 0;
                foreach (int[] ele in event_table)
                {
                    bool flag = true;
                    foreach (var parent in map[target].parents)
                    {
                        if(ele[parent]!=Convert.ToInt32(map[parent].set_value))
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        pd++;
                        if (ele[target] != Convert.ToInt32(map[target].set_value))
                        {
                            pn++;
                        }
                    }
                }
                if (pd == 0) return 0;
                else return (float)pn / pd;
            }
            else
            {
                int pn = 0;
                foreach (int[] ele in event_table)
                {
                    if (ele[target] == 1) pn++;
                }
                return (float)pn / event_count;
            }
        }
        public static float posibility(int target, List<int> given)
        {
            int pn = 0, pd = 0;
            foreach (int[] ele in event_table)
            {
                bool flag = true;
                foreach (int given_index in given)
                {
                    if (ele[given_index] == 0)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    pd++;
                    if (ele[target] == 1)
                    {
                        pn++;
                    }
                }
            }
            if (pd == 0) return 0;
            else return (float)pn / pd;
        }
        public static void create_network(float e)
        {
            foreach(var cause in map)
            {
                foreach(var effect in map)
                {
                    if (cause.index == effect.index) continue;
                    if (cause.time_order > effect.time_order) continue;
                    if (posibility(effect.index) == 0) continue;
                    List<int> given = new List<int>();
                    given.Add(cause.index);
                    if (posibility(effect.index) > posibility(effect.index, given))
                    {
                        bool flag = true;
                        foreach(var suspision in map)
                        {
                            if (suspision.index == cause.index || suspision.index == effect.index) continue;
                            if (suspision.time_order > cause.time_order) continue;
                            if (posibility(suspision.index, cause.index) == 0) continue;
                            List<int> cause_susp = new List<int>();
                            List<int> susp = new List<int>();
                            cause_susp.Add(cause.index);
                            cause_susp.Add(suspision.index);
                            susp.Add(suspision.index);

                            float diff = posibility(effect.index, cause_susp) - posibility(effect.index, susp);
                            diff = Math.Abs(diff);
                            if (diff < e) flag = false;
                        }
                        if (flag)
                        {
                            effect.parents.Add(cause.index);
                            Console.WriteLine(cause.str + "---->" + effect.str);
                        }
                    }
                }
            }
        }
    }
}
