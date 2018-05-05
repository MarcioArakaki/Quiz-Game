using System.Collections.Generic;
using System.Linq;
using FlagQuiz.Models;

namespace FlagQuiz.Repositories
{
    public class FlagRepository
    {
        private readonly List<Flag> _flags;

        public FlagRepository()
        {
            _flags = InitializeFlags();
        }

        /// <summary>
        /// Initialize the flag repository to simulate a Database
        /// </summary>
        private List<Flag> InitializeFlags()
        {
            return new List<Flag>()
            {
                new Flag()
                {
                    IdFlag = 1,
                    Country = "Brazil",
                    Multiplier = 1,
                    Image = "br.png"
                },
                new Flag()
                {
                    IdFlag = 2,
                    Country = "Japan",
                    Multiplier = 1,
                    Image = "jp.png"
                },
                new Flag()
                {
                    IdFlag = 3,
                    Country = "China",
                    Multiplier = 1,
                    Image = "cn.png"
                },
                new Flag()
                {
                    IdFlag = 4,
                    Country = "Germany",
                    Multiplier = 2,
                    Image = "de.png"
                },
                new Flag()
                {
                    IdFlag = 5,
                    Country = "Korea",
                    Multiplier = 2,
                    Image = "kr.png"
                },
                new Flag()
                {
                    IdFlag = 6,
                    Country = "Australia",
                    Multiplier = 2,
                    Image = "au.png"
                },
                new Flag()
                {
                    IdFlag = 7,
                    Country = "Russia",
                    Multiplier = 3,
                    Image = "ru.png"
                },
                new Flag()
                {
                    IdFlag = 8,
                    Country = "Kazakhstan",
                    Multiplier = 4,
                    Image = "kz.png"
                },
                new Flag()
                {
                    IdFlag = 9,
                    Country = "USA",
                    Multiplier = 1,
                    Image = "us.png"
                },
                new Flag()
                {
                    IdFlag = 10,
                    Country = "India",
                    Multiplier = 2,
                    Image = "in.png"
                },
                new Flag()
                {
                    IdFlag = 11,
                    Country = "Singapore",
                    Multiplier = 2,
                    Image = "sg.png"
                }
            };
        }

        public Flag Get(int IdFlag)
        {
            return _flags.FirstOrDefault(x => x.IdFlag == IdFlag);
        }
    }
}