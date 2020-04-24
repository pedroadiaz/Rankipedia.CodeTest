using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Utilities
{
    public static class StaticEntitiesList
    {
        public static List<Make> Makes
        {
            get
            {
                return new List<Make> {
                   new Make {ID = 1, Name = "BMW"},
                   new Make {ID = 2, Name = "Honda"},
                   new Make {ID = 3, Name = "Toyota"},
                };
            }
        }

        public static List<Model> Models
        {
            get
            {
                return new List<Model> {
                   new Model {ID = 1, Name = "M340", MakeID = 1},
                   new Model {ID = 2, Name = "M2", MakeID = 1},
                   new Model {ID = 3, Name = "M4", MakeID = 1},
                   new Model {ID = 4, Name = "M5", MakeID = 1},
                   new Model {ID = 5, Name = "M8", MakeID = 1},
                   new Model {ID = 6, Name = "Civic", MakeID = 2},
                   new Model {ID = 7, Name = "Accord", MakeID = 2},
                   new Model {ID = 8, Name = "Camry", MakeID = 3},
                   new Model {ID = 9, Name = "Supra", MakeID = 3},
                };
            }
        }


        public static List<Trim> Trims
        {
            get
            {
                return new List<Trim> {
                   new Trim {ID = 1, Name = "i", ModelID = 1},
                   new Trim {ID = 2, Name = "xDrive", ModelID = 1},
                   new Trim {ID = 3, Name = "Base", ModelID = 2},
                   new Trim {ID = 4, Name = "xDrive", ModelID = 2},
                   new Trim {ID = 5, Name = "Competition", ModelID = 2},
                   new Trim {ID = 6, Name = "Base", ModelID = 3},
                   new Trim {ID = 7, Name = "xDrive", ModelID = 3},
                   new Trim {ID = 8, Name = "Competition", ModelID = 3},
                   new Trim {ID = 9, Name = "Base", ModelID = 4},
                   new Trim {ID = 10, Name = "xDrive", ModelID = 4},
                   new Trim {ID = 11, Name = "Competition", ModelID = 4},
                   new Trim {ID = 12, Name = "Base", ModelID = 5},
                   new Trim {ID = 13, Name = "xDrive", ModelID = 5},
                   new Trim {ID = 14, Name = "Competition", ModelID = 5},
                   new Trim {ID = 15, Name = "Type R", ModelID = 6},
                   new Trim {ID = 16, Name = "LX", ModelID = 7},
                   new Trim {ID = 17, Name = "EX", ModelID = 7},
                   new Trim {ID = 18, Name = "Sport", ModelID = 7},
                   new Trim {ID = 19, Name = "XSE V6", ModelID = 8},
                   new Trim {ID = 20, Name = "TRD", ModelID = 8},
                   new Trim {ID = 21, Name = "3.0", ModelID = 9},
                   new Trim {ID = 22, Name = "3.0 Premium", ModelID = 9},
                   new Trim {ID = 23, Name = "Launch Edition", ModelID = 9},
                };
            }
        }
    }
}
