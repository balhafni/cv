using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_University_App_Enhanced.DataLayer
{
    public class ReadData
    {

        public static List<T> CreateObject<T>(List<string[]> data)
             where T : IEntity, new()
        {
            List<T> objects = new List<T>();
            for (int i = 0; i < data.Count; i++)
            {
                    T tp = new T();
                    tp.SetObjectFields(data[i]);
                    objects.Add(tp);
                }
            return objects;
            }
          
        }
    }

